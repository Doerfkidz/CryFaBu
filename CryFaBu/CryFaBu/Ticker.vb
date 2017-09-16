Public Class Ticker
    Public bid As Double
    Public ask As Double
    Public last As Double

    Sub New(ByVal bid_new As Double, ByVal ask_new As Double, ByVal last_new As Double)
        bid = bid_new
        ask = ask_new
        last = last_new
    End Sub

    Public Overrides Function ToString() As String
        Return bid & "," & ask & "," & last
    End Function
End Class
