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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.endDate = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codice fiscale"
        '
        'FiscalCode
        '
        Me.FiscalCode.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiscalCode.Location = New System.Drawing.Point(117, 12)
        Me.FiscalCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FiscalCode.MaxLength = 16
        Me.FiscalCode.Name = "FiscalCode"
        Me.FiscalCode.Size = New System.Drawing.Size(136, 24)
        Me.FiscalCode.TabIndex = 1
        '
        'HealthCardID
        '
        Me.HealthCardID.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthCardID.Location = New System.Drawing.Point(435, 14)
        Me.HealthCardID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HealthCardID.MaxLength = 20
        Me.HealthCardID.Name = "HealthCardID"
        Me.HealthCardID.Size = New System.Drawing.Size(167, 24)
        Me.HealthCardID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
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
        Me.AppointmentsList.Location = New System.Drawing.Point(16, 75)
        Me.AppointmentsList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AppointmentsList.MultiSelect = False
        Me.AppointmentsList.Name = "AppointmentsList"
        Me.AppointmentsList.Size = New System.Drawing.Size(1079, 466)
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
        Me.Search.Location = New System.Drawing.Point(491, 553)
        Me.Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(112, 28)
        Me.Search.TabIndex = 5
        Me.Search.Text = "Cerca"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Reserve
        '
        Me.Reserve.Enabled = False
        Me.Reserve.Location = New System.Drawing.Point(613, 553)
        Me.Reserve.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Reserve.Name = "Reserve"
        Me.Reserve.Size = New System.Drawing.Size(112, 28)
        Me.Reserve.TabIndex = 6
        Me.Reserve.Text = "Prenota"
        Me.Reserve.UseVisualStyleBackColor = True
        '
        'SearchProgress
        '
        Me.SearchProgress.Location = New System.Drawing.Point(853, 553)
        Me.SearchProgress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchProgress.Name = "SearchProgress"
        Me.SearchProgress.Size = New System.Drawing.Size(237, 28)
        Me.SearchProgress.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(660, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Telefono"
        '
        'Phone
        '
        Me.Phone.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.Location = New System.Drawing.Point(733, 12)
        Me.Phone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Phone.MaxLength = 10
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(136, 24)
        Me.Phone.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(879, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(924, 12)
        Me.Email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Email.MaxLength = 500
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(167, 24)
        Me.Email.TabIndex = 11
        '
        'Download
        '
        Me.Download.Location = New System.Drawing.Point(733, 553)
        Me.Download.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(112, 28)
        Me.Download.TabIndex = 12
        Me.Download.Text = "Download"
        Me.Download.UseVisualStyleBackColor = True
        '
        'CBBari
        '
        Me.CBBari.AutoSize = True
        Me.CBBari.Location = New System.Drawing.Point(15, 558)
        Me.CBBari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBBari.Name = "CBBari"
        Me.CBBari.Size = New System.Drawing.Size(55, 21)
        Me.CBBari.TabIndex = 13
        Me.CBBari.Text = "Bari"
        Me.CBBari.UseVisualStyleBackColor = True
        '
        'CBBAT
        '
        Me.CBBAT.AutoSize = True
        Me.CBBAT.Location = New System.Drawing.Point(79, 558)
        Me.CBBAT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBBAT.Name = "CBBAT"
        Me.CBBAT.Size = New System.Drawing.Size(57, 21)
        Me.CBBAT.TabIndex = 14
        Me.CBBAT.Text = "BAT"
        Me.CBBAT.UseVisualStyleBackColor = True
        '
        'CBBrindisi
        '
        Me.CBBrindisi.AutoSize = True
        Me.CBBrindisi.Location = New System.Drawing.Point(147, 558)
        Me.CBBrindisi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBBrindisi.Name = "CBBrindisi"
        Me.CBBrindisi.Size = New System.Drawing.Size(76, 21)
        Me.CBBrindisi.TabIndex = 15
        Me.CBBrindisi.Text = "Brindisi"
        Me.CBBrindisi.UseVisualStyleBackColor = True
        '
        'CBFoggia
        '
        Me.CBFoggia.AutoSize = True
        Me.CBFoggia.Location = New System.Drawing.Point(231, 558)
        Me.CBFoggia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBFoggia.Name = "CBFoggia"
        Me.CBFoggia.Size = New System.Drawing.Size(73, 21)
        Me.CBFoggia.TabIndex = 16
        Me.CBFoggia.Text = "Foggia"
        Me.CBFoggia.UseVisualStyleBackColor = True
        '
        'CBTaranto
        '
        Me.CBTaranto.AutoSize = True
        Me.CBTaranto.Location = New System.Drawing.Point(393, 558)
        Me.CBTaranto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBTaranto.Name = "CBTaranto"
        Me.CBTaranto.Size = New System.Drawing.Size(80, 21)
        Me.CBTaranto.TabIndex = 17
        Me.CBTaranto.Text = "Taranto"
        Me.CBTaranto.UseVisualStyleBackColor = True
        '
        'CBLecce
        '
        Me.CBLecce.AutoSize = True
        Me.CBLecce.Location = New System.Drawing.Point(313, 558)
        Me.CBLecce.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBLecce.Name = "CBLecce"
        Me.CBLecce.Size = New System.Drawing.Size(68, 21)
        Me.CBLecce.TabIndex = 18
        Me.CBLecce.Text = "Lecce"
        Me.CBLecce.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 21)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Prima dose"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(122, 47)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(101, 21)
        Me.RadioButton3.TabIndex = 20
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Terza dose"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Data fine ciclo (YYYY-MM-dd)"
        '
        'endDate
        '
        Me.endDate.Enabled = False
        Me.endDate.Location = New System.Drawing.Point(435, 47)
        Me.endDate.MaxLength = 10
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(167, 22)
        Me.endDate.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(16, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 27)
        Me.Panel1.TabIndex = 23
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 591)
        Me.Controls.Add(Me.endDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton1)
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
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents endDate As TextBox
    Friend WithEvents Panel1 As Panel
End Class
