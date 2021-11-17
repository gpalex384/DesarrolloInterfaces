<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Jug1TextBox = New System.Windows.Forms.TextBox()
        Me.Jug2TextBox = New System.Windows.Forms.TextBox()
        Me.img1Button = New System.Windows.Forms.Button()
        Me.img2Button = New System.Windows.Forms.Button()
        Me.DefaultCheck1 = New System.Windows.Forms.CheckBox()
        Me.DefaultCheck2 = New System.Windows.Forms.CheckBox()
        Me.computerCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radio5x5 = New System.Windows.Forms.RadioButton()
        Me.Radio4x4 = New System.Windows.Forms.RadioButton()
        Me.Radio3x3 = New System.Windows.Forms.RadioButton()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SameNameLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Jug2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Jug1PictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Jug2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jug1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 2:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Jug1TextBox
        '
        Me.Jug1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jug1TextBox.Location = New System.Drawing.Point(235, 40)
        Me.Jug1TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Jug1TextBox.Name = "Jug1TextBox"
        Me.Jug1TextBox.Size = New System.Drawing.Size(244, 26)
        Me.Jug1TextBox.TabIndex = 2
        Me.Jug1TextBox.Text = "Player 1"
        Me.Jug1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Jug2TextBox
        '
        Me.Jug2TextBox.Location = New System.Drawing.Point(629, 39)
        Me.Jug2TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Jug2TextBox.Name = "Jug2TextBox"
        Me.Jug2TextBox.Size = New System.Drawing.Size(244, 26)
        Me.Jug2TextBox.TabIndex = 3
        Me.Jug2TextBox.Text = "Player 2"
        Me.Jug2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'img1Button
        '
        Me.img1Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.img1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.img1Button.Location = New System.Drawing.Point(112, 129)
        Me.img1Button.Margin = New System.Windows.Forms.Padding(4)
        Me.img1Button.Name = "img1Button"
        Me.img1Button.Size = New System.Drawing.Size(115, 35)
        Me.img1Button.TabIndex = 6
        Me.img1Button.Text = "Picture:"
        Me.img1Button.UseVisualStyleBackColor = False
        '
        'img2Button
        '
        Me.img2Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.img2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.img2Button.Location = New System.Drawing.Point(506, 129)
        Me.img2Button.Margin = New System.Windows.Forms.Padding(4)
        Me.img2Button.Name = "img2Button"
        Me.img2Button.Size = New System.Drawing.Size(115, 35)
        Me.img2Button.TabIndex = 7
        Me.img2Button.Text = "Picture:"
        Me.img2Button.UseVisualStyleBackColor = False
        '
        'DefaultCheck1
        '
        Me.DefaultCheck1.AutoSize = True
        Me.DefaultCheck1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultCheck1.Location = New System.Drawing.Point(134, 260)
        Me.DefaultCheck1.Margin = New System.Windows.Forms.Padding(4)
        Me.DefaultCheck1.Name = "DefaultCheck1"
        Me.DefaultCheck1.Size = New System.Drawing.Size(85, 24)
        Me.DefaultCheck1.TabIndex = 8
        Me.DefaultCheck1.Text = "Default"
        Me.DefaultCheck1.UseVisualStyleBackColor = True
        '
        'DefaultCheck2
        '
        Me.DefaultCheck2.AutoSize = True
        Me.DefaultCheck2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultCheck2.Location = New System.Drawing.Point(528, 260)
        Me.DefaultCheck2.Margin = New System.Windows.Forms.Padding(4)
        Me.DefaultCheck2.Name = "DefaultCheck2"
        Me.DefaultCheck2.Size = New System.Drawing.Size(85, 24)
        Me.DefaultCheck2.TabIndex = 9
        Me.DefaultCheck2.Text = "Default"
        Me.DefaultCheck2.UseVisualStyleBackColor = True
        '
        'computerCheckBox
        '
        Me.computerCheckBox.AutoSize = True
        Me.computerCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computerCheckBox.Location = New System.Drawing.Point(749, 334)
        Me.computerCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.computerCheckBox.Name = "computerCheckBox"
        Me.computerCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.computerCheckBox.TabIndex = 10
        Me.computerCheckBox.Text = "Computer"
        Me.computerCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Radio5x5)
        Me.GroupBox1.Controls.Add(Me.Radio4x4)
        Me.GroupBox1.Controls.Add(Me.Radio3x3)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 375)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(760, 86)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grid"
        '
        'Radio5x5
        '
        Me.Radio5x5.AutoSize = True
        Me.Radio5x5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio5x5.Location = New System.Drawing.Point(546, 35)
        Me.Radio5x5.Margin = New System.Windows.Forms.Padding(4)
        Me.Radio5x5.Name = "Radio5x5"
        Me.Radio5x5.Size = New System.Drawing.Size(56, 24)
        Me.Radio5x5.TabIndex = 2
        Me.Radio5x5.Text = "5x5"
        Me.Radio5x5.UseVisualStyleBackColor = True
        '
        'Radio4x4
        '
        Me.Radio4x4.AutoSize = True
        Me.Radio4x4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio4x4.Location = New System.Drawing.Point(300, 35)
        Me.Radio4x4.Margin = New System.Windows.Forms.Padding(4)
        Me.Radio4x4.Name = "Radio4x4"
        Me.Radio4x4.Size = New System.Drawing.Size(56, 24)
        Me.Radio4x4.TabIndex = 1
        Me.Radio4x4.Text = "4x4"
        Me.Radio4x4.UseVisualStyleBackColor = True
        '
        'Radio3x3
        '
        Me.Radio3x3.AutoSize = True
        Me.Radio3x3.Checked = True
        Me.Radio3x3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio3x3.Location = New System.Drawing.Point(51, 35)
        Me.Radio3x3.Margin = New System.Windows.Forms.Padding(4)
        Me.Radio3x3.Name = "Radio3x3"
        Me.Radio3x3.Size = New System.Drawing.Size(56, 24)
        Me.Radio3x3.TabIndex = 0
        Me.Radio3x3.TabStop = True
        Me.Radio3x3.Text = "3x3"
        Me.Radio3x3.UseVisualStyleBackColor = True
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BackColor = System.Drawing.Color.Lime
        Me.ConfirmButton.Location = New System.Drawing.Point(363, 492)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(111, 41)
        Me.ConfirmButton.TabIndex = 12
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.Black
        Me.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelButton.Location = New System.Drawing.Point(548, 492)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(111, 41)
        Me.cancelButton.TabIndex = 13
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'SameNameLabel
        '
        Me.SameNameLabel.AutoSize = True
        Me.SameNameLabel.ForeColor = System.Drawing.Color.Red
        Me.SameNameLabel.Location = New System.Drawing.Point(701, 69)
        Me.SameNameLabel.Name = "SameNameLabel"
        Me.SameNameLabel.Size = New System.Drawing.Size(103, 20)
        Me.SameNameLabel.TabIndex = 14
        Me.SameNameLabel.Text = "Same name!"
        Me.SameNameLabel.Visible = False
        '
        'Timer1
        '
        '
        'Jug2PictureBox
        '
        Me.Jug2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Jug2PictureBox.Location = New System.Drawing.Point(629, 129)
        Me.Jug2PictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Jug2PictureBox.Name = "Jug2PictureBox"
        Me.Jug2PictureBox.Size = New System.Drawing.Size(244, 187)
        Me.Jug2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Jug2PictureBox.TabIndex = 5
        Me.Jug2PictureBox.TabStop = False
        '
        'Jug1PictureBox
        '
        Me.Jug1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Jug1PictureBox.Location = New System.Drawing.Point(235, 129)
        Me.Jug1PictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Jug1PictureBox.Name = "Jug1PictureBox"
        Me.Jug1PictureBox.Size = New System.Drawing.Size(244, 187)
        Me.Jug1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Jug1PictureBox.TabIndex = 4
        Me.Jug1PictureBox.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.SameNameLabel)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.computerCheckBox)
        Me.Controls.Add(Me.DefaultCheck2)
        Me.Controls.Add(Me.DefaultCheck1)
        Me.Controls.Add(Me.img2Button)
        Me.Controls.Add(Me.img1Button)
        Me.Controls.Add(Me.Jug2PictureBox)
        Me.Controls.Add(Me.Jug1PictureBox)
        Me.Controls.Add(Me.Jug2TextBox)
        Me.Controls.Add(Me.Jug1TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Configuración del juego"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Jug2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jug1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Jug1TextBox As TextBox
    Friend WithEvents Jug2TextBox As TextBox
    Friend WithEvents Jug1PictureBox As PictureBox
    Friend WithEvents Jug2PictureBox As PictureBox
    Friend WithEvents img1Button As Button
    Friend WithEvents img2Button As Button
    Friend WithEvents DefaultCheck1 As CheckBox
    Friend WithEvents DefaultCheck2 As CheckBox
    Friend WithEvents computerCheckBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Radio5x5 As RadioButton
    Friend WithEvents Radio4x4 As RadioButton
    Friend WithEvents Radio3x3 As RadioButton
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SameNameLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
