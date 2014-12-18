
Namespace BussinessObject.Common
    Public Class StokAdjustmentBarang
        Private idstokadjustmentbarang As StokAdjustmentBarangId
        Private jumlah As Int32
        Private harga As Decimal
        Private stokadjustmentSet As StokAdjustment
        Private barangSet As Barang

        Public Sub New()

        End Sub

        Sub New(ByVal idstokad As StokAdjustmentBarangId, ByVal jum As Int32, ByVal har As Decimal, ByVal StokAdjusmentS As StokAdjustment, ByVal barangS As Barang)
            idstokadjustmentbarang = idstokad
            jumlah = jum
            harga = har
            stokadjustmentSet = StokAdjusmentS
            barangSet = barangS
        End Sub

        Public Overridable Property eidstokadjustmentbarang() As StokAdjustmentBarangId
            Get
                Return idstokadjustmentbarang
            End Get

            Set(ByVal value As StokAdjustmentBarangId)
                idstokadjustmentbarang = value
            End Set
        End Property

        Public Overridable Property ejumlah() As Int32
            Get
                Return jumlah
            End Get

            Set(value As Int32)
                jumlah = value
            End Set
        End Property

        Public Overridable Property eharga() As Decimal
            Get
                Return harga
            End Get

            Set(value As Decimal)
                harga = value
            End Set
        End Property

        Public Overridable Property estokadjustmentset() As StokAdjustment
            Get
                Return stokadjustmentSet
            End Get

            Set(ByVal value As StokAdjustment)
                stokadjustmentSet = value
            End Set
        End Property

        Public Overridable Property ebarangset() As Barang
            Get
                Return barangSet
            End Get

            Set(value As Barang)
                barangSet = value
            End Set
        End Property
    End Class
End Namespace
