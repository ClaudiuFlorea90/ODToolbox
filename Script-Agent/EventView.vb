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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub EventView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedCorner(Me, 9)
        Btn_Exit.Image = Frame.Btn_Exit.Image
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub
End Class