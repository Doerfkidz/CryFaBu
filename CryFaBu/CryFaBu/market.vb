Public Class market
    Public marketcurrency As String
    Public basecurrency As String
    Public marketcurrencylong As String
    Public basecurrencylong As String
    Public mindtradesize As Double
    Public marketname As String
    Public isActive As Boolean
    Public created As Date
    Public notice As String
    Public isSponsored As Boolean
    Public logoUrl As Uri

    Sub New(ByVal marketcurrency_new As String, ByVal basecurrency_new As String, ByVal marketcurrencylong_new As String, ByVal basecurrencylong_new As String, ByVal mintradesize_new As Double, ByVal marketname_new As String, ByVal isActive_new As Boolean, ByVal created_new As Date, ByVal notice_new As String, ByVal isSponsored_new As Boolean, ByVal logoUrl_new As Uri)

        Try
            marketcurrency = marketcurrency_new
            basecurrency = basecurrency_new
            marketcurrencylong = marketcurrencylong_new
            mindtradesize = mintradesize_new
            marketname = marketname_new
            isActive = isActive_new
            created = created_new
            notice = notice_new
            isSponsored = isSponsored_new
            logoUrl = logoUrl_new
        Catch ex As Exception
            MsgBox("Failed creating market", MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Overrides Function ToString() As String
        Return (marketcurrency & "," & basecurrency & "," & marketcurrencylong & "," & basecurrencylong & "," & mindtradesize & "," & marketname & "," & isActive & "," & created & "," & notice & "," & isSponsored & "," & logoUrl.ToString)
    End Function

End Class
