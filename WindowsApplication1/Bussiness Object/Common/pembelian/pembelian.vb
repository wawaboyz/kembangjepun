
Namespace BussinessObject.Common
    Public Class Pembelian
        Private idpembelian As Int32
        Private tglpembelian As Date
        Private namasupplier As String
        Private tax As Int32
        Private grandtotal As Decimal
        Private isdelete As Boolean
        Private iduser As User
        'Private pembelianbarang As NHibernate.Collection.PersistentSet
        Private pembelianbarang As Iesi.Collections.Generic.ISet(Of PembelianBarang)

        Public Sub New()
            pembelianbarang = New Iesi.Collections.Generic.HashedSet(Of PembelianBarang)
        End Sub

        Sub New(ByVal idpem As Int32, ByVal tglpem As Date, ByVal namasupp As String, ByVal t As Int32, ByVal grandt As Decimal, ByVal isdel As Boolean, ByVal u As User, ByVal pembar As Iesi.Collections.Generic.ISet(Of PembelianBarang))
            idpembelian = idpem
            tglpembelian = tglpem
            namasupplier = namasupp
            tax = t
            grandtotal = grandt
            isdelete = isdel
            iduser = u
            pembelianbarang = pembar
        End Sub

        Public Overridable Property eidpembelian() As Int32
            Get
                Return idpembelian
            End Get
            Set(ByVal value As Int32)
                idpembelian = value
            End Set
        End Property

        Public Overridable Property etglpembelian() As Date
            Get
                Return tglpembelian
            End Get
            Set(ByVal value As Date)
                tglpembelian = value
            End Set
        End Property

        Public Overridable Property enamasupplier() As String
            Get
                Return namasupplier
            End Get
            Set(ByVal value As String)
                namasupplier = value
            End Set
        End Property

        Public Overridable Property etax() As Int32
            Get
                Return tax
            End Get
            Set(ByVal value As Int32)
                tax = value
            End Set
        End Property

        Public Overridable Property egrandtotal() As Decimal
            Get
                Return grandtotal
            End Get
            Set(ByVal value As Decimal)
                grandtotal = value
            End Set
        End Property

        Public Overridable Property eisdelete() As Boolean
            Get
                Return isdelete
            End Get
            Set(ByVal value As Boolean)
                isdelete = value
            End Set
        End Property

        Public Overridable Property eiduser() As User
            Get
                Return iduser
            End Get
            Set(value As User)
                iduser = value
            End Set
        End Property

        'Public Overridable Property epembelianbarang() As NHibernate.Collection.Generic.PersistentGenericSet(Of PembelianBarang)
        '    Get
        '        Return pembelianbarang
        '    End Get
        '    Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of PembelianBarang))
        '        pembelianbarang = value
        '    End Set
        'End Property
        Public Overridable Property epembelianbarang() As Iesi.Collections.Generic.ISet(Of PembelianBarang)
            Get
                Return pembelianbarang
            End Get
            Set(value As Iesi.Collections.Generic.ISet(Of PembelianBarang))
                pembelianbarang = value
            End Set
        End Property
    End Class
End Namespace
