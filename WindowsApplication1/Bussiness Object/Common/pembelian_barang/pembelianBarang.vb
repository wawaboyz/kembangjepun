
Namespace BussinessObject.Common
    Public Class PembelianBarang
        Private idpembelianbarang As PembelianBarangId
        Private jumlah As Int32
        Private harga As Decimal
        Private subtotal As Decimal
        Private pembelianSet As Pembelian
        Private barangSet As Barang

        Public Sub New()

        End Sub

        Sub New(ByVal idpembar As PembelianBarangId, ByVal jum As Int32, ByVal har As Decimal, ByVal subt As Decimal, ByVal pembelianS As Pembelian, ByVal barangS As Barang)
            idpembelianbarang = idpembar
            jumlah = jum
            harga = har
            subtotal = subt
            pembelianSet = pembelianS
            barangSet = barangS
        End Sub

        Public Overridable Property eidpembelianbarang() As PembelianBarangId
            Get
                Return idpembelianbarang
            End Get

            Set(ByVal value As PembelianBarangId)
                idpembelianbarang = value
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

        Public Overridable Property esubtotal() As Decimal
            Get
                Return subtotal
            End Get

            Set(value As Decimal)
                subtotal = value
            End Set
        End Property

        Public Overridable Property epembelianset() As Pembelian
            Get
                Return pembelianSet
            End Get

            Set(ByVal value As Pembelian)
                pembelianSet = value
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
