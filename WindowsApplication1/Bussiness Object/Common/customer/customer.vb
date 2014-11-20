Imports NHibernate
Imports NHibernate.Cfg
Imports System.Configuration

Namespace BussinessObject.Common
    Public Class Customer
        Private idcustomer As Int32
        Private nama As String
        Private alamat As String
        Private telp As String
        Private nomorkartu As String
        Private jeniskelamin As Char
        Private tgllahir As Date
        Private aktif As Boolean
        Private isdelete As Boolean



        Public Overridable Property eidcustomer() As Int32
            Get
                Return idcustomer
            End Get

            Set(ByVal value As Int32)
                idcustomer = value
            End Set
        End Property

        Public Overridable Property enama() As String
            Get
                Return nama
            End Get

            Set(ByVal value As String)
                nama = value
            End Set
        End Property

        Public Overridable Property ealamat() As String
            Get
                Return alamat
            End Get

            Set(ByVal value As String)
                alamat = value
            End Set
        End Property

        Public Overridable Property etelp() As String
            Get
                Return telp
            End Get

            Set(ByVal value As String)
                telp = value
            End Set
        End Property

        Public Overridable Property enomorkartu() As String
            Get
                Return nomorkartu
            End Get

            Set(ByVal value As String)
                nomorkartu = value
            End Set
        End Property

        Public Overridable Property ejeniskelamin() As Char
            Get
                Return jeniskelamin
            End Get

            Set(ByVal value As Char)
                jeniskelamin = value
            End Set
        End Property
        Public Overridable Property etgllahir() As Date
            Get
                Return tgllahir
            End Get

            Set(ByVal value As Date)
                tgllahir = value
            End Set
        End Property
        Public Overridable Property eaktif() As Boolean
            Get
                Return aktif
            End Get

            Set(ByVal value As Boolean)
                aktif = value
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
