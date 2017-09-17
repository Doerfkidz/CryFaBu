Public Class OpenOrder
    Public uuid As String
    Public orderUuid As String
    Public exchange As String
    Public orderType As String
    Public quantity As Double
    Public quantityRemaining As Double
    Public limit As Double
    Public commissionPaid As Double
    Public price As Double
    Public pricePerUnit As Double
    Public opened As DateTime
    Public closed As DateTime
    Public cancelInitiated As Boolean
    Public immediateOrCancel As Boolean
    Public isConditional As Boolean
    Public condition As String
    Public conditionTarget As String

    Sub New(ByVal uuid_new As String, ByVal orderUuid_new As String, ByVal exchange_new As String, ByVal orderType_new As String, ByVal quantity_new As String, ByVal quantityRemaining_new As Double, ByVal limit_new As Double, ByVal commissionPaid_new As Double, ByVal price_new As Double, ByVal pricePerUnit_new As Double, ByVal opened_new As DateTime, ByVal closed_new As DateTime, ByVal cancelInitiated_new As Boolean, ByVal immediateOrCancel_new As Boolean, ByVal isConditional_new As Boolean, ByVal condition_new As String, ByVal conditionTarget_new As String)
        uuid = uuid_new
        orderUuid = orderUuid_new
        exchange = exchange_new
        orderType = orderType_new
        quantity = quantity_new
        quantityRemaining = quantityRemaining_new
        limit = limit_new
        commissionPaid = commissionPaid_new
        price = price_new
        pricePerUnit = pricePerUnit_new
        opened = opened_new
        closed = closed_new
        cancelInitiated = cancelInitiated_new
        immediateOrCancel = immediateOrCancel_new
        isConditional = isConditional_new
        condition = condition_new
        conditionTarget = conditionTarget_new
    End Sub

    Public Overrides Function ToString() As String
        Return uuid & "," & orderUuid & "," & exchange & "," & orderType & "," & quantity & "," & quantityRemaining & "," & limit & "," & commissionPaid & "," & price & "," & pricePerUnit & "," & opened & "," & closed & "," & cancelInitiated & "," & immediateOrCancel & "," & isConditional & "," & condition & "," & conditionTarget
    End Function
End Class
