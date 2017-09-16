Imports Newtonsoft.Json.Linq

Public Class bittrexWrapper

    Sub New()

    End Sub
    Public Function getJson(ByVal url As String) As String

        Try
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(url)
            webClient.Dispose()
            Return result
        Catch ex As Exception
            MsgBox("Error receiving JSON")
            Return "{" + Chr(34) + "success" + Chr(34) + ": false}"
        End Try

    End Function 'Get json from API endpoint
    Public Function getMarkets() As market()

        Try

            Dim count As Integer = 0
            Dim json As JObject = JObject.Parse(getJson("https://bittrex.com/api/v1.1/public/getmarkets  "))
            Dim markets(json.SelectToken("result").LongCount) As market


            If json.SelectToken("success").ToString() = "True" Then

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
                MsgBox("Returned false successs")
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error parsing markets")
            Return Nothing
        End Try

    End Function 'Receive all markets




End Class
