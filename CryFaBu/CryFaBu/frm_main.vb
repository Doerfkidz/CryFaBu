Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frm_main

    Public Function init() As Boolean
        Try
            Cbox_coin.SelectedIndex = 0

        Catch ex As Exception
            MsgBox("Fehler beim Initialisieren", MsgBoxStyle.Critical)
        End Try
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim wrapper As bittrexWrapper = New bittrexWrapper
        MsgBox(wrapper.getTicker("BTC", "USD").ToString)

    End Sub
End Class
