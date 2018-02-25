Imports Telegram.Bot
Imports Telegram.Bot.Args

Public Class frm_Main
    Friend WithEvents BotClient As TelegramBotClient
    Sub Write_Line(ByVal Text As String)
        If txt_Events.Text = "" Then
            txt_Events.Text = Text
        Else
            txt_Events.AppendText(vbNewLine & vbNewLine & Text)
        End If
    End Sub
    Sub Write_Log(ByVal Text As String)
        txt_Events.AppendText(Text)
    End Sub
    Sub LoadSettings()
        Me.txt_BotToken.Text = My.Settings.BotToken
    End Sub
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Write_Line("Starting Application...")
        Write_Line("Disabling ""CheckForIllegalCrossThreadCalls""...")
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Write_Log("Done.")
        Write_Line("Loading Settings...")
        LoadSettings()
        Write_Log("Done.")
    End Sub

    Private Sub txt_BotToken_TextChanged(sender As Object, e As EventArgs) Handles txt_BotToken.TextChanged
        My.Settings.BotToken = Me.txt_BotToken.Text
    End Sub

    Private Sub btn_StartStop_Click(sender As Object, e As EventArgs) Handles btn_Start.Click, btn_Stop.Click
        Write_Line("Starting Bot...")
        If BotClient Is Nothing Then
            MsgBox("Bot Client is not initialised or not initialised correctly.", MsgBoxStyle.Exclamation, "Error")
            Write_Log("Error.")
        Else
            BotClient.StartReceiving()
            Write_Log("Done.")
        End If
    End Sub

    Private Sub btn_Init_Click(sender As Object, e As EventArgs) Handles btn_Init.Click
        worket_Init.RunWorkerAsync()
    End Sub

    Private Sub worker_BotDetails_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles worker_BotDetails.DoWork
        Write_Line("Updating Bot Details...")
        txt_BotID.Text = "Updating..."
        txt_Username.Text = "Updating..."
        txt_FullName.Text = "Updating..."
        If BotClient IsNot Nothing And IsConnectionAvailable() Then
            Dim Bot = BotClient.GetMeAsync.Result
            txt_BotID.Text = Bot.Id
            txt_Username.Text = Bot.Username
            txt_FullName.Text = Bot.FirstName & " " & Bot.LastName
            Write_Log("Done.")
        Else
            txt_BotID.Text = "Error..."
            txt_Username.Text = "Error..."
            txt_FullName.Text = "Error..."
            Write_Log("Error.")
        End If
    End Sub

    Private Sub worket_Init_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles worket_Init.DoWork
        Write_Line("Initilising Bot...")
        lbl_BotStatus.Text = "Status : Initilising..."
        btn_Init.Enabled = False
        If My.Settings.BotToken = "" Or My.Settings.BotToken Is Nothing Then
            MsgBox("Bot Token is Empty. Set the bot token to use the bot. You can obtain your bot token from 'BotFather' in Telegram.", MsgBoxStyle.Exclamation, "Set Bot Token")
            Write_Log("Error.")
        Else
            If CreateBotClient(BotClient) Then
                lbl_BotStatus.Text = "Status : Initialised"
                worker_BotDetails.RunWorkerAsync()
                btn_Start.Enabled = True
                Write_Log("Done.")
            Else
                lbl_BotStatus.Text = "Status : Error in initialising"
                btn_Init.Enabled = True
                Write_Log("Error.")
            End If
        End If
    End Sub

    Private Sub cb_ShowToken_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ShowToken.CheckedChanged
        If cb_ShowToken.Checked Then
            txt_BotToken.PasswordChar = ""
        Else
            txt_BotToken.PasswordChar = "X"
        End If
    End Sub
End Class
