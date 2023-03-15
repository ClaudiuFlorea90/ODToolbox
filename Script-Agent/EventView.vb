Public Class EventView



    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub Pnl_Top_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Pnl_Top_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If

    End Sub

    Private Sub Pnl_Top_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp

        draggable = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub EventView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)

    End Sub
End Class