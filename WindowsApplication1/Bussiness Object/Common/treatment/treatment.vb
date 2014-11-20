Imports NHibernate
Imports NHibernate.Cfg
Imports System.Configuration

Namespace BussinessObject.Common
    Public Class Treatment
        Private idtreatment As Int32
        Private namatreatment As String
        Private harga As Int32
        Private jam As Decimal
        Private isdelete As Boolean

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

        Public Overridable Property eharga() As Int32
            Get
                Return harga
            End Get

            Set(ByVal value As Int32)
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



    End Class
End Namespace
