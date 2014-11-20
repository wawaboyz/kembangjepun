Imports NHibernate
Imports NHibernate.Cfg
Imports System.Configuration

Namespace BussinessObject.Common
    Public Class Barang
        Private idbarang As Int32
        Private namabarang As String
        Private stokbarang As Int32
        Private inventaris As Int32
        Private hargaperkiraan As Decimal
        Private hargajual As Decimal
        Private isdelete As Boolean


        Public Overridable Property eidbarang() As Int32
            Get
                Return idbarang
            End Get

            Set(ByVal value As Int32)
                idbarang = value
            End Set
        End Property

        Public Overridable Property enamabarang() As String
            Get
                Return namabarang
            End Get

            Set(ByVal value As String)
                namabarang = value
            End Set
        End Property

        Public Overridable Property estokbarang() As Int32
            Get
                Return stokbarang
            End Get

            Set(ByVal value As Int32)
                stokbarang = value
            End Set
        End Property

        Public Overridable Property einventaris() As Int32
            Get
                Return inventaris
            End Get

            Set(ByVal value As Int32)
                inventaris = value
            End Set
        End Property

        Public Overridable Property ehargaperkiraan() As Decimal
            Get
                Return hargaperkiraan
            End Get

            Set(ByVal value As Decimal)
                hargaperkiraan = value
            End Set
        End Property

        Public Overridable Property ehargajual() As Decimal
            Get
                Return hargajual
            End Get

            Set(ByVal value As Decimal)
                hargajual = value
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
