Public Class Currency
    Public currency As String
    Public currencyLong As String
    Public minConfirmation As Integer
    Public txFee As Double
    Dim isActive As Boolean
    Dim coinType As String
    Dim baseAdress As String
    Dim notice As String

    Sub New(ByVal currency_new As String, ByVal currencyLong_new As String, ByVal minConfirmation_new As Integer, ByVal txFee_new As Double, ByVal isActive_new As Boolean, ByVal coinType_new As String, ByVal baseAdress_new As String, ByVal notice_new As String)
        currency = currency_new
        currencyLong = currencyLong_new
        minConfirmation = minConfirmation_new
        txFee = txFee_new
        isActive = isActive_new
        coinType = coinType_new
        baseAdress = baseAdress_new
        notice = notice_new
    End Sub

    Public Overrides Function ToString() As String
        Return currency & "," & currencyLong & "," & minConfirmation & "," & txFee & "," & isActive & "," & coinType & "," & baseAdress
    End Function
End Class
