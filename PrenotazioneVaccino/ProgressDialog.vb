Public Class ProgressDialog

    Private closeable As Boolean

    Public Sub New(title As String, Optional closeable As Boolean = True)

        InitializeComponent()

        Text = title
        Me.closeable = closeable

    End Sub

    Private Sub ProgressDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing And Not closeable Then e.Cancel = True
    End Sub

End Class