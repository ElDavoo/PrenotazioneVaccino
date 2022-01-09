Public Class ResultBox

    Public Sub New(title As String, message As String, extendedMessage As String)

        InitializeComponent()

        Text = title

        Me.Message.Text = message
        Me.ExtendedMessage.Text = extendedMessage

    End Sub

End Class