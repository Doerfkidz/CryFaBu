Public Class bookorder
    Public quantity As Double
    Public rate As Double
    Sub New(ByVal quantity_new As Double, ByVal rate_new As Double)
        quantity = quantity_new
        rate = rate_new
    End Sub

    Public Overrides Function ToString() As String
        Return quantity & "," & rate
    End Function
End Class
