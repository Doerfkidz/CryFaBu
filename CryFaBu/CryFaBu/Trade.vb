Public Class Trade
    Public id As String
    Public timeStamp As DateTime
    Public quantity As Double
    Public price As Double
    Public total As Double
    Public fillType As String
    Public orderType As String

    Sub New(ByVal id_new As String, ByVal timeStamp_new As DateTime, ByVal quantity_new As Double, ByVal price_new As Double, ByVal total_new As Double, ByVal fillType_new As String, ByVal orderType_new As String)
        id = id_new
        timeStamp = timeStamp_new
        quantity = quantity_new
        price = price_new
        total = total_new
        fillType = fillType_new
        orderType = orderType_new
    End Sub

    Public Overrides Function ToString() As String
        Return id & "," & timeStamp.ToString & "," & quantity & "," & price & "," & total & "," & fillType & "," & orderType
    End Function
End Class
