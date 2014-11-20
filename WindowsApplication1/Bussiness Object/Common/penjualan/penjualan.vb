
Namespace BussinessObject.Common
    Public Class Penjualan
        Private idpenjualan As Int32
        Private tglpenjualan As Date
        Private namacustomer As String
        Private grandtotal As Decimal
        Private carabayar As String
        Private nokartu As String
        Private namabank As String
        Private diskon As Int32
        Private isdelete As Boolean
        Private idcustomer As customer
        Private iduser As User
        Private paketpenjualan As NHibernate.Collection.PersistentSet
        Private penjualantreatment As NHibernate.Collection.PersistentSet
        Private voucher As NHibernate.Collection.PersistentSet

        Sub New(ByVal idpen As Int32, ByVal tglpen As Date, ByVal namacus As String, ByVal grandt As Decimal, ByVal carab As String, ByVal nokar As String, ByVal namab As String, ByVal dis As Int32, ByVal isdel As Boolean, ByVal idcus As customer, ByVal idu As User, ByVal pakpen As NHibernate.Collection.PersistentSet, ByVal pentre As NHibernate.Collection.PersistentSet, ByVal vou As NHibernate.Collection.PersistentSet)
            idpenjualan = idpen
            tglpenjualan = tglpen
            namacustomer = namacus
            grandtotal = grandt
            carabayar = carab
            nokartu = nokar
            namabank = namab
            diskon = dis
            isdelete = isdel
            idcustomer = idcus
            iduser = idu
            paketpenjualan = pakpen
            penjualantreatment = pentre
            voucher = vou
        End Sub

        Public Overridable Property eidpenjualan As Int32
            Get
                Return idpenjualan
            End Get

            Set(ByVal value As Int32)
                idpenjualan = value
            End Set
        End Property

        Public Overridable Property etglpenjualan As Date
            Get
                Return tglpenjualan
            End Get

            Set(ByVal value As Date)
                tglpenjualan = value
            End Set
        End Property

        Public Overridable Property enamacustomer As String
            Get
                Return namacustomer
            End Get

            Set(ByVal value As String)
                namacustomer = value
            End Set
        End Property

        Public Overridable Property egrandtotal As Decimal
            Get
                Return grandtotal
            End Get

            Set(ByVal value As Decimal)
                grandtotal = value
            End Set
        End Property

        Public Overridable Property ecarabayar As String
            Get
                Return carabayar
            End Get

            Set(ByVal value As String)
                carabayar = value
            End Set
        End Property

        Public Overridable Property enokartu As String
            Get
                Return nokartu
            End Get

            Set(ByVal value As String)
                nokartu = value
            End Set
        End Property

        Public Overridable Property enamabank As String
            Get
                Return namabank
            End Get

            Set(ByVal value As String)
                namabank = value
            End Set
        End Property

        Public Overridable Property ediskon As Int32
            Get
                Return diskon
            End Get

            Set(ByVal value As Int32)
                diskon = value
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

        Public Overridable Property eidcustomer As customer
            Get
                Return idcustomer
            End Get

            Set(ByVal value As customer)
                idcustomer = value
            End Set
        End Property

        Public Overridable Property eiduser As User
            Get
                Return iduser
            End Get

            Set(ByVal value As User)
                iduser = value
            End Set
        End Property

        Public Overridable Property epaketpenjualan() As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketPenjualan)
            Get
                Return paketpenjualan
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketPenjualan))
                paketpenjualan = value
            End Set
        End Property

        Public Overridable Property epenjualantreatment() As NHibernate.Collection.Generic.PersistentGenericSet(Of PenjualanTreatment)
            Get
                Return penjualantreatment
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of PenjualanTreatment))
                penjualantreatment = value
            End Set
        End Property

        Public Overridable Property evoucher() As NHibernate.Collection.Generic.PersistentGenericSet(Of Voucher)
            Get
                Return voucher
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of Voucher))
                voucher = value
            End Set
        End Property
    End Class
End Namespace
