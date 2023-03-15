Imports System.Windows.Forms
Imports System.Drawing.Drawing2D


Public Class RoundedButton
    Inherits Button

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim brush As Brush = New SolidBrush(Me.BackColor)
        Dim pen As Pen = New Pen(Me.ForeColor)
        Dim rect As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim cornerRadius As Integer = Me.Height * 2 / 6
        g.FillPath(brush, GetRoundedRectangle(rect, cornerRadius))
        g.DrawPath(pen, GetRoundedRectangle(rect, cornerRadius))
        MyBase.OnPaint(e)
    End Sub

    Private Function GetRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As GraphicsPath = New GraphicsPath()
        Dim l As Integer = rect.Left
        Dim t As Integer = rect.Top
        Dim w As Integer = rect.Width
        Dim h As Integer = rect.Height
        path.AddArc(l, t, radius, radius, 180, 90)
        path.AddArc(l + w - radius, t, radius, radius, 270, 90)
        path.AddArc(l + w - radius, t + h - radius, radius, radius, 0, 90)
        path.AddArc(l, t + h - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function
End Class
