Imports Newtonsoft.Json.Linq

Public Class bittrexWrapper
    Dim apikey As String

    Sub New()

    End Sub 'Konstruktor/nur public API calls

    Sub New(ByVal apikey_new As String)
        apikey = apikey_new
    End Sub
    Private Function getJson(ByVal url As String) As String

        Try
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(url)
            webClient.Dispose()
            Return result
        Catch ex As Exception
            MsgBox("Error receiving JSON")
            Return "{" + Chr(34) + "success" + Chr(34) + ": false," + Chr(34) + "message" + Chr(34) + ":" + Chr(34) + "Error receiving JSON" + Chr(34) + "}"
        End Try

    End Function 'JSON vom API endpoint holen
    Public Function getMarkets() As market()

        Try

            Dim count As Integer = 0
            Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/public/getmarkets"))



            If json.SelectToken("success").ToString() = "True" Then

                Dim markets(json.SelectToken("result").LongCount) As market

                'Iterate through every market
                For Each current_market In json.SelectToken("result")
                    Dim marketcurrency As String = current_market.SelectToken("MarketCurrency")
                    Dim basecurrency As String = current_market.SelectToken("BaseCurrency")
                    Dim marketcurrencylong As String = current_market.SelectToken("MarketCurrencyLong")
                    Dim basecurrencylong As String = current_market.SelectToken("BaseCurrencyLong")
                    Dim mintradesize As Double = Convert.ToDouble(current_market.SelectToken("MinTradeSize"))
                    Dim marketname As String = current_market.SelectToken("MarketName")
                    Dim isactive As Boolean = Convert.ToBoolean(current_market.SelectToken("IsActive"))
                    Dim created As DateTime = Convert.ToDateTime(current_market.SelectToken("Created"))
                    Dim notice As String = current_market.SelectToken("Notice")
                    Dim issponsored As Boolean
                    Dim logourl As Uri
                    If current_market.SelectToken("IsSponsored").ToString <> "" Then
                        issponsored = Convert.ToBoolean(current_market.SelectToken("IsSponsored"))
                    End If
                    If current_market.SelectToken("LogoUrl").ToString <> "" Then
                        logourl = New Uri(current_market.SelectToken("LogoUrl"))
                    End If

                    'Add new market to the market array
                    markets(count) = New market(marketcurrency, basecurrency, marketcurrencylong, basecurrencylong, mintradesize, marketname, isactive, created, notice, issponsored, logourl)
                    count = count + 1
                Next


                Return markets
            Else
                MsgBox("Error: " & json.SelectToken("message").ToString)
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error parsing markets JSON")
            Return Nothing
        End Try

    End Function 'Alle Märkte holen
    Public Function getTicker(ByVal base As String, ByVal base2 As String)
        Try
            Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/public/getticker?market=" & base & "-" & base2))

            If json.SelectToken("success").ToString() = "True" Then

                Dim bid As Double = Convert.ToDouble(json.SelectToken("result").SelectToken("Bid"))
                Dim ask As Double = Convert.ToDouble(json.SelectToken("result").SelectToken("Ask"))
                Dim last As Double = Convert.ToDouble(json.SelectToken("result").SelectToken("Last"))
                Dim ticker As Ticker = New Ticker(bid, ask, last)
                Return ticker
            Else
                MsgBox("Error: " & json.SelectToken("message").ToString)
            End If
        Catch ex As Exception
            MsgBox("Error parsing Ticker JSON")
        End Try


    End Function 'Ticker für einen bestimmten Markt holen
    Public Function getOrderbook(ByVal market As String, ByVal type As String) As bookorder()
        Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/public/getorderbook?market=" & market & "&type=" & type))
        Try
            If json.SelectToken("success").ToString() = "True" Then
                Dim count As Integer = 0
                Dim orders(json.SelectToken("result").Count) As bookorder


                For Each order In json.SelectToken("result")
                    orders(count) = New bookorder(Convert.ToDouble(order.SelectToken("Quantity")), Convert.ToDouble(order.SelectToken("Rate")))
                    count = count + 1
                Next
                Return orders
            Else
                MsgBox("Error: " & json.SelectToken("message").ToString)
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error parsing Orderbook JSON")
            Return Nothing
        End Try
    End Function 'Auftragsbuch eines Marktes holen
    Public Function getCurrencies() As Currency()
        Try
            Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/public/getcurrencies"))
            Dim currencies(json.SelectToken("result").Count) As Currency
            Dim count As Integer = 0

            If json.SelectToken("success").ToString() = "True" Then
                For Each currency In json.SelectToken("result")
                    Dim currency_name As String = currency.SelectToken("Currency")
                    Dim currencylong As String = currency.SelectToken("CurrencyLong")
                    Dim minconfirmation As Integer = Convert.ToInt16(currency.SelectToken("MinConfirmation"))
                    Dim txfee As Double = Convert.ToDouble(currency.SelectToken("TxFee"))
                    Dim isactive As Boolean = Convert.ToBoolean(currency.SelectToken("IsActive"))
                    Dim cointype As String = currency.SelectToken("CoinType")
                    Dim baseaddress As String = currency.SelectToken("BaseAddress")
                    Dim notice As String = currency.SelectToken("Notice")

                    currencies(count) = New Currency(currency_name, currencylong, minconfirmation, txfee, isactive, cointype, baseaddress, notice)

                    count = count + 1
                Next
                Return currencies
            Else
                MsgBox("Error: " & json.SelectToken("message").ToString())
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error parsing currencies JSON")
            Return Nothing
        End Try

    End Function 'Währungen holen
    Public Function getMarketHistory(ByVal market As String) As Trade()
        Try
            Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/public/getmarkethistory?market=" & market))
            Dim trades(json.SelectToken("result").Count) As Trade
            Dim count As Integer = 0

            If json.SelectToken("success").ToString() = "True" Then

                For Each trade In json.SelectToken("result")
                    Dim id As String = trade.SelectToken("Id")
                    Dim timestamp As DateTime = Convert.ToDateTime(trade.SelectToken("TimeStamp"))
                    Dim quantity As Double = Convert.ToDouble(trade.SelectToken("Quantity"))
                    Dim price As Double = Convert.ToDouble(trade.SelectToken("Price"))
                    Dim total As Double = Convert.ToDouble(trade.SelectToken("Total"))
                    Dim filltype As String = trade.SelectToken("FillType")
                    Dim ordertype As String = trade.SelectToken("OrderType")

                    trades(count) = New Trade(id, timestamp, quantity, price, total, filltype, ordertype)

                    count = count + 1
                Next
                Return trades
            Else
                MsgBox("Error: " & json.SelectToken("message").ToString())
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error parsing marketHistory JSON")
            Return Nothing
        End Try

    End Function 'Markt History holen
    Public Function buyLimit(ByVal market As String, ByVal quantity As Double, ByVal rate As Double) As String
        Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/market/buylimit?apikey=" & apikey & "&market=" & market & "&quantity=" & quantity & "&rate=" & rate))

        If json.SelectToken("success").ToString() = "True" Then
            Return json.SelectToken("result").SelectToken("uuid").ToString()
        Else
            MsgBox("Error: " & json.SelectToken("message").ToString())
            Return Nothing
        End If

    End Function

    Public Function sellLimit(ByVal market As String, ByVal quantity As Double, ByVal rate As Double) As String
        Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/market/selllimit?apikey=" & apikey & "&market=" & market & "&quantity=" & quantity & "&rate=" & rate))

        If json.SelectToken("success").ToString() = "True" Then
            Return json.SelectToken("result").SelectToken("uuid").ToString()
        Else
            MsgBox("Error: " & json.SelectToken("message").ToString())
            Return Nothing
        End If

    End Function

    Public Function cancel(ByVal uuid As String) As Boolean
        Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/market/cancel?apikey=" & apikey & "&uuid=" & uuid))

        If json.SelectToken("success").ToString() = "True" Then
            Return True
        Else
            MsgBox("Error: " & json.SelectToken("message").ToString())
            Return False
        End If

    End Function


    Public Function getOpenOrders(ByVal market As String) As OpenOrder()
        Try
            Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/market/getopenorders?apikey=" & apikey & "&market=" & market))

            If json.SelectToken("success").ToString() = "True" Then
                Dim count As Integer = 0
                Dim openorders(json.SelectToken("result")) As OpenOrder

                For Each openorder In json.SelectToken("result")
                    Dim uuid As String = openorder.SelectToken("Uuid")
                    Dim orderuuid As String = openorder.SelectToken("OrderUuid")
                    Dim exchange As String = openorder.SelectToken("Exchange")
                    Dim ordertype As String = openorder.SelectToken("OrderType")
                    Dim quantity As Double = Convert.ToDouble(openorder.SelectToken("Quantity"))
                    Dim quantityremaining As Double = Convert.ToDouble(openorder.SelectToken("QuantityRemaining"))
                    Dim limit As Double = Convert.ToDouble(openorder.SelectToken("Limit"))
                    Dim commissionpaid As Double = Convert.ToDouble(openorder.SelectToken("CommissionPaid"))
                    Dim price As Double = Convert.ToDouble(openorder.SelectToken("Price"))
                    Dim priceperunit As Double = Convert.ToDouble(openorder.SelectToken("PricePerUnit"))
                    Dim opened As DateTime = Convert.ToDateTime(openorder.SelectToken("Opened"))
                    Dim closed As DateTime = Convert.ToDateTime(openorder.SelectToken("Closed"))
                    Dim cancelinitiated As Boolean = Convert.ToBoolean(openorder.SelectToken("CancelInitiated"))
                    Dim immediateorcancel As Boolean = Convert.ToBoolean(openorder.SelectToken("ImmediateOrCancel"))
                    Dim isconditional As Boolean = Convert.ToBoolean(openorder.SelectToken("IsConditional"))
                    Dim condition As String = openorder.SelectToken("Condition")
                    Dim conditiontarget As String = openorder.SelectToken("ConditionTarget")

                    openorders(count) = New OpenOrder(uuid, orderuuid, exchange, ordertype, quantity, quantityremaining, limit, commissionpaid, price, priceperunit, opened, closed, cancelinitiated, immediateorcancel, isconditional, condition, conditiontarget)
                Next
                Return openorders
            Else
                MsgBox("Error: " & json.SelectToken("message").ToString())
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error while parsing openorder JSON")
            Return Nothing
        End Try


    End Function

End Class
