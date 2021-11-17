Public Class Form1
    Public derecha, arriba As Boolean
    Dim bola As New RadioButton
    Const salto As Integer = 10
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nave.Top = Me.ClientSize.Height - Nave.Height
        Nave.Left = (Me.ClientSize.Width / 2) - (Nave.Width / 2)
        ' Posicion inicial de la bola

        Dim x, y As New Random

        'Me.Controls.Add(bola)
        bola.Parent = Me
        bola.Text = ""
        bola.Width = 15
        bola.Left = x.Next(0, Me.ClientSize.Width - bola.Width)
        bola.Top = y.Next(0, Me.ClientSize.Height / 2 - bola.Height)
        bola.Checked = True

        'Determinar el lado de la bola
        If x.Next(0, 2) = 0 Then
            'Derecha
            bola.Left = bola.Left + salto
            bola.Top = bola.Top + salto
            derecha = True
        Else
            'Izquierda
            bola.Left = bola.Left - salto
            bola.Top = bola.Top + salto
            derecha = False
        End If
        arriba = False
        Const ancho_ladrillo = 50
        For i = 0 To ClientSize.Width / ancho_ladrillo
            Dim miladrillo As New Label
            miladrillo.Parent = Me
            miladrillo.Name = "label" & i
            miladrillo.Width = ancho_ladrillo
            miladrillo.Height = 20
            miladrillo.Text = ""
            miladrillo.Top = 0
            miladrillo.Left = i * ancho_ladrillo
            miladrillo.BorderStyle = BorderStyle.FixedSingle
            miladrillo.Tag = 1  'Es un ladrillo
        Next i

        Timer1.Start()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.X < Nave.Left Then
            Nave.Left = Nave.Left - 5
        End If
        If e.X > (Nave.Left + Nave.Width) Then
            Nave.Left = Nave.Left + 5
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Z
                Nave.Left = Nave.Left - 5
                Cursor.Position = New Point(Cursor.Position.X - 5, Cursor.Position.Y)
            Case Keys.X
                Nave.Left = Nave.Left + 5
                Cursor.Position = New Point(Cursor.Position.X + 5, Cursor.Position.Y)
        End Select
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If derecha Then
            bola.Left = bola.Left + salto
        Else
            bola.Left = bola.Left - salto
        End If
        If arriba Then
            bola.Top = bola.Top - salto
        Else
            bola.Top = bola.Top + salto
        End If
        'Comprobar si me salgo por la izquierda
        If bola.Left <= 0 Then
            derecha = True
        End If
        'Comprobar si me salgo por la derecha
        If bola.Left + bola.Width >= Me.ClientSize.Width Then
            derecha = False
        End If

        'Comprobar si me salgo por arriba
        If bola.Top <= 0 Then
            arriba = False
        End If
        'Comprobar si me salgo por abajo
        If bola.Top + bola.Height >= Me.ClientSize.Height Then
            Timer1.Stop()
            bola.Dispose()

            MessageBox.Show("Has perdido")

        End If
        'Comprobar que golpeo la nave
        If bola.Top + bola.Height > Nave.Top And bola.Left + bola.Width > Nave.Left And bola.Left < Nave.Left + Nave.Width Then
            arriba = True
            'Cambio direccion de la bola dependiendo de donde golpee a la nave
            If bola.Left < Nave.Left + Nave.Width / 2 Then
                If derecha Then
                    derecha = False
                    bola.Left = bola.Left - salto
                End If
            Else
                If Not derecha Then
                    derecha = True
                    bola.Left = bola.Left + salto
                End If

                'derecha = Not derecha
            End If
        End If
        'Comprobar que golpeo un ladrillo
        For i = 0 To Me.Controls.Count - 1
            If Controls(i).Tag = 1 Then
                If bola.Top <= Controls(i).Top + Controls(i).Height And
                        bola.Left < Controls(i).Left + Controls(i).Width And
                        bola.Left + bola.Width > Controls(i).Left Then
                    Controls(i).Dispose()
                    arriba = False
                    Exit For
                End If
            End If
        Next
    End Sub
End Class
