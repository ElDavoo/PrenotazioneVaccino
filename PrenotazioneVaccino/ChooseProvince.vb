Public Class ChooseProvince

    Public Property Provincia As Integer = -1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Provincia = ComboBox1.SelectedIndex
        BtnOK.Enabled = ComboBox1.SelectedIndex >= 0

    End Sub

End Class