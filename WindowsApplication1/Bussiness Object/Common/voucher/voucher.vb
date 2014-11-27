Namespace BussinessObject.Common
    Public Class Voucher
        Private idvoucher As Int32
        Private nomorvoucher As String
        Private tglinput As Date
        Private tglkadaluarsa As Date
        Private namacustomer As String
        Private isdelete As Boolean
        Private treatment As Treatment
        Private penjualan As Penjualan

        Public Sub New()

        End Sub

        Sub New(ByVal idvo As Int32, ByVal nomorvo As String, ByVal tgli As Date, ByVal tglk As Date, ByVal namacus As String, ByVal isdel As Boolean, ByVal treat As Treatment, ByVal pen As Penjualan)
            idvoucher = idvo
            nomorvoucher = nomorvo
            tglinput = tgli
            tglkadaluarsa = tglk
            namacustomer = namacus
            isdelete = isdel
            treat = treatment
            penjualan = pen
        End Sub

        Public Overridable Property eidvoucher() As Int32
            Get
                Return idvoucher
            End Get
            Set(ByVal value As Int32)
                idvoucher = value
            End Set
        End Property

        Public Overridable Property enomorvoucher() As String
            Get
                Return nomorvoucher
            End Get
            Set(ByVal value As String)
                nomorvoucher = value
            End Set
        End Property

        Public Overridable Property etglinput() As Date
            Get
                Return tglinput
            End Get
            Set(ByVal value As Date)
                tglinput = value
            End Set
        End Property

        Public Overridable Property etglkadaluarsa() As Date
            Get
                Return tglkadaluarsa
            End Get
            Set(ByVal value As Date)
                tglkadaluarsa = value
            End Set
        End Property

        Public Overridable Property enamacustomer() As String
            Get
                Return namacustomer
            End Get
            Set(ByVal value As String)
                namacustomer = value
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

        Public Overridable Property eidtreatment() As Treatment
            Get
                Return treatment
            End Get
            Set(value As Treatment)
                treatment = value
            End Set
        End Property

        Public Overridable Property eidpenjualan() As Penjualan
            Get
                Return penjualan
            End Get
            Set(value As Penjualan)
                penjualan = value
            End Set
        End Property
    End Class
End Namespace
