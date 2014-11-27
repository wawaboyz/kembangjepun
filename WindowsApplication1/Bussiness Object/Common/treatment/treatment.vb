Imports NHibernate
Imports NHibernate.Cfg
Imports System.Configuration

Namespace BussinessObject.Common
    Public Class Treatment
        Private idtreatment As Int32
        Private namatreatment As String
        Private harga As Decimal
        Private jam As Decimal
        Private isdelete As Boolean
        Private pakettreatment As NHibernate.Collection.PersistentSet
        Private penjualantreatment As NHibernate.Collection.PersistentSet
        Private voucher As NHibernate.Collection.PersistentSet

        Public Sub New()

        End Sub
        Sub New(ByVal idtrea As Int32, ByVal namatre As String, ByVal har As Decimal, ByVal j As Decimal, ByVal isdel As Boolean, ByVal paktreat As NHibernate.Collection.PersistentSet, ByVal pentre As NHibernate.Collection.PersistentSet, ByVal vou As NHibernate.Collection.PersistentSet)
            idtreatment = idtrea
            namatreatment = namatre
            harga = har
            jam = j
            isdelete = isdel
            pakettreatment = paktreat
            penjualantreatment = pentre
            voucher = vou
        End Sub

        Public Overridable Property eidtreatment() As Int32
            Get
                Return idtreatment
            End Get

            Set(ByVal value As Int32)
                idtreatment = value
            End Set
        End Property

        Public Overridable Property enamatreatment() As String
            Get
                Return namatreatment
            End Get

            Set(ByVal value As String)
                namatreatment = value
            End Set
        End Property

        Public Overridable Property eharga() As Decimal
            Get
                Return harga
            End Get

            Set(ByVal value As Decimal)
                harga = value
            End Set
        End Property

        Public Overridable Property ejam() As Decimal
            Get
                Return jam
            End Get

            Set(ByVal value As Decimal)
                jam = value
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
        Public Overridable Property epakettreatment() As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketTreatment)
            Get
                Return pakettreatment
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketTreatment))
                pakettreatment = value
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
