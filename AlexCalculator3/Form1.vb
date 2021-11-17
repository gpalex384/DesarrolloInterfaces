Public Class Form1

    Dim isOn As Boolean
    Dim listOfOperands As List(Of Double) = New List(Of Double)
    Dim listOfOperators As List(Of String) = New List(Of String)
    Dim subtotal As Double
    Dim isNewValue As Boolean = True
    Dim isNegative As Boolean = False

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
            listOfOperands.Add(CDbl(Val(displayLabel.Text)))
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
            Dim buttonClicked As Button = TryCast(sender, Button)
            If buttonClicked IsNot ButtonPercent Then
                listOfOperands.Add(CDbl(displayLabel.Text))
            End If

            subtotal = listOfOperands(0)
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
        isNegative = False

        listOfOperators.Clear()
        listOfOperands.Clear()


    End Sub

    Private Sub ButtonLastDigit_Click(sender As Object, e As EventArgs) Handles ButtonLastDigit.Click
        If displayLabel.Text.Length > 1 Then
            displayLabel.Text = displayLabel.Text.Substring(0, displayLabel.Text.Length - 1)
        ElseIf displayLabel.Text.Length = 1 Then
            displayLabel.Text = "0"
        End If
    End Sub

End Class
