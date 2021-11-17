Public Class Form1

    Dim listOfOperands As List(Of Double) = New List(Of Double)
    Dim listOfOperators As List(Of String) = New List(Of String)
    Dim isNewValue As Boolean = True

    Private Sub Number_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick, Button2.MouseClick, Button9.MouseClick, Button8.MouseClick, Button7.MouseClick, Button6.MouseClick, Button5.MouseClick, Button4.MouseClick, Button3.MouseClick, Button0.MouseClick, Button_dot.MouseClick
        Dim buttonClicked As Button = TryCast(sender, Button)
        If (displayLabel.Text.Equals("Hi there!") Or isNewValue) AndAlso Not buttonClicked.Text.Equals(".") Then
            displayLabel.Text = buttonClicked.Text
        ElseIf buttonClicked.Text.Equals(".") AndAlso isNewValue Then
            displayLabel.Text = "0,"
        ElseIf buttonClicked.Text.Equals(".") Then
            displayLabel.Text += ","
        Else
            displayLabel.Text += buttonClicked.Text
        End If
        isNewValue = False
    End Sub


End Class
