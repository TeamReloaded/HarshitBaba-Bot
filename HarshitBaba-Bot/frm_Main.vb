Public Class frm_Main
    Sub LoadSettings()
        Me.txt_BotToken.Text = My.Settings.BotToken
        If My.Settings.BotToken = "" Or My.Settings.BotToken Is Nothing Then
            MsgBox("Bot Token is Empty. Set the bot token to use the bot. You can obtain your bot token from 'BotFather' in Telegram.", MsgBoxStyle.Exclamation, "Set Bot Token")
        End If
    End Sub
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub txt_BotToken_TextChanged(sender As Object, e As EventArgs) Handles txt_BotToken.TextChanged
        My.Settings.BotToken = Me.txt_BotToken.Text
    End Sub
End Class
