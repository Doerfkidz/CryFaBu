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

    Private Function calculateQuantity(ByVal dollar As Double, ByVal bitcoinPrice As Double, ByVal coinPrice As Double)
        Return (dollar / bitcoinPrice) / coinPrice
    End Function

    Private Function calculateSellPrice(ByVal prozentGewinn As Double, ByVal coinPrice As Double) As Double
        Return coinPrice + coinPrice * (prozentGewinn / 100)
    End Function

    Public Function setSellOrder(ByVal dollar As Double, ByVal prozentGewinn As Double, ByVal coin As String, ByVal apikey As String) As String
        Try
            Dim wrapper As bittrexWrapper = New bittrexWrapper(apikey)

            Dim coinPrice As Double = wrapper.getTicker("BTC-" & coin).ask
            Dim bitcoinPrice As Double = wrapper.getTicker("USDT-BTC").ask
            Dim quantity As Double = calculateQuantity(dollar, bitcoinPrice, coinPrice)
            Dim sellPrice As Double = calculateSellPrice(prozentGewinn, coinPrice)

            'MsgBox(coinPrice & vbNewLine & bitcoinPrice & vbNewLine & quantity & vbNewLine & sellPrice)

            Dim uuid As String = wrapper.sellLimit("BTC-" & coin, quantity, sellPrice)
            If uuid <> Nothing Then
                Return uuid
            Else
                MsgBox("Error: SetSellOrder")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function setBuyLimit(ByVal dollar As Double, ByVal coin As String, ByVal apikey As String)
        Try
            Dim wrapper As bittrexWrapper = New bittrexWrapper(apikey)
            Dim coinPrice As Double = wrapper.getTicker("BTC-" & coin).ask
            Dim bitcoinPrice As Double = wrapper.getTicker("USDT-BTC").ask
            Dim quantity As Double = calculateQuantity(dollar, bitcoinPrice, coinPrice)

            'MsgBox(coinPrice & vbNewLine & bitcoinPrice & vbNewLine & quantity)
            Dim uuid As String = wrapper.buyLimit("BTC-" & coin, quantity, coinPrice)
            If uuid <> Nothing Then
                Return uuid
            Else
                MsgBox("Error: SetSellOrder")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
    End Sub
End Class
