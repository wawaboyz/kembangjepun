
Namespace BussinessObject.Common
    Public Class Jabatan
        Private idjabatan As Int32
        Private namajabatan As String
        Private komisijabatan As Int32
        Private menu As String
        Private isdelete As Boolean
        Private user As NHibernate.Collection.PersistentSet

        Public Overridable Property eidjabatan() As Int32
            Get
                Return idjabatan
            End Get

            Set(ByVal value As Int32)
                idjabatan = value
            End Set
        End Property

        Public Overridable Property enamajabatan() As String
            Get
                Return namajabatan
            End Get

            Set(ByVal value As String)
                namajabatan = value
            End Set
        End Property

        Public Overridable Property ekomisijabatan() As Int32
            Get
                Return komisijabatan
            End Get

            Set(ByVal value As Int32)
                komisijabatan = value
            End Set
        End Property
        Public Overridable Property emenu() As String
            Get
                Return menu
            End Get

            Set(ByVal value As String)
                menu = value
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

        Public Overridable Property euser() As NHibernate.Collection.Generic.PersistentGenericSet(Of User)
            Get
                Return user
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of User))
                user = value
            End Set
        End Property
    End Class
End Namespace

