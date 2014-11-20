Public Class PenjualanTreatmentId
    Private idpenjualan As Int32
    Private idtreatment As Int32

    Sub New(ByVal idpen As Int32, ByVal idtre As Int32)
        idpenjualan = idpen
        idtreatment = idtre
    End Sub

    Public Overridable Property eidpenjualan() As Int32
        Get
            Return idpenjualan
        End Get

        Set(ByVal value As Int32)
            idpenjualan = value
        End Set
    End Property

    Public Overridable Property eidtreatment() As Int32
        Get
            Return idtreatment
        End Get

        Set(ByVal value As Int32)
            idtreatment = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        If IsDBNull(obj) Then
            Return False
        End If
        If Me.Equals(obj) Then
            Return True
        End If
        Dim temp As PenjualanTreatmentId = obj
        If IsDBNull(temp) Then
            Return False
        End If
        If idpenjualan <> temp.idpenjualan Then
            Return False
        End If
        If idtreatment <> temp.idtreatment Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return idpenjualan.GetHashCode + 27 * idtreatment.GetHashCode
    End Function
End Class
