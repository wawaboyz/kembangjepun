Public Class PembelianBarangId
    Private idpembelian As Int32
    Private idbarang As Int32

    Sub New(ByVal idpem As Int32, ByVal idbar As Int32)
        idpembelian = idpem
        idbarang = idbar
    End Sub

    Public Overridable Property eidpembelian() As Int32
        Get
            Return idpembelian
        End Get

        Set(ByVal value As Int32)
            idpembelian = value
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
        Dim temp As PembelianBarangId = obj
        If IsDBNull(temp) Then
            Return False
        End If
        If idpembelian <> temp.idpembelian Then
            Return False
        End If
        If idbarang <> temp.idbarang Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return idpembelian.GetHashCode + 27 * idbarang.GetHashCode
    End Function
End Class
