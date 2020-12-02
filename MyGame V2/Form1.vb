Public Class Form1
    Dim direction As Integer
    Dim xoffset As Integer
    Dim yoffset As Integer
    Dim ylocation As Integer
    Dim gdir As Integer = -10
    Dim win As Boolean
    'Sub BackgroundSound()
    '   My.Computer.Audio.Play("Super Mario Bros Original Theme.wav",
    '   AudioPlayMode.WaitToComplete)
    'End Sub
    Private Sub Jump_Tick(sender As Object, e As EventArgs) Handles Jump.Tick
        If yoffset > 0 Then
            yoffset = yoffset - 20
        Else
            yoffset = 0
        End If
        MoveTo(PictureBox1, xoffset, -yoffset + 4)
    End Sub

    Private Sub From1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.A, Keys.Left
                MoveLeft.Enabled = True
                MoveRight.Enabled = False
                direction = -1
            Case Keys.D, Keys.Right
                MoveRight.Enabled = True
                MoveLeft.Enabled = False
                MoveTo(PictureBox1, +10, 0)
                direction = 1
            Case Keys.W, Keys.Up
                ylocation = PictureBox1.Location.Y
                If ylocation = 344 Then
                    yoffset = 75
                ElseIf ylocation > 344 Then
                    yoffset = 75
                ElseIf ylocation <> 344 Then
                    yoffset = 0
                End If
            Case Keys.S, Keys.Down
                MoveLeft.Enabled = False
                MoveRight.Enabled = False
            Case Keys.Space
                CreateNew("Bullet", Fireball, PictureBox1.Location)
            Case Keys.Enter
                End
            Case Else

        End Select
    End Sub
    Function Collision(p As String, t As String, Optional ByRef other As Object = vbNull)
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                Return Collision(c, t, other)
            End If
        Next

        Return False
    End Function
    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            Console.WriteLine(c.Name)
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        Else
            If p.Name = "Gumba1" Then
                gdir = gdir * -1
            End If
            If p.Name.Contains("Bullet") And p.Visible = True Then
                p.Location = New Point(12, 0)
                p.Visible = False
            End If
        End If
        Dim other As Object = Nothing
        If Collision("Picturebox1", "Gumba", other) Then
            Dim g As New GameOver
            Me.Visible = False
            g.ShowDialog()
            other.visible = False
            Return

        End If
        Console.WriteLine(p.Name)
        If Collision(p.Name.Contains("Bullet"), "Gumba1", other) Then
            Gumba1.Visible = False
            getObject("Bullet").Visible = False
            Dim f As New Win
            Me.Visible = False
            f.ShowDialog()
            other.visible = False
        End If
    End Sub
    Function getObject(p As String) As PictureBox
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                Return c
            End If
        Next
    End Function

    Sub MoveTo(p As String, distx As Integer, disty As Integer)
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                MoveTo(c, distx, disty)
            End If
        Next
    End Sub
    Sub CreateNew(name As String, pic As PictureBox, location As Point)
        Dim p As New PictureBox
        p.Location = location
        p.Image = pic.Image
        p.Name = name
        p.Width = pic.Width
        p.Height = pic.Height
        p.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(p)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoveTo("Bullet", 20, 0)
    End Sub
    Private Sub gumbaMove_Tick(sender As Object, e As EventArgs) Handles gumbaMove.Tick
        MoveTo(Gumba1, gdir, 0)
    End Sub
    Private Sub MoveLeft_Tick(sender As Object, e As EventArgs) Handles MoveLeft.Tick
        MoveTo(PictureBox1, -10, 0)
    End Sub
    Private Sub MoveRight_Tick(sender As Object, e As EventArgs) Handles MoveRight.Tick
        MoveTo(PictureBox1, 10, 0)
    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    BackgroundSound()
    'End Sub
End Class
