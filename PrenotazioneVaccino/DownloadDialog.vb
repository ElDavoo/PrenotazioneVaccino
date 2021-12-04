Public Class DownloadDialog

    Sub New(fiscalCode As String, healthCardID As String)

        InitializeComponent()

        FiscalCodeText.Text = fiscalCode
        HealthCardIDText.Text = healthCardID

    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnOK.Click, BtnCancel.Click
        Close()
    End Sub

    Private Sub ProvinceCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProvinceCombo.SelectedIndexChanged
        BtnOK.Enabled = True
    End Sub

    Public ReadOnly Property Province As Integer
        Get
            Return ProvinceCombo.SelectedIndex
        End Get
    End Property

    Public ReadOnly Property ReservationID As String
        Get
            Return CodeText.Text
        End Get
    End Property

    Public ReadOnly Property FiscalCode As String
        Get
            Return FiscalCodeText.Text
        End Get
    End Property

    Public ReadOnly Property HealthCardID As String
        Get
            Return HealthCardIDText.Text
        End Get
    End Property

End Class