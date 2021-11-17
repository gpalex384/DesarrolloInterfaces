Public Class Form1

    ' firstClicked points to the first Label control 
    ' that the player clicks, but it will be Nothing 
    ' if the player hasn't clicked a label yet
    Private firstClicked As Label = Nothing

    ' secondClicked points to the second Label control 
    ' that the player clicks
    Private secondClicked As Label = Nothing

    ' Use this Random object to choose random icons for the squares
    Private random As New Random

    ' Each of these letters is an interesting icon
    ' in the Webdings font,
    ' and each icon appears twice in this list
    Private icons =
      New List(Of String) From {"L", "L", "Y", "Y", "j", "j", "t", "t",
                                "F", "F", "l", "l", "J", "J", "z", "z", "A", "A", ".", ".", "b", "b", ",", ",",
                                "C", "C", "!", "!", "d", "d", "-", "-", "N", "N", "k", "k"}

    ' Sounds
    Private correctPairSound = New System.Media.SoundPlayer("C:/Windows/Media/notify.wav")
    Private wrongPairSound = New System.Media.SoundPlayer("C:/Windows/Media/ringout.wav")
    Private hidingPairSound = New System.Media.SoundPlayer("C:/Windows/Media/ding.wav")
    Private finishGoodSound = New System.Media.SoundPlayer("C:/Windows/Media/tada.wav")

    Public Sub New()
        ' This call is required by Windows Form Designer
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call
        AssignIconsToSquares()
        ' In realTime, paint borders to each label
        makeBordersToLabels()
    End Sub

    ''' <summary>
    ''' Paint borders to each label
    ''' </summary>
    Private Sub makeBordersToLabels()
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                iconLabel.BorderStyle = BorderStyle.FixedSingle
            End If
        Next
    End Sub

    ''' <summary>
    ''' Assign each icon from the list of icons to a random square
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AssignIconsToSquares()

        ' The TableLayoutPanel has 16 labels,
        ' and the icon list has 16 icons,
        ' so an icon is pulled at random from the list
        ' and added to each label
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next

    End Sub

    ''' <summary>
    ''' Every label's Click event is handled by this event handler
    ''' </summary>
    ''' <param name="sender">The label that was clicked</param>
    ''' <param name="e"></param>
    Private Sub label_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label36.Click, Label35.Click, Label34.Click, Label33.Click, Label32.Click, Label31.Click, Label30.Click, Label3.Click, Label29.Click, Label28.Click, Label27.Click, Label26.Click, Label25.Click, Label24.Click, Label23.Click, Label22.Click, Label21.Click, Label20.Click, Label2.Click, Label19.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

        ' The timer is only on after two non-matching 
        ' icons have been shown to the player, 
        ' so ignore any clicks if the timer is running
        If timer1.Enabled Then Exit Sub

        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then
            ' If the clicked label is black, the player clicked 
            ' an icon that's already been revealed -- 
            ' ignore the click
            If clickedLabel.ForeColor = Color.Black Then Exit Sub

            ' If firstClicked is Nothing, this is the first icon 
            ' in the pair that the player clicked, 
            ' so set firstClicked to the label that the player
            ' clicked, change its color to black, and return
            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                'Start timer 2, if second click is not clicked after 750ms the icon is hidden again
                timer2.Start()
                Exit Sub
            End If
            clickedLabel.ForeColor = Color.Black

            ' If the player gets this far, the timer isn't 
            ' running and firstClicked isn't Nothing, 
            ' so this must be the second icon the player clicked
            ' Set its color to black
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black

            ' If the player clicks this second click, the timer 2 is stopped as the player has arrived on time to the second click
            timer2.Stop()


            ' Check to see if the player won
            CheckForWinner()

            ' If the player clicked two matching icons, keep them 
            ' black and reset firstClicked and secondClicked 
            ' so the player can click another icon
            If firstClicked.Text = secondClicked.Text Then
                firstClicked = Nothing
                secondClicked = Nothing
                correctPairSound.Play()
                Exit Sub
            End If

            ' If the player gets this far, the player 
            ' clicked two different icons, so start the 
            ' timer (which will wait three quarters of 
            ' a second, and then hide the icons)

            timer1.Start()

            'Play sound wrong pair
            wrongPairSound.Play()
        End If
    End Sub

    ''' <summary>
    ''' This timer is started when the player clicks 
    ''' two icons that don't match,
    ''' so it counts three quarters of a second 
    ''' and then turns itself off and hides both icons
    ''' </summary>
    Private Sub timer1_Tick() Handles timer1.Tick
        ' Stop the timer
        timer1.Stop()

        ' Hide both icons
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        ' Reset firstClicked and secondClicked 
        ' so the next time a label is
        ' clicked, the program knows it's the first click
        firstClicked = Nothing
        secondClicked = Nothing

        'Play sound hiding
        hidingPairSound.Play()
    End Sub

    ''' <summary>
    ''' Check every icon to see if it is matched, by 
    ''' comparing its foreground color to its background color. 
    ''' If all of the icons are matched, the player wins
    ''' </summary>
    Private Sub CheckForWinner()

        ' Go through all of the labels in the TableLayoutPanel, 
        ' checking each one to see if its icon is matched
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing AndAlso
           iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
        Next

        ' If the loop didn't return, it didn't find 
        ' any unmatched icons
        ' That means the user won. Show a message (and sound) and close the form
        finishGoodSound.Play()
        MessageBox.Show("You matched all the icons!", "Congratulations")
        Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        timer2.Stop()
        ' Hide firstClicked icon
        firstClicked.ForeColor = firstClicked.BackColor
        ' Reset firstClicked
        ' so the next time a label is
        ' clicked, the program knows it's the first click
        firstClicked = Nothing

    End Sub
End Class
