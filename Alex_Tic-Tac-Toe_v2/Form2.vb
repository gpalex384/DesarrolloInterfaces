Public Class Form2

    Private ConfigConfirmed As Boolean = True
    Public GameSize As Integer
    Public player1Image As Image
    Public player2Image As Image
    Public player1Name As String
    Public player2Name As String
    Private isComputer As Boolean

    ''' <summary> img1Button_Click
    ''' This function shows the openfiledialog to choose the player1 image 
    ''' </summary>
    Private Sub img1Button_Click(sender As Object, e As EventArgs) Handles img1Button.Click

        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            Jug1PictureBox.Load(OpenFileDialog2.FileName)
        End If

    End Sub

    ''' <summary> img2Button_Click
    ''' This function shows the openfiledialog to choose the player2 image 
    ''' </summary>
    Private Sub img2Button_Click(sender As Object, e As EventArgs) Handles img2Button.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            Jug2PictureBox.Load(OpenFileDialog2.FileName)
        End If

    End Sub

    ''' <summary> Timer1_Tick
    ''' This timer checks every tenth if the name of the players is the same
    ''' </summary>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Jug1TextBox.Text.Equals(Jug2TextBox.Text) Then
            SameNameLabel.Visible = True
        Else
            SameNameLabel.Visible = False
        End If
    End Sub

    ''' <summary> computerCheckBox_CheckedChanged
    ''' This function sets properties of some controls depending on the computer check box status
    ''' </summary>
    Private Sub computerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles computerCheckBox.CheckedChanged
        If computerCheckBox.Checked Then
            DefaultCheck2.CheckState = False
            Jug2TextBox.Text = "Computer"
            Jug2PictureBox.Image = My.Resources.bot
            img2Button.Enabled = False
            isComputer = True
        Else
            Jug2TextBox.Text = "Player 2"
            Jug2PictureBox.Image = Nothing
            img2Button.Enabled = True
            isComputer = False
        End If
    End Sub

    ''' <summary> DefaultCheck1_CheckedChanged
    ''' This function sets a default picture for the player 1
    ''' </summary>
    Private Sub DefaultCheck1_CheckedChanged(sender As Object, e As EventArgs) Handles DefaultCheck1.CheckedChanged
        If DefaultCheck1.Checked Then
            Jug1PictureBox.Image = My.Resources.defaultPlayer1
            img1Button.Enabled = False
        Else
            Jug1PictureBox.Image = Nothing
            img1Button.Enabled = True
        End If

    End Sub

    ''' <summary> DefaultCheck2_CheckedChanged
    ''' This function sets a default picture for the player 2
    ''' </summary>
    Private Sub DefaultCheck2_CheckedChanged(sender As Object, e As EventArgs) Handles DefaultCheck2.CheckedChanged
        If DefaultCheck2.Checked Then
            computerCheckBox.CheckState = False
            Jug2PictureBox.Image = My.Resources.defaultPlayer2
            img2Button.Enabled = False
        Else
            Jug2PictureBox.Image = Nothing
            img2Button.Enabled = True
        End If
    End Sub

    ''' <summary> ConfirmButton_Click
    ''' This function checks if everything is ok and starts the game on form 1
    ''' </summary>
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        ConfirmNames()
        ConfirmImages()
        ConfirmGameSize()

        If ConfigConfirmed Then
            Form1.StartGame(GameSize, player1Image, player2Image, isComputer, player1Name, player2Name)
            Me.Close()
        End If

    End Sub

    ''' <summary> ConfirmNames
    ''' This function confirms the player names depending on the corresponding text boxes
    ''' </summary>
    Private Sub ConfirmNames()

        If Not computerCheckBox.Checked Then
            'If the names are equal it will not allow to start the game
            If SameNameLabel.Visible Then
                MessageBox.Show("The name of the players must be different")
                ConfigConfirmed = False
            End If
        End If
        If Not Jug1TextBox.Text.Equals("") Then
            player1Name = Jug1TextBox.Text
        Else
            player1Name = "Player 1"
        End If
        If Not Jug2TextBox.Text.Equals("") Then
            player2Name = Jug2TextBox.Text
        Else
            player2Name = "Player 2"
        End If
    End Sub

    ''' <summary> ConfirmGameSize
    ''' This function reads the chosen size of the board
    ''' </summary>
    Private Sub ConfirmGameSize()
        If Radio3x3.Checked Then
            GameSize = 3
        ElseIf Radio4x4.Checked Then
            GameSize = 4
        Else
            GameSize = 5
        End If
    End Sub

    ''' <summary> ConfirmImages
    ''' This function reads the chosen pictures of each player
    ''' </summary>
    Private Sub ConfirmImages()
        If Jug1PictureBox.Image IsNot Nothing Then
            player1Image = Jug1PictureBox.Image
        Else
            player1Image = My.Resources.defaultPlayer1
        End If
        If Jug2PictureBox.Image IsNot Nothing Then
            player2Image = Jug2PictureBox.Image
        Else
            player2Image = My.Resources.defaultPlayer2
        End If

    End Sub

    ''' <summary> cancelButton_Click
    ''' This function cancels the configuration
    ''' </summary>
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Form2.ActiveForm.Close()
    End Sub
End Class