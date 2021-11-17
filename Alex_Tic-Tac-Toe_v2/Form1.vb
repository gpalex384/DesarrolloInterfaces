Public Class Form1

    ' Declare variables
    Dim isOn As TableLayoutPanel
    'Dim c As Control
    Dim playsFirst As Integer
    Dim player1 As Boolean
    Private player1Score As ArrayList
    Private player2Score As ArrayList
    Private symbol As String
    Private gameCount As Integer
    Private msg As String
    Private sizeOfGame As Integer
    Private controlList As New List(Of Label)
    Private isComputer As Boolean
    Private emptyLabels As New List(Of Boolean)
    Private player1Name As String
    Private player2Name As String
    Private finished As Boolean

    ''' <summary> NewGameToolStripMenuItem_Click
    ''' This function calls the form 2 to set the properties of the game. 
    ''' </summary>
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Dim form2 As New Form2
        form2.Timer1.Start()
        form2.Show()

    End Sub

    ''' <summary> StartGame
    ''' This function initializes the game taking into account the properties that have been set in form 2. 
    ''' </summary>
    Public Sub StartGame(gSize As Integer, player1Image As Image, player2Image As Image, computer As Boolean, p1Name As String, p2Name As String)
        'Initialize game counter
        gameCount = 0
        finished = False
        'Set game configuration 
        sizeOfGame = gSize
        isComputer = computer

        player1Name = p1Name
        player2Name = p2Name

        player1Picture.Image = player1Image
        player1Picture.Visible = False
        player2Picture.Image = player2Image
        player2Picture.Visible = False

        'Initialize the squares
        controlList.Clear()
        tablero.Controls.Clear()

        ' Add the controls to the board in runtime
        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim contPos As Integer = 1

        For index = 0 To gSize ^ 2 - 1
            'adding each label to a list and setting their properties
            controlList.Add(New Label())
            With controlList(index)
                .BorderStyle = BorderStyle.Fixed3D
                .Font = New Font("Webdings", 80, FontStyle.Bold)
                .TextAlign = ContentAlignment.MiddleCenter
                .Location = New Point(xPos, yPos)
                .Height = tablero.Height / gSize
                .Width = tablero.Width / gSize
            End With
            'adding a listener to each created label
            AddHandler controlList(index).Click, AddressOf LabelSelected
            'finally adding controls from the list to the board
            tablero.Controls.Add(controlList(index))

            'increase x position
            xPos += tablero.Width / gSize

            'this will reset the x position if passes the number of labels for each row and increases y position
            If Math.Floor(contPos / gSize) = contPos / gSize Then
                xPos = 0
                yPos += tablero.Height / gSize
            End If

            '+1 counter
            contPos += 1
        Next

        'Choose randomly which player plays first
        Dim rnd As New Random
        playsFirst = rnd.Next(1, 3)
        If playsFirst = 1 Then
            player1 = True
            'Set the visibility of picture of player 1
            player1Picture.BorderStyle = BorderStyle.Fixed3D
            player1Picture.BackColor = Color.Blue
            player1Picture.Visible = True
            If isComputer Then
                player2Picture.Visible = True
            End If
        Else
            'Set the visibility of picture of player 2
            player1 = False
            player2Picture.BorderStyle = BorderStyle.Fixed3D
            player2Picture.BackColor = Color.Red
            player2Picture.Visible = True
            If isComputer Then
                ComputerPlays()
            End If
        End If

    End Sub



    ''' <summary> LabelSelected
    ''' This function sets the mark on the board depending on the player that is playing 
    ''' </summary>
    Private Sub LabelSelected(sender As Object, e As EventArgs)
        'take the clicked label 
        Dim clickedLabel = TryCast(sender, Label)
        If clickedLabel IsNot Nothing Then
            If clickedLabel.Text.Equals("") Then
                Select Case player1
                    Case True
                        symbol = "ñ"        'this is an airplane
                        'hide the picture of the player that has played
                        With player1Picture
                            .BackColor = Color.LightCyan
                            .BorderStyle = BorderStyle.FixedSingle
                            .Visible = False
                        End With
                        'set the appearance of the next player to play
                        With player2Picture
                            .BackColor = Color.Red
                            .BorderStyle = BorderStyle.Fixed3D
                            .Visible = True
                        End With
                        'symbol color
                        clickedLabel.ForeColor = Color.Blue
                    Case Else
                        symbol = "k"        'this is a satellite
                        'hide the picture of the player that has played
                        With player2Picture
                            .BackColor = Color.LightCyan
                            .BorderStyle = BorderStyle.FixedSingle
                            'if the computer is playing, the image will be kept as visible
                            If Not isComputer Then
                                .Visible = False
                            End If
                        End With
                        'set the appearance of the next player to play
                        With player1Picture
                            .BackColor = Color.Blue
                            .BorderStyle = BorderStyle.Fixed3D
                            .Visible = True
                        End With
                        'symbol color
                        clickedLabel.ForeColor = Color.Red
                End Select

                clickedLabel.Text = symbol          'assign the symbol to the label that has been clicked
                CheckWin()                          'check if the player has won
                gameCount += 1                      'counts one more turn, this is useful to detect a draw when all labels have been already clicked

                'if all labels clicked, finish game as draw
                If gameCount = sizeOfGame ^ 2 Then
                    player1Picture.Visible = True
                    player2Picture.Visible = True
                    FinishGame("End of game! This is a DRAW!")
                End If

                'change the logic and set the next player that will play
                If player1 Then
                    player1 = False

                    'if p1 has played and it's computer's turn, there is a special random function
                    If isComputer AndAlso Not finished Then
                        ComputerPlays()
                    End If
                Else
                    player1 = True
                End If

            End If
        End If
    End Sub

    ''' <summary> ComputerPlays
    ''' This function allows a randomly-based computer performance 
    ''' </summary>
    Private Sub ComputerPlays()

        'check the labels that are still empty and store them into an array of booleans
        Dim emptyLabels(sizeOfGame ^ 2) As Boolean
        For index = 0 To tablero.Controls.Count - 1
            If tablero.Controls(index).Text.Equals("") Then
                emptyLabels(index) = True
            Else
                emptyLabels(index) = False
            End If
        Next

        'a random number (representing a random label) is chosen
        Dim rnd2 As New Random
        Dim compPlayed As Integer = rnd2.Next(sizeOfGame ^ 2)
        Dim maxNumber As Integer = 0

        'it will be calculated again until the number is a position in the array that represents an empty label
        While emptyLabels(compPlayed) = False AndAlso maxNumber < 26
            compPlayed = rnd2.Next(sizeOfGame ^ 2)
            maxNumber += 1
        End While

        'once a label is chosen, it will be passed as a parameter to the labelSelected function, to play as it was a normal player 2
        LabelSelected(tablero.Controls(compPlayed), New EventArgs)

    End Sub

    ''' <summary> CheckWin
    ''' This function checks if the current player has won the game 
    ''' </summary>
    Private Sub CheckWin()

        'define an array of strings and a counter, that is useful to control the number of correlative symbols a player has got
        Dim icon(sizeOfGame - 1) As String
        Dim counterWin As Integer = 0

        'Check winner columns
        For col = 0 To sizeOfGame - 1
            icon(col) = controlList(col).Text
            For row = 0 To sizeOfGame - 1
                If controlList(col + sizeOfGame * row).Text = icon(col) AndAlso Not icon(col).Equals("") Then
                    counterWin += 1
                    If counterWin = sizeOfGame Then
                        PlayerHasWon()
                        counterWin = 0
                        Exit For
                    End If
                Else
                    counterWin = 0
                    Exit For
                End If
            Next
        Next


        'Check winner rows
        For row = 0 To sizeOfGame - 1
            icon(row) = controlList(row * (1 + sizeOfGame)).Text
            For col = 0 To sizeOfGame - 1
                If controlList(col + sizeOfGame * row).Text = icon(row) AndAlso Not icon(row).Equals("") Then
                    counterWin += 1
                    If counterWin = sizeOfGame Then
                        PlayerHasWon()
                    End If
                Else
                    counterWin = 0
                    Exit For
                End If
            Next
        Next

        'Check winner right diagonal (\)
        If Not controlList(0).Text.Equals("") Then
            icon(0) = controlList(0).Text
            For index = 0 To sizeOfGame - 1
                If controlList(index * (sizeOfGame + 1)).Text = icon(0) Then
                    counterWin += 1
                    If counterWin = sizeOfGame Then
                        PlayerHasWon()
                    End If
                Else
                    counterWin = 0
                    Exit For
                End If
            Next
        End If

        'Check winner left diagonal (/)
        If Not controlList(sizeOfGame - 1).Text.Equals("") Then
            icon(0) = controlList(sizeOfGame - 1).Text
            For index = 0 To sizeOfGame - 1
                If controlList((sizeOfGame - 1) + index * (sizeOfGame - 1)).Text = icon(0) Then
                    counterWin += 1
                    If counterWin = sizeOfGame Then
                        PlayerHasWon()
                    End If
                Else
                    counterWin = 0
                    Exit For
                End If
            Next
        End If

    End Sub

    ''' <summary> PlayerHasWon
    ''' This function sets the message of which player has won 
    ''' It also defines the final visibility of the picture, so only the winner is shown
    ''' </summary>
    Private Sub PlayerHasWon()
        Dim msg As String
        If player1 Then
            msg = player1Name + " has won!"
            player1Picture.Visible = True
            player2Picture.Visible = False
        ElseIf isComputer Then
            msg = "You loose! The computer won the game!"
            player1Picture.Visible = False
            player2Picture.Visible = True
        Else
            msg = player2Name + " has won!"
            player1Picture.Visible = False
            player2Picture.Visible = True
        End If
        FinishGame(msg)

    End Sub

    ''' <summary> FinishGame
    ''' This function shows the message of which player has won, or if it is a draw 
    ''' It also asks the player to retry or exit the game
    ''' </summary>
    Private Sub FinishGame(msg As String)
        finished = True
        Dim result As DialogResult = MessageBox.Show(msg & vbCrLf & "Would you like to retry?",
                                                     "End of game", MessageBoxButtons.RetryCancel)
        If result = DialogResult.Retry Then

            'reset labels and game counter, and go to new game
            tablero.Controls.Clear()
            gameCount = 0
            NewGameToolStripMenuItem.PerformClick()
        Else

            'exit
            ExitGameToolStripMenuItem.PerformClick()
        End If

    End Sub

    ''' <summary> ExitGameToolStripMenuItem_Click
    ''' This function closes the form1
    ''' </summary>
    Public Sub ExitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitGameToolStripMenuItem.Click
        Form1.ActiveForm.Close()
    End Sub

End Class
