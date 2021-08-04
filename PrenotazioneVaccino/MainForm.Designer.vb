<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FiscalCode = New System.Windows.Forms.TextBox()
        Me.HealthCardID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AppointmentsList = New System.Windows.Forms.ListView()
        Me.Hub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AppointmentDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AppointmentTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Search = New System.Windows.Forms.Button()
        Me.Reserve = New System.Windows.Forms.Button()
        Me.SearchProgress = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Download = New System.Windows.Forms.Button()
        Me.CBBari = New System.Windows.Forms.CheckBox()
        Me.CBBAT = New System.Windows.Forms.CheckBox()
        Me.CBBrindisi = New System.Windows.Forms.CheckBox()
        Me.CBFoggia = New System.Windows.Forms.CheckBox()
        Me.CBTaranto = New System.Windows.Forms.CheckBox()
        Me.CBLecce = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codice fiscale"
        '
        'FiscalCode
        '
        Me.FiscalCode.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiscalCode.Location = New System.Drawing.Point(88, 10)
        Me.FiscalCode.MaxLength = 16
        Me.FiscalCode.Name = "FiscalCode"
        Me.FiscalCode.Size = New System.Drawing.Size(103, 20)
        Me.FiscalCode.TabIndex = 1
        '
        'HealthCardID
        '
        Me.HealthCardID.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthCardID.Location = New System.Drawing.Point(326, 11)
        Me.HealthCardID.MaxLength = 20
        Me.HealthCardID.Name = "HealthCardID"
        Me.HealthCardID.Size = New System.Drawing.Size(126, 20)
        Me.HealthCardID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero tessera sanitaria"
        '
        'AppointmentsList
        '
        Me.AppointmentsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Hub, Me.AppointmentDate, Me.AppointmentTime})
        Me.AppointmentsList.FullRowSelect = True
        Me.AppointmentsList.GridLines = True
        Me.AppointmentsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AppointmentsList.HideSelection = False
        Me.AppointmentsList.Location = New System.Drawing.Point(12, 37)
        Me.AppointmentsList.MultiSelect = False
        Me.AppointmentsList.Name = "AppointmentsList"
        Me.AppointmentsList.Size = New System.Drawing.Size(810, 403)
        Me.AppointmentsList.TabIndex = 4
        Me.AppointmentsList.UseCompatibleStateImageBehavior = False
        Me.AppointmentsList.View = System.Windows.Forms.View.Details
        '
        'Hub
        '
        Me.Hub.Text = "Hub"
        Me.Hub.Width = 600
        '
        'AppointmentDate
        '
        Me.AppointmentDate.Text = "Data"
        Me.AppointmentDate.Width = 119
        '
        'AppointmentTime
        '
        Me.AppointmentTime.Text = "Ora"
        Me.AppointmentTime.Width = 77
        '
        'Search
        '
        Me.Search.Enabled = False
        Me.Search.Location = New System.Drawing.Point(368, 449)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(84, 23)
        Me.Search.TabIndex = 5
        Me.Search.Text = "Cerca"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Reserve
        '
        Me.Reserve.Enabled = False
        Me.Reserve.Location = New System.Drawing.Point(460, 449)
        Me.Reserve.Name = "Reserve"
        Me.Reserve.Size = New System.Drawing.Size(84, 23)
        Me.Reserve.TabIndex = 6
        Me.Reserve.Text = "Prenota"
        Me.Reserve.UseVisualStyleBackColor = True
        '
        'SearchProgress
        '
        Me.SearchProgress.Location = New System.Drawing.Point(640, 449)
        Me.SearchProgress.Name = "SearchProgress"
        Me.SearchProgress.Size = New System.Drawing.Size(178, 23)
        Me.SearchProgress.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(495, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Telefono"
        '
        'Phone
        '
        Me.Phone.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.Location = New System.Drawing.Point(550, 10)
        Me.Phone.MaxLength = 10
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(103, 20)
        Me.Phone.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(659, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(693, 10)
        Me.Email.MaxLength = 500
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(126, 20)
        Me.Email.TabIndex = 11
        '
        'Download
        '
        Me.Download.Location = New System.Drawing.Point(550, 449)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(84, 23)
        Me.Download.TabIndex = 12
        Me.Download.Text = "Download"
        Me.Download.UseVisualStyleBackColor = True
        '
        'CBBari
        '
        Me.CBBari.AutoSize = True
        Me.CBBari.Location = New System.Drawing.Point(11, 453)
        Me.CBBari.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBBari.Name = "CBBari"
        Me.CBBari.Size = New System.Drawing.Size(44, 17)
        Me.CBBari.TabIndex = 13
        Me.CBBari.Text = "Bari"
        Me.CBBari.UseVisualStyleBackColor = True
        '
        'CBBAT
        '
        Me.CBBAT.AutoSize = True
        Me.CBBAT.Location = New System.Drawing.Point(59, 453)
        Me.CBBAT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBBAT.Name = "CBBAT"
        Me.CBBAT.Size = New System.Drawing.Size(47, 17)
        Me.CBBAT.TabIndex = 14
        Me.CBBAT.Text = "BAT"
        Me.CBBAT.UseVisualStyleBackColor = True
        '
        'CBBrindisi
        '
        Me.CBBrindisi.AutoSize = True
        Me.CBBrindisi.Location = New System.Drawing.Point(110, 453)
        Me.CBBrindisi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBBrindisi.Name = "CBBrindisi"
        Me.CBBrindisi.Size = New System.Drawing.Size(59, 17)
        Me.CBBrindisi.TabIndex = 15
        Me.CBBrindisi.Text = "Brindisi"
        Me.CBBrindisi.UseVisualStyleBackColor = True
        '
        'CBFoggia
        '
        Me.CBFoggia.AutoSize = True
        Me.CBFoggia.Location = New System.Drawing.Point(173, 453)
        Me.CBFoggia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBFoggia.Name = "CBFoggia"
        Me.CBFoggia.Size = New System.Drawing.Size(58, 17)
        Me.CBFoggia.TabIndex = 16
        Me.CBFoggia.Text = "Foggia"
        Me.CBFoggia.UseVisualStyleBackColor = True
        '
        'CBTaranto
        '
        Me.CBTaranto.AutoSize = True
        Me.CBTaranto.Location = New System.Drawing.Point(295, 453)
        Me.CBTaranto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBTaranto.Name = "CBTaranto"
        Me.CBTaranto.Size = New System.Drawing.Size(63, 17)
        Me.CBTaranto.TabIndex = 17
        Me.CBTaranto.Text = "Taranto"
        Me.CBTaranto.UseVisualStyleBackColor = True
        '
        'CBLecce
        '
        Me.CBLecce.AutoSize = True
        Me.CBLecce.Location = New System.Drawing.Point(235, 453)
        Me.CBLecce.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBLecce.Name = "CBLecce"
        Me.CBLecce.Size = New System.Drawing.Size(56, 17)
        Me.CBLecce.TabIndex = 18
        Me.CBLecce.Text = "Lecce"
        Me.CBLecce.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 480)
        Me.Controls.Add(Me.CBLecce)
        Me.Controls.Add(Me.CBTaranto)
        Me.Controls.Add(Me.CBFoggia)
        Me.Controls.Add(Me.CBBrindisi)
        Me.Controls.Add(Me.CBBAT)
        Me.Controls.Add(Me.CBBari)
        Me.Controls.Add(Me.Download)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SearchProgress)
        Me.Controls.Add(Me.Reserve)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.AppointmentsList)
        Me.Controls.Add(Me.HealthCardID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FiscalCode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prenotazione vaccino"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FiscalCode As TextBox
    Friend WithEvents HealthCardID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AppointmentsList As ListView
    Friend WithEvents Search As Button
    Friend WithEvents Reserve As Button
    Friend WithEvents Hub As ColumnHeader
    Friend WithEvents AppointmentDate As ColumnHeader
    Friend WithEvents AppointmentTime As ColumnHeader
    Friend WithEvents SearchProgress As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Phone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Download As Button
    Friend WithEvents CBBari As CheckBox
    Friend WithEvents CBBAT As CheckBox
    Friend WithEvents CBBrindisi As CheckBox
    Friend WithEvents CBFoggia As CheckBox
    Friend WithEvents CBTaranto As CheckBox
    Friend WithEvents CBLecce As CheckBox
End Class
