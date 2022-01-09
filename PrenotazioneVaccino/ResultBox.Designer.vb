<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultBox
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
        Me.Message = New System.Windows.Forms.Label()
        Me.ExtendedMessage = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Message
        '
        Me.Message.Location = New System.Drawing.Point(12, 14)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(360, 28)
        Me.Message.TabIndex = 0
        Me.Message.Text = "Test" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test"
        '
        'ExtendedMessage
        '
        Me.ExtendedMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExtendedMessage.Location = New System.Drawing.Point(12, 54)
        Me.ExtendedMessage.Name = "ExtendedMessage"
        Me.ExtendedMessage.ReadOnly = True
        Me.ExtendedMessage.Size = New System.Drawing.Size(360, 166)
        Me.ExtendedMessage.TabIndex = 1
        Me.ExtendedMessage.Text = ""
        Me.ExtendedMessage.WordWrap = False
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(297, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(0, 227)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 34)
        Me.Panel1.TabIndex = 3
        '
        'ResultBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ExtendedMessage)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "ResultBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Message As Label
    Friend WithEvents ExtendedMessage As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
