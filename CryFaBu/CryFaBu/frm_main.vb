Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frm_main

    Private uuids As List(Of String) = New List(Of String)

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

    Public Function setBuyLimit(ByVal dollar As Double, ByVal coin As String, ByVal apikey As String) As String
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

    Public Sub getOpenOrders(ByVal apikey As String)
        Dim wrapper As bittrexWrapper = New bittrexWrapper(apikey)

        For Each coin In Cbox_coin.Items

            For Each openorder As OpenOrder In wrapper.getOpenOrders("BTC-" & coin.Split("/")(1))
                If uuids.Contains(openorder.uuid) Then
                    lbox_orderbook.Items.Add("Eigenschaften") 'Muss noch festgelegt werden
                End If
            Next
        Next


    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function loaduuids() As Boolean
        Try


            For Each uuid In My.Settings.uuids.Split(":")
                uuids.Add(uuid)
            Next
            Return True
        Catch ex As Exception
            MsgBox("Error loading uuids")
            Return False
        End Try

    End Function 'Initialisieren von uuids beim Start

    Private Function saveuuids() As Boolean
        Dim uuids_settings As String = ""
        Try
            For Each uuid In uuids
                uuids_settings = uuids_settings & uuid & ":"
            Next

            If uuids_settings.Length <> 0 Then
                uuids_settings = uuids_settings.Substring(0, uuids_settings.Length - 1)
            End If
            My.Settings.uuids = uuids_settings
            My.Settings.Save()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function 'uuids beim Beenden des Programmes speichern

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        getOpenOrders("asfasf")
    End Sub
End Class
