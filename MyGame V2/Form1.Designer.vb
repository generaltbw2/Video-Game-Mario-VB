<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Jump = New System.Windows.Forms.Timer(Me.components)
        Me.Fireball = New System.Windows.Forms.PictureBox()
        Me.Gumba1 = New System.Windows.Forms.PictureBox()
        Me.Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.aWall = New System.Windows.Forms.PictureBox()
        Me.bWall = New System.Windows.Forms.PictureBox()
        Me.gumbaMove = New System.Windows.Forms.Timer(Me.components)
        Me.MoveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.MoveRight = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Fireball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gumba1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bWall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Jump
        '
        Me.Jump.Enabled = True
        '
        'Fireball
        '
        Me.Fireball.Enabled = False
        Me.Fireball.Image = Global.MyGame_V2.My.Resources.Resources.Fire_Ball1
        Me.Fireball.Location = New System.Drawing.Point(12, 0)
        Me.Fireball.Name = "Fireball"
        Me.Fireball.Size = New System.Drawing.Size(21, 22)
        Me.Fireball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fireball.TabIndex = 3
        Me.Fireball.TabStop = False
        Me.Fireball.Visible = False
        '
        'Gumba1
        '
        Me.Gumba1.Image = Global.MyGame_V2.My.Resources.Resources.Gumba_removebg_preview
        Me.Gumba1.Location = New System.Drawing.Point(611, 344)
        Me.Gumba1.Name = "Gumba1"
        Me.Gumba1.Size = New System.Drawing.Size(54, 53)
        Me.Gumba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Gumba1.TabIndex = 4
        Me.Gumba1.TabStop = False
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.Color.ForestGreen
        Me.Wall.Location = New System.Drawing.Point(-1, 401)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(802, 19)
        Me.Wall.TabIndex = 1
        Me.Wall.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 401)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(802, 50)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MyGame_V2.My.Resources.Resources.Mario_8bit_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(141, 344)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'aWall
        '
        Me.aWall.Location = New System.Drawing.Point(-1, 0)
        Me.aWall.Name = "aWall"
        Me.aWall.Size = New System.Drawing.Size(10, 397)
        Me.aWall.TabIndex = 5
        Me.aWall.TabStop = False
        '
        'bWall
        '
        Me.bWall.Location = New System.Drawing.Point(791, 0)
        Me.bWall.Name = "bWall"
        Me.bWall.Size = New System.Drawing.Size(10, 397)
        Me.bWall.TabIndex = 6
        Me.bWall.TabStop = False
        '
        'gumbaMove
        '
        Me.gumbaMove.Enabled = True
        '
        'MoveLeft
        '
        '
        'MoveRight
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bWall)
        Me.Controls.Add(Me.aWall)
        Me.Controls.Add(Me.Fireball)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Gumba1)
        Me.Name = "Form1"
        CType(Me.Fireball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gumba1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bWall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Wall As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Fireball As PictureBox
    Friend WithEvents Gumba1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Jump As Timer
    Friend WithEvents aWall As PictureBox
    Friend WithEvents bWall As PictureBox
    Friend WithEvents gumbaMove As Timer
    Friend WithEvents MoveLeft As Timer
    Friend WithEvents MoveRight As Timer
End Class
