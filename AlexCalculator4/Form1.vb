Public Class calculatorForm

    Dim isOn As Boolean
    Dim listOfOperands As List(Of Double) = New List(Of Double)
    Dim listOfOperators As List(Of String) = New List(Of String)
    Dim subtotal As Double
    Dim isNewValue As Boolean = True
    Dim isNegative As Boolean = False
    Dim isScientific As Boolean = False
    Dim widthAmpliation As Integer
    Dim exponentClicked As Boolean = False


    ''' <summary>
    ''' Function to set ON the calculator.
    ''' The calculator will not work until this button is pressed (isOn = true)
    ''' It also clears every stored data regarding operands and operators (clear all) [C].
    ''' </summary>
    Private Sub ButtonOn_Click(sender As Object, e As EventArgs) Handles ButtonOn.Click
        displayLabel.Text = "0"
        listOfOperands.Clear()
        listOfOperators.Clear()
        If Not isOn Then
            isOn = True
        End If
    End Sub

    ''' <summary>
    ''' When 'CE' button is clicked, the displayed value is set to 0 and the subtotal is resetted.
    ''' </summary>
    Private Sub ButtonClearError_Click(sender As Object, e As EventArgs) Handles ButtonClearError.Click
        displayLabel.Text = "0"
        subtotal = 0
    End Sub

    ''' <summary>
    ''' If a number (or the dot) is clicked, 
    ''' </summary>
    Private Sub Number_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick, Button2.MouseClick, Button9.MouseClick, Button8.MouseClick, button7.MouseClick, Button6.MouseClick, Button5.MouseClick, Button4.MouseClick, Button3.MouseClick, Button0.MouseClick, ButtonDot.MouseClick
        If isOn Then
            Dim buttonClicked As Button = TryCast(sender, Button)
            'If any number is clicked (not a dot) and it is a new number, it is displayed alone.
            If (displayLabel.Text.Equals("0") Or isNewValue) AndAlso Not buttonClicked.Text.Equals(".") Then
                displayLabel.Text = buttonClicked.Text
                'If a dot is clicked
            ElseIf buttonClicked.Text.Equals(".") AndAlso isNewValue Then
                displayLabel.Text = "0,"    'If '0' is in display, display '0,'
            ElseIf buttonClicked.Text.Equals(".") AndAlso Not displayLabel.Text.Contains(",") Then
                displayLabel.Text += ","    'If another number is displayed, display that number and '0'.
            Else
                displayLabel.Text += buttonClicked.Text     'If any number is pressed, add it to the right
            End If
            If Not displayLabel.Text.Equals("0") Then
                isNewValue = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Function when the button 'plus' is clicked
    ''' </summary>
    Private Sub ButtonSum_Click(sender As Object, e As EventArgs) Handles ButtonSum.Click
        ' Only applicable when other number than 0 (or 0,) is displayed
        If Not displayLabel.Text.Equals("0") Then
            If exponentClicked = True Then
                subtotal = subtotal ^ CDbl(displayLabel.Text)
                displayLabel.Text = CStr(subtotal)
                exponentClicked = False
            End If
            listOfOperands.Add(CDbl(displayLabel.Text))
            listOfOperators.Add("plus")
            isNewValue = True
            isNegative = False
        End If

    End Sub

    ''' <summary>
    ''' Function when the button 'minus' is clicked
    ''' </summary>
    Private Sub ButtonDifference_Click(sender As Object, e As EventArgs) Handles ButtonDifference.Click
        If Not displayLabel.Text.Equals("0") Then
            If exponentClicked = True Then
                subtotal = subtotal ^ CDbl(displayLabel.Text)
                displayLabel.Text = CStr(subtotal)
                exponentClicked = False
            End If
            listOfOperands.Add(CDbl(displayLabel.Text))
            listOfOperators.Add("minus")
            isNewValue = True
            isNegative = False
        End If
    End Sub

    ''' <summary>
    ''' Function when the button 'product' is clicked
    ''' </summary>
    Private Sub ButtonProduct_Click(sender As Object, e As EventArgs) Handles ButtonProduct.Click
        If Not displayLabel.Text.Equals("0") Then
            If exponentClicked = True Then
                subtotal = subtotal ^ CDbl(displayLabel.Text)
                displayLabel.Text = CStr(subtotal)
                exponentClicked = False
            End If
            listOfOperands.Add(CDbl(displayLabel.Text))
            listOfOperators.Add("times")
            isNewValue = True
            isNegative = False
        End If
    End Sub

    ''' <summary>
    ''' Function when the button 'quotient' is clicked
    ''' </summary>
    Private Sub ButtonQuotient_Click(sender As Object, e As EventArgs) Handles ButtonQuotient.Click
        If Not displayLabel.Text.Equals("0") Then
            If exponentClicked = True Then
                subtotal = subtotal ^ CDbl(displayLabel.Text)
                displayLabel.Text = CStr(subtotal)
                exponentClicked = False
            End If
            listOfOperands.Add(CDbl(displayLabel.Text))
            listOfOperators.Add("divide")
            isNewValue = True
            isNegative = False
        End If
    End Sub

    ''' <summary>
    ''' When button 'solve' is clicked, the arrays that contain the series of operands and operators are looped in order to make those operations consecutively
    ''' and saving and adding the result of each loop in 'subtotal' global variable.
    ''' </summary>
    Private Sub ButtonSolve_Click(sender As Object, e As EventArgs) Handles ButtonSolve.Click, ButtonPercent.Click
        If Not displayLabel.Text.Equals("0") AndAlso Not displayLabel.Text.Contains("div") Then
            If exponentClicked = True Then
                subtotal = subtotal ^ CDbl(displayLabel.Text)
                displayLabel.Text = CStr(subtotal)
                exponentClicked = False
                listOfOperators.Clear()
                listOfOperands.Clear()
            End If
            Dim buttonClicked As Button = TryCast(sender, Button)
            If buttonClicked IsNot ButtonPercent Then
                listOfOperands.Add(CDbl(displayLabel.Text))
            End If

            subtotal = listOfOperands(0)

            If listOfOperators.Count > 0 Then

                For index = 0 To listOfOperators.Count() - 1
                    If buttonClicked Is ButtonPercent AndAlso index = listOfOperators.Count() - 1 Then
                        listOfOperands.Add(subtotal * CDbl(displayLabel.Text) / 100)
                    End If
                    Select Case listOfOperators(index)
                        Case "plus"
                            subtotal += listOfOperands(index + 1)
                        Case "minus"
                            subtotal -= listOfOperands(index + 1)
                        Case "times"
                            subtotal *= listOfOperands(index + 1)
                        Case "divide"
                            If listOfOperands(index + 1) <> 0 Then
                                subtotal /= listOfOperands(index + 1)
                            Else
                                displayLabel.Text = "ERR (div 0)"
                            End If
                    End Select
                Next
            End If

        End If
        If subtotal > 1 * Math.Exp(20) Then
            displayLabel.Text = "ERR (too high)"
        Else
            displayLabel.Text = CStr(subtotal)
        End If


        isNewValue = True
        If subtotal < 0 Then
            isNegative = True
        Else
            isNegative = False
        End If

        listOfOperators.Clear()
        listOfOperands.Clear()
    End Sub

    ''' <summary>
    ''' (For calculator III) This button makes negative a positive number, and vice-versa)
    ''' </summary>
    Private Sub ButtonPlusMinus_Click(sender As Object, e As EventArgs) Handles ButtonPlusMinus.Click
        If isNegative Then
            isNegative = False
            displayLabel.Text = displayLabel.Text.Substring(1, displayLabel.Text.Length - 1)
            subtotal = subtotal * (-1)
        Else
            isNegative = True
            displayLabel.Text = "-" & displayLabel.Text
        End If

    End Sub

    ''' <summary>
    ''' This button makes the operation 1/x
    ''' </summary>
    Private Sub ButtonInverse_Click(sender As Object, e As EventArgs) Handles ButtonInverse.Click

        ButtonSolve_Click(sender, e)
        If subtotal = 0 Then
            displayLabel.Text = "ERR (div 0)"
        Else
            subtotal = 1 / subtotal
            displayLabel.Text = CStr(subtotal)
        End If

        isNewValue = True

        listOfOperators.Clear()
        listOfOperands.Clear()

    End Sub

    ''' <summary>
    ''' This function deletes the last introduced character
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonLastDigit_Click(sender As Object, e As EventArgs) Handles ButtonLastDigit.Click
        If displayLabel.Text.Length > 1 Then
            displayLabel.Text = displayLabel.Text.Substring(0, displayLabel.Text.Length - 1)
        ElseIf displayLabel.Text.Length = 1 Then
            displayLabel.Text = "0"
        End If
    End Sub

    ''' <summary>
    ''' Menu to change to standard 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub StripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click, ScientificToolStripMenuItem.Click
        widthAmpliation = Button9.Left - Button8.Left
        Dim menuClicked As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        ' Click on Scientific, from Standard calculator
        If menuClicked.Text.Equals("Scientific") AndAlso isScientific = False Then
            ' Increase form size
            Me.Size = New Size(Me.Size.Width + widthAmpliation, Me.Size.Height)
            ' Move some buttons to right, those that are at the two columns at right
            moveButtons(0)
            displayLabel.Width = displayLabel.Width + widthAmpliation
            ' Insert scientific Buttons
            insertScientificButtons()

            isScientific = True
        End If
        ' Click on Standard, from Scientific calculator
        If menuClicked.Text.Equals("Standard") AndAlso isScientific = True Then
            ' Delete Scientific Buttons
            deleteScientificButtons()
            ' Move some buttons to left
            moveButtons(1)
            displayLabel.Width = displayLabel.Width - widthAmpliation
            ' Reduce form size
            Me.Size = New Size(Me.Size.Width - widthAmpliation, Me.Size.Height)
            isScientific = False
        End If

    End Sub

    ''' <summary>
    ''' This function moves buttons to the right or to the left, to make other buttons fit into the form
    ''' </summary>
    ''' <param name="v"></param>
    Private Sub moveButtons(v As Integer)
        ' v=0 -> move buttons to right
        If v = 0 Then
            For Each ctrl As Control In Me.Controls
                If ctrl.Left > Button9.Left Then
                    ctrl.Left = ctrl.Left + widthAmpliation
                End If
            Next
            ' v=1 -> move back buttons to left
        Else
            For Each ctrl As Control In Me.Controls
                If ctrl.Left > Button9.Left Then
                    ctrl.Left = ctrl.Left - widthAmpliation
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' This function inserts scientific buttons in runtime
    ''' </summary>
    Private Sub insertScientificButtons()
        For index = 1 To 4
            Dim btn As New Button()
            btn.Parent = Me
            btn.Name = "scBtn" & index
            btn.Width = ButtonOn.Width
            btn.Height = ButtonOn.Height
            btn.BackColor = Color.Orange
            btn.ForeColor = Color.Black
            btn.Left = button7.Left + (Button8.Left - button7.Left) * 3
            AddHandler btn.Click, AddressOf HandleScientificButtonClick
            Select Case index
                Case 1
                    btn.Top = Button9.Top
                    btn.Text = "x^2"
                Case 2
                    btn.Top = Button6.Top
                    btn.Text = "x^3"
                Case 3
                    btn.Top = Button3.Top
                    btn.Text = "x^y"
                Case 4
                    btn.Top = ButtonPlusMinus.Top
                    btn.Text = "n!"
            End Select
        Next
    End Sub

    ''' <summary>
    ''' This function clears scientific buttons in runtime
    ''' </summary>
    Private Sub deleteScientificButtons()
        Dim scButtonList As New List(Of Control)
        For Each ctrl As Control In Me.Controls
            If ctrl.Name.Contains("sc") Or ctrl.Text.Contains("n!") Then
                scButtonList.Add(ctrl)
            End If
        Next
        For Each c As Control In scButtonList
            Me.Controls.Remove(c)
        Next
    End Sub

    ''' <summary>
    ''' This function handles with any scientific button the user has just clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HandleScientificButtonClick(sender As Object, e As EventArgs)
        Dim scButton As Button = TryCast(sender, Button)

        If scButton.Text.Equals("x^2") Then
            exponente(2, sender, e)
        ElseIf scButton.Text.Equals("x^3") Then
            exponente(3, sender, e)
        ElseIf scButton.Text.Equals("x^y") Then
            exponente(0, sender, e)
        ElseIf scButton.Text.Equals("n!") Then
            factorial(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' It calculates the factorial of the current subtotal and resets the operands and operators
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub factorial(sender As Object, e As EventArgs)
        ' Only if ON, and if the number is natural
        If isOn AndAlso Math.Round(CDbl(displayLabel.Text)) = CDbl(displayLabel.Text) AndAlso CDbl(displayLabel.Text) > 0 Then
            ' Solve previous operations
            ButtonSolve_Click(sender, e)
            ' Define variable Decimal
            Dim number As Decimal = CLng(displayLabel.Text)

            ' Go through the factorial operation with for loop.
            Try
                For index = number - 1 To 1 Step -1
                    number = number * index
                Next
                displayLabel.Text = CStr(number)
                subtotal = number

                ' Throw an error if the factorial was not successful as the result is too high
            Catch ex As Exception
                displayLabel.Text = "Error: Factorial number is too high"
            End Try

            isNewValue = True

            listOfOperators.Clear()
            listOfOperands.Clear()

        End If
    End Sub

    ''' <summary>
    ''' It calculates any exponent, square, cube or customized. 
    ''' </summary>
    ''' <param name="v"></param>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub exponente(v As Integer, sender As Object, e As EventArgs)
        ' It works only if the calculator is ON
        If isOn Then
            ' Solve previous operations
            ButtonSolve_Click(sender, e)

            ' If square or cube:
            If v > 0 Then
                ' Apply the operation and display the result
                subtotal = subtotal ^ v
                displayLabel.Text = CStr(subtotal)

                ' If x^y
            Else
                exponentClicked = True
                displayLabel.Text = CStr(subtotal)
            End If

            isNewValue = True

            listOfOperators.Clear()
            listOfOperands.Clear()

        End If
    End Sub

    ''' <summary>
    ''' This function opens a new form, called HelpWindow, where some help information is showed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim helpText As String
        helpText = "This is my calculator." & Environment.NewLine & Environment.NewLine &
            "First of all, the calculator must be switched on by pressing the 'ON' button. " & Environment.NewLine & Environment.NewLine &
            "Then, start typing your operands and choosing your operators in order to get your calculations. " & Environment.NewLine & Environment.NewLine &
            "Please be aware that once you press any operator, the previous operation will be executed automatically - this means that the calculator does not keep in memory what you are calculating. " & Environment.NewLine & Environment.NewLine &
            "So you should be sure the operations you want to do - and their order - before you start! If you would like to give any comment, please contact the web page stated below. Thank you! "

        HelpWindow.TextBoxHelp.Text = helpText
        ' Show the help window
        My.Forms.HelpWindow.Show()
    End Sub
End Class
