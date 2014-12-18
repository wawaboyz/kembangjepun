Namespace BussinessObject.Common
    Public Class StokAdjustmentBarangId
        Private idstokadjustment As Int32
        Private idbarang As Int32

        Sub New()

        End Sub

        Sub New(ByVal idstokad As Int32, ByVal idbar As Int32)
            idstokadjustment = idstokad
            idbarang = idbar
        End Sub

        Public Overridable Property eidstokadjustment() As Int32
            Get
                Return idstokadjustment
            End Get

            Set(ByVal value As Int32)
                idstokadjustment = value
            End Set
        End Property

        Public Overridable Property eidbarang() As Int32
            Get
                Return idbarang
            End Get

            Set(ByVal value As Int32)
                idbarang = value
            End Set
        End Property

        Public Overrides Function Equals(obj As Object) As Boolean
            If IsDBNull(obj) Then
                Return False
            End If
            If Me.Equals(obj) Then
                Return True
            End If
            Dim temp As StokAdjustmentBarangId = obj
            If IsDBNull(temp) Then
                Return False
            End If
            If idstokadjustment <> temp.idstokadjustment Then
                Return False
            End If
            If idbarang <> temp.idbarang Then
                Return False
            End If
            Return True
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return idstokadjustment.GetHashCode + 27 * idbarang.GetHashCode
        End Function
    End Class
End Namespace
