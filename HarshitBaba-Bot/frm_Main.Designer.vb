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
        Me.cb_ShowToken = New System.Windows.Forms.CheckBox()
        Me.lbl_FullName = New System.Windows.Forms.Label()
        Me.txt_FullName = New System.Windows.Forms.Label()
        Me.txt_BotID = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Init = New System.Windows.Forms.Button()
        Me.btn_Stop = New System.Windows.Forms.Button()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.pnl_BotToken = New System.Windows.Forms.Panel()
        Me.txt_BotToken = New System.Windows.Forms.TextBox()
        Me.lbl_BotToken = New System.Windows.Forms.Label()
        Me.ctl_StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lbl_BotStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.worker_BotDetails = New System.ComponentModel.BackgroundWorker()
        Me.worket_Init = New System.ComponentModel.BackgroundWorker()
        Me.grb_BotEvents = New System.Windows.Forms.GroupBox()
        Me.txt_Events = New System.Windows.Forms.TextBox()
        Me.Spliter_Main = New System.Windows.Forms.Splitter()
        Me.grp_BotOptions = New System.Windows.Forms.GroupBox()
        Me.grb_BotProperties.SuspendLayout()
        Me.pnl_BotToken.SuspendLayout()
        Me.ctl_StatusStrip.SuspendLayout()
        Me.grb_BotEvents.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_BotProperties
        '
        Me.grb_BotProperties.Controls.Add(Me.cb_ShowToken)
        Me.grb_BotProperties.Controls.Add(Me.lbl_FullName)
        Me.grb_BotProperties.Controls.Add(Me.txt_FullName)
        Me.grb_BotProperties.Controls.Add(Me.txt_BotID)
        Me.grb_BotProperties.Controls.Add(Me.lbl_ID)
        Me.grb_BotProperties.Controls.Add(Me.txt_Username)
        Me.grb_BotProperties.Controls.Add(Me.lbl_Username)
        Me.grb_BotProperties.Controls.Add(Me.btn_Init)
        Me.grb_BotProperties.Controls.Add(Me.btn_Stop)
        Me.grb_BotProperties.Controls.Add(Me.btn_Start)
        Me.grb_BotProperties.Controls.Add(Me.pnl_BotToken)
        Me.grb_BotProperties.Dock = System.Windows.Forms.DockStyle.Top
        Me.grb_BotProperties.Location = New System.Drawing.Point(0, 0)
        Me.grb_BotProperties.Name = "grb_BotProperties"
        Me.grb_BotProperties.Size = New System.Drawing.Size(573, 119)
        Me.grb_BotProperties.TabIndex = 0
        Me.grb_BotProperties.TabStop = False
        Me.grb_BotProperties.Text = "Bot Properties"
        '
        'cb_ShowToken
        '
        Me.cb_ShowToken.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_ShowToken.AutoSize = True
        Me.cb_ShowToken.Location = New System.Drawing.Point(480, 42)
        Me.cb_ShowToken.Name = "cb_ShowToken"
        Me.cb_ShowToken.Size = New System.Drawing.Size(87, 17)
        Me.cb_ShowToken.TabIndex = 8
        Me.cb_ShowToken.Text = "Show Token"
        Me.cb_ShowToken.UseVisualStyleBackColor = True
        '
        'lbl_FullName
        '
        Me.lbl_FullName.AutoSize = True
        Me.lbl_FullName.Location = New System.Drawing.Point(13, 94)
        Me.lbl_FullName.Name = "lbl_FullName"
        Me.lbl_FullName.Size = New System.Drawing.Size(79, 13)
        Me.lbl_FullName.TabIndex = 7
        Me.lbl_FullName.Text = "Bot Full Name :"
        '
        'txt_FullName
        '
        Me.txt_FullName.AutoSize = True
        Me.txt_FullName.Location = New System.Drawing.Point(98, 94)
        Me.txt_FullName.Name = "txt_FullName"
        Me.txt_FullName.Size = New System.Drawing.Size(10, 13)
        Me.txt_FullName.TabIndex = 6
        Me.txt_FullName.Text = "-"
        '
        'txt_BotID
        '
        Me.txt_BotID.AutoSize = True
        Me.txt_BotID.Location = New System.Drawing.Point(98, 71)
        Me.txt_BotID.Name = "txt_BotID"
        Me.txt_BotID.Size = New System.Drawing.Size(10, 13)
        Me.txt_BotID.TabIndex = 6
        Me.txt_BotID.Text = "-"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(49, 71)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(43, 13)
        Me.lbl_ID.TabIndex = 5
        Me.lbl_ID.Text = "Bot ID :"
        '
        'txt_Username
        '
        Me.txt_Username.AutoSize = True
        Me.txt_Username.Location = New System.Drawing.Point(98, 49)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(10, 13)
        Me.txt_Username.TabIndex = 4
        Me.txt_Username.Text = "-"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(12, 49)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(80, 13)
        Me.lbl_Username.TabIndex = 3
        Me.lbl_Username.Text = "Bot Username :"
        '
        'btn_Init
        '
        Me.btn_Init.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Init.Image = CType(resources.GetObject("btn_Init.Image"), System.Drawing.Image)
        Me.btn_Init.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Init.Location = New System.Drawing.Point(338, 66)
        Me.btn_Init.Name = "btn_Init"
        Me.btn_Init.Size = New System.Drawing.Size(106, 26)
        Me.btn_Init.TabIndex = 2
        Me.btn_Init.Text = "Initialise the Bot"
        Me.btn_Init.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Init.UseVisualStyleBackColor = True
        '
        'btn_Stop
        '
        Me.btn_Stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Stop.Enabled = False
        Me.btn_Stop.Image = CType(resources.GetObject("btn_Stop.Image"), System.Drawing.Image)
        Me.btn_Stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Stop.Location = New System.Drawing.Point(513, 66)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.Size = New System.Drawing.Size(57, 26)
        Me.btn_Stop.TabIndex = 1
        Me.btn_Stop.Text = "Stop"
        Me.btn_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Stop.UseVisualStyleBackColor = True
        '
        'btn_Start
        '
        Me.btn_Start.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Start.Enabled = False
        Me.btn_Start.Image = CType(resources.GetObject("btn_Start.Image"), System.Drawing.Image)
        Me.btn_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Start.Location = New System.Drawing.Point(450, 66)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(57, 26)
        Me.btn_Start.TabIndex = 1
        Me.btn_Start.Text = "Start"
        Me.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'pnl_BotToken
        '
        Me.pnl_BotToken.Controls.Add(Me.txt_BotToken)
        Me.pnl_BotToken.Controls.Add(Me.lbl_BotToken)
        Me.pnl_BotToken.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_BotToken.Location = New System.Drawing.Point(3, 16)
        Me.pnl_BotToken.Name = "pnl_BotToken"
        Me.pnl_BotToken.Size = New System.Drawing.Size(567, 22)
        Me.pnl_BotToken.TabIndex = 0
        '
        'txt_BotToken
        '
        Me.txt_BotToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_BotToken.Location = New System.Drawing.Point(89, 0)
        Me.txt_BotToken.Name = "txt_BotToken"
        Me.txt_BotToken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txt_BotToken.Size = New System.Drawing.Size(478, 20)
        Me.txt_BotToken.TabIndex = 1
        '
        'lbl_BotToken
        '
        Me.lbl_BotToken.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_BotToken.Location = New System.Drawing.Point(0, 0)
        Me.lbl_BotToken.Name = "lbl_BotToken"
        Me.lbl_BotToken.Size = New System.Drawing.Size(89, 22)
        Me.lbl_BotToken.TabIndex = 0
        Me.lbl_BotToken.Text = "Bot Token :"
        Me.lbl_BotToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctl_StatusStrip
        '
        Me.ctl_StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_BotStatus})
        Me.ctl_StatusStrip.Location = New System.Drawing.Point(0, 258)
        Me.ctl_StatusStrip.Name = "ctl_StatusStrip"
        Me.ctl_StatusStrip.Size = New System.Drawing.Size(573, 22)
        Me.ctl_StatusStrip.TabIndex = 1
        Me.ctl_StatusStrip.Text = "StatusStrip1"
        '
        'lbl_BotStatus
        '
        Me.lbl_BotStatus.Name = "lbl_BotStatus"
        Me.lbl_BotStatus.Size = New System.Drawing.Size(140, 17)
        Me.lbl_BotStatus.Text = "Status : Not initialised yet"
        '
        'worker_BotDetails
        '
        '
        'worket_Init
        '
        '
        'grb_BotEvents
        '
        Me.grb_BotEvents.Controls.Add(Me.txt_Events)
        Me.grb_BotEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_BotEvents.Location = New System.Drawing.Point(205, 119)
        Me.grb_BotEvents.Name = "grb_BotEvents"
        Me.grb_BotEvents.Size = New System.Drawing.Size(368, 139)
        Me.grb_BotEvents.TabIndex = 2
        Me.grb_BotEvents.TabStop = False
        Me.grb_BotEvents.Text = "Bot Events"
        '
        'txt_Events
        '
        Me.txt_Events.BackColor = System.Drawing.Color.Black
        Me.txt_Events.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Events.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Events.ForeColor = System.Drawing.Color.White
        Me.txt_Events.Location = New System.Drawing.Point(3, 16)
        Me.txt_Events.Multiline = True
        Me.txt_Events.Name = "txt_Events"
        Me.txt_Events.ReadOnly = True
        Me.txt_Events.Size = New System.Drawing.Size(362, 120)
        Me.txt_Events.TabIndex = 0
        '
        'Spliter_Main
        '
        Me.Spliter_Main.Location = New System.Drawing.Point(200, 119)
        Me.Spliter_Main.Name = "Spliter_Main"
        Me.Spliter_Main.Size = New System.Drawing.Size(5, 139)
        Me.Spliter_Main.TabIndex = 3
        Me.Spliter_Main.TabStop = False
        '
        'grp_BotOptions
        '
        Me.grp_BotOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.grp_BotOptions.Location = New System.Drawing.Point(0, 119)
        Me.grp_BotOptions.Name = "grp_BotOptions"
        Me.grp_BotOptions.Size = New System.Drawing.Size(200, 139)
        Me.grp_BotOptions.TabIndex = 4
        Me.grp_BotOptions.TabStop = False
        Me.grp_BotOptions.Text = "Options"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 280)
        Me.Controls.Add(Me.grb_BotEvents)
        Me.Controls.Add(Me.Spliter_Main)
        Me.Controls.Add(Me.grp_BotOptions)
        Me.Controls.Add(Me.grb_BotProperties)
        Me.Controls.Add(Me.ctl_StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Text = "HarshitBaba"
        Me.grb_BotProperties.ResumeLayout(False)
        Me.grb_BotProperties.PerformLayout()
        Me.pnl_BotToken.ResumeLayout(False)
        Me.pnl_BotToken.PerformLayout()
        Me.ctl_StatusStrip.ResumeLayout(False)
        Me.ctl_StatusStrip.PerformLayout()
        Me.grb_BotEvents.ResumeLayout(False)
        Me.grb_BotEvents.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grb_BotProperties As GroupBox
    Friend WithEvents pnl_BotToken As Panel
    Friend WithEvents txt_BotToken As TextBox
    Friend WithEvents lbl_BotToken As Label
    Friend WithEvents btn_Start As Button
    Friend WithEvents ctl_StatusStrip As StatusStrip
    Friend WithEvents lbl_BotStatus As ToolStripStatusLabel
    Friend WithEvents btn_Init As Button
    Friend WithEvents btn_Stop As Button
    Friend WithEvents txt_BotID As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents txt_Username As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_FullName As Label
    Friend WithEvents txt_FullName As Label
    Friend WithEvents worker_BotDetails As System.ComponentModel.BackgroundWorker
    Friend WithEvents worket_Init As System.ComponentModel.BackgroundWorker
    Friend WithEvents grb_BotEvents As GroupBox
    Friend WithEvents Spliter_Main As Splitter
    Friend WithEvents grp_BotOptions As GroupBox
    Friend WithEvents txt_Events As TextBox
    Friend WithEvents cb_ShowToken As CheckBox
End Class
