<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.grb_BotProperties = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_BotToken = New System.Windows.Forms.Label()
        Me.txt_BotToken = New System.Windows.Forms.TextBox()
        Me.grb_BotProperties.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_BotProperties
        '
        Me.grb_BotProperties.Controls.Add(Me.Panel1)
        Me.grb_BotProperties.Dock = System.Windows.Forms.DockStyle.Top
        Me.grb_BotProperties.Location = New System.Drawing.Point(0, 0)
        Me.grb_BotProperties.Name = "grb_BotProperties"
        Me.grb_BotProperties.Size = New System.Drawing.Size(573, 66)
        Me.grb_BotProperties.TabIndex = 0
        Me.grb_BotProperties.TabStop = False
        Me.grb_BotProperties.Text = "Bot Properties"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_BotToken)
        Me.Panel1.Controls.Add(Me.lbl_BotToken)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 22)
        Me.Panel1.TabIndex = 0
        '
        'lbl_BotToken
        '
        Me.lbl_BotToken.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_BotToken.Location = New System.Drawing.Point(0, 0)
        Me.lbl_BotToken.Name = "lbl_BotToken"
        Me.lbl_BotToken.Size = New System.Drawing.Size(69, 22)
        Me.lbl_BotToken.TabIndex = 0
        Me.lbl_BotToken.Text = "Bot Token :"
        Me.lbl_BotToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_BotToken
        '
        Me.txt_BotToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_BotToken.Location = New System.Drawing.Point(69, 0)
        Me.txt_BotToken.Name = "txt_BotToken"
        Me.txt_BotToken.Size = New System.Drawing.Size(498, 20)
        Me.txt_BotToken.TabIndex = 1
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 280)
        Me.Controls.Add(Me.grb_BotProperties)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Text = "HarshitBaba"
        Me.grb_BotProperties.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grb_BotProperties As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_BotToken As TextBox
    Friend WithEvents lbl_BotToken As Label
End Class
