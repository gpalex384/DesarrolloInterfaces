<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpWindow
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxHelp = New System.Windows.Forms.TextBox()
        Me.LinkLabelGoogle = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tips and calculator description"
        '
        'TextBoxHelp
        '
        Me.TextBoxHelp.Enabled = False
        Me.TextBoxHelp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHelp.Location = New System.Drawing.Point(12, 56)
        Me.TextBoxHelp.Multiline = True
        Me.TextBoxHelp.Name = "TextBoxHelp"
        Me.TextBoxHelp.ReadOnly = True
        Me.TextBoxHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxHelp.Size = New System.Drawing.Size(525, 448)
        Me.TextBoxHelp.TabIndex = 2
        '
        'LinkLabelGoogle
        '
        Me.LinkLabelGoogle.AutoSize = True
        Me.LinkLabelGoogle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelGoogle.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelGoogle.Location = New System.Drawing.Point(160, 529)
        Me.LinkLabelGoogle.Name = "LinkLabelGoogle"
        Me.LinkLabelGoogle.Size = New System.Drawing.Size(218, 20)
        Me.LinkLabelGoogle.TabIndex = 3
        Me.LinkLabelGoogle.TabStop = True
        Me.LinkLabelGoogle.Text = "Find what you're looking for!"
        '
        'HelpWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 558)
        Me.Controls.Add(Me.LinkLabelGoogle)
        Me.Controls.Add(Me.TextBoxHelp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HelpWindow"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxHelp As TextBox
    Friend WithEvents LinkLabelGoogle As LinkLabel
End Class
