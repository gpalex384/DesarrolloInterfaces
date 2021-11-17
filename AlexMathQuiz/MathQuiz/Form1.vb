Imports System.Media.SoundPlayer


Public Class Form1

    ' Random number
    Dim rnd As New Random

    Dim gameFinished As Boolean = False

    ' Integer operands
    Dim addend1 As Integer
    Dim addend2 As Integer
    Dim minuend As Integer
    Dim subtrahend As Integer
    Dim multiplicant As Integer
    Dim multiplier As Integer
    Dim dividend As Integer
    Dim divisor As Integer

    ' Time left in seconds
    Dim timeLeft As Integer

    ' Sounds
    Private correctSoundPlayer = New System.Media.SoundPlayer("C:/Windows/Media/notify.wav")
    Private timeUpSoundPlayer = New System.Media.SoundPlayer("C:/Windows/Media/ringout.wav")
    Private finishGoodSoundPlayer = New System.Media.SoundPlayer("C:/Windows/Media/tada.wav")

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        startTheQuiz()
        startButton.Enabled = False
    End Sub

    Private Sub startTheQuiz()

        ' Sum problem
        addend1 = rnd.Next(51)
        addend2 = rnd.Next(51)
        plusLeftLabel.Text = addend1.ToString
        plusRightLabel.Text = addend2.ToString
        sum.Value = 0

        ' difference problem
        minuend = rnd.Next(1, 101)
        subtrahend = rnd.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString
        minusRightLabel.Text = subtrahend.ToString
        difference.Value = 0

        ' product problem
        multiplicant = rnd.Next(2, 11)
        multiplier = rnd.Next(2, 11)
        timesLeftLabel.Text = multiplicant.ToString
        timesRightLabel.Text = multiplier.ToString
        product.Value = 0

        ' quotient problem
        divisor = rnd.Next(2, 11)
        Dim temporaryQuotient As Integer = rnd.Next(2, 11)
        dividend = divisor * temporaryQuotient
        dividedLeftLabel.Text = dividend.ToString
        dividedRightLabel.Text = divisor.ToString
        quotient.Value = 0

        ' Start the timer
        timeLeft = 30
        timeLabel.Text = "30 seconds"
        timer1.Start()
        gameFinished = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If checkAnswer() Then
            ' if all operations are correct, timer stops, game finishes, a message Is shown 
            ' And the start button Is enabled to allow start again
            finishGoodSoundPlayer.Play()
            timeLabel.BackColor = Color.Ivory
            timer1.Stop()
            MessageBox.Show("You got all of the answers right!", "Congratulations!")
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            ' Set background color to the time label to warn about time left
            If timeLeft < 5 Then
                timeLabel.BackColor = Color.Red
            ElseIf timeLeft <= 15 Then
                timeLabel.BackColor = Color.Yellow
            End If
            ' One second less, we show the seconds left
            timeLeft -= 1
            timeLabel.Text = timeLeft.ToString + " seconds"
        Else
            ' Time is up, game finishes, message pops up
            gameFinished = True
            timeUpSoundPlayer.Play()
            timer1.Stop()
            timeLabel.BackColor = Color.Ivory
            timeLabel.Text = "Time is up!"
            MessageBox.Show("You didn't finish in time", "Sorry")

            ' And results are shown
            sum.Value = addend1 + addend2
            difference.Value = minuend - subtrahend
            product.Value = multiplicant * multiplier
            quotient.Value = dividend / divisor

            ' start button enabled to be able to play again
            startButton.Enabled = True

        End If
    End Sub

    Private Function checkAnswer() As Boolean
        Dim conditionSum As Boolean = addend1 + addend2 = sum.Value
        Dim conditionDifference As Boolean = minuend - subtrahend = difference.Value
        Dim conditionProduct As Boolean = multiplicant * multiplier = product.Value
        Dim conditionQuotient As Boolean = dividend / divisor = quotient.Value

        If conditionSum AndAlso conditionDifference AndAlso conditionProduct AndAlso conditionQuotient Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub answer_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum.Enter, quotient.Enter, product.Enter, difference.Enter

        ' Select the whole answer in the NumericUpDown control.
        Dim answerBox = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If

    End Sub

    Private Sub isCorrectValueSum(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim answerBox = TryCast(sender, NumericUpDown)
        If answerBox.Value = addend1 + addend2 AndAlso Not gameFinished Then
            correctSoundPlayer.Play()
        End If

    End Sub


    Private Sub isCorrectValueDiff(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim answerBox = TryCast(sender, NumericUpDown)
        If answerBox.Value = minuend - subtrahend AndAlso Not gameFinished Then
            correctSoundPlayer.Play()
        End If

    End Sub

    Private Sub isCorrectValueProd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim answerBox = TryCast(sender, NumericUpDown)
        If answerBox.Value = multiplicant * multiplier AndAlso Not gameFinished Then
            correctSoundPlayer.Play()
        End If

    End Sub

    Private Sub isCorrectValueQuot(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim answerBox = TryCast(sender, NumericUpDown)
        If answerBox.Value = dividend / divisor AndAlso Not gameFinished Then
            correctSoundPlayer.Play()
        End If

    End Sub

End Class
