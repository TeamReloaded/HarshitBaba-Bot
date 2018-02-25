Imports Telegram.Bot
Public Class PublicVariables
    Public Bot_Token As String = My.Settings.BotToken
    Public BotClient As TelegramBotClient
    Function CreateBotClient() As Boolean
        If Bot_Token IsNot Nothing And Bot_Token <> "" Then
            Try
                BotClient = New TelegramBotClient(Bot_Token)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function
End Class
