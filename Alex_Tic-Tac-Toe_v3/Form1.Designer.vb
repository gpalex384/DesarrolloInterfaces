<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.player1Picture = New System.Windows.Forms.PictureBox()
        Me.player2Picture = New System.Windows.Forms.PictureBox()
        Me.tablero = New System.Windows.Forms.Panel()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.player1Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mainTableLayoutPanel.ColumnCount = 2
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.tablero, 0, 1)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 2
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(1017, 603)
        Me.mainTableLayoutPanel.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(711, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitGameToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.NewGameToolStripMenuItem.Text = "New game"
        '
        'ExitGameToolStripMenuItem
        '
        Me.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem"
        Me.ExitGameToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.ExitGameToolStripMenuItem.Text = "Exit game"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.player1Picture, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.player2Picture, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(714, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(300, 567)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'player1Picture
        '
        Me.player1Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.player1Picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.player1Picture.Location = New System.Drawing.Point(3, 3)
        Me.player1Picture.Name = "player1Picture"
        Me.player1Picture.Size = New System.Drawing.Size(294, 277)
        Me.player1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player1Picture.TabIndex = 0
        Me.player1Picture.TabStop = False
        Me.player1Picture.Visible = False
        '
        'player2Picture
        '
        Me.player2Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.player2Picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.player2Picture.Location = New System.Drawing.Point(3, 286)
        Me.player2Picture.Name = "player2Picture"
        Me.player2Picture.Size = New System.Drawing.Size(294, 278)
        Me.player2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player2Picture.TabIndex = 1
        Me.player2Picture.TabStop = False
        Me.player2Picture.Visible = False
        '
        'tablero
        '
        Me.tablero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablero.Location = New System.Drawing.Point(3, 33)
        Me.tablero.Name = "tablero"
        Me.tablero.Size = New System.Drawing.Size(705, 567)
        Me.tablero.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 603)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIC-TAC-TOE"
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.player1Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents player1Picture As PictureBox
    Friend WithEvents player2Picture As PictureBox
    Friend WithEvents tablero As Panel
End Class
