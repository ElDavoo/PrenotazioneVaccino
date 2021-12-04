<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadDialog
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
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.ProvinceCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodeText = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.HealthCardIDText = New System.Windows.Forms.TextBox()
        Me.FiscalCodeText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Enabled = False
        Me.BtnOK.Location = New System.Drawing.Point(348, 97)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 5
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'ProvinceCombo
        '
        Me.ProvinceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProvinceCombo.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.ProvinceCombo.FormattingEnabled = True
        Me.ProvinceCombo.Items.AddRange(New Object() {"Bari", "BAT", "Brindisi", "Foggia", "Lecce", "Taranto"})
        Me.ProvinceCombo.Location = New System.Drawing.Point(122, 55)
        Me.ProvinceCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.ProvinceCombo.Name = "ProvinceCombo"
        Me.ProvinceCombo.Size = New System.Drawing.Size(75, 21)
        Me.ProvinceCombo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codice prenotazione"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Provincia"
        '
        'CodeText
        '
        Me.CodeText.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeText.Location = New System.Drawing.Point(122, 16)
        Me.CodeText.MaxLength = 11
        Me.CodeText.Name = "CodeText"
        Me.CodeText.Size = New System.Drawing.Size(75, 20)
        Me.CodeText.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(268, 97)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Annulla"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'HealthCardIDText
        '
        Me.HealthCardIDText.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthCardIDText.Location = New System.Drawing.Point(296, 56)
        Me.HealthCardIDText.MaxLength = 20
        Me.HealthCardIDText.Name = "HealthCardIDText"
        Me.HealthCardIDText.Size = New System.Drawing.Size(126, 20)
        Me.HealthCardIDText.TabIndex = 3
        '
        'FiscalCodeText
        '
        Me.FiscalCodeText.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiscalCodeText.Location = New System.Drawing.Point(319, 16)
        Me.FiscalCodeText.MaxLength = 16
        Me.FiscalCodeText.Name = "FiscalCodeText"
        Me.FiscalCodeText.Size = New System.Drawing.Size(103, 20)
        Me.FiscalCodeText.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codice fiscale"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Numero tessera"
        '
        'DownloadDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 131)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HealthCardIDText)
        Me.Controls.Add(Me.FiscalCodeText)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.CodeText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.ProvinceCombo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 170)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 170)
        Me.Name = "DownloadDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download promemoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents ProvinceCombo As ComboBox
    Friend WithEvents CodeText As TextBox
    Friend WithEvents HealthCardIDText As TextBox
    Friend WithEvents FiscalCodeText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
