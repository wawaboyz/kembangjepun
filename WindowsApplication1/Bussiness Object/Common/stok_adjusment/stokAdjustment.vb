
Namespace BussinessObject.Common
    Public Class StokAdjustment
        Private idstokadjustment As Int32
        Private tgladjustment As Date
        Private alasan As String
        Private isdelete As Boolean
        Private iduser As User
        Private stokadjustmentbarang As NHibernate.Collection.PersistentSet

        Sub New(ByVal idstokad As Int32, ByVal tglad As Date, ByVal alas As String, ByVal isdel As Boolean, ByVal idu As User, ByVal stokad As NHibernate.Collection.PersistentSet)
            idstokadjustment = idstokad
            tgladjustment = tglad
            alasan = alas
            isdelete = isdel
            iduser = idu
            stokadjustmentbarang = stokad
        End Sub

        Public Overridable Property eidstokadjustment() As Int32
            Get
                Return idstokadjustment
            End Get
            Set(ByVal value As Int32)
                idstokadjustment = value
            End Set
        End Property

        Public Overridable Property etgladjustment() As Date
            Get
                Return tgladjustment
            End Get
            Set(ByVal value As Date)
                tgladjustment = value
            End Set
        End Property

        Public Overridable Property ealasan() As String
            Get
                Return alasan
            End Get
            Set(ByVal value As String)
                alasan = value
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

        Public Overridable Property estokadjustmentbarang() As NHibernate.Collection.Generic.PersistentGenericSet(Of StokAdjustmentBarang)
            Get
                Return stokadjustmentbarang
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of StokAdjustmentBarang))
                stokadjustmentbarang = value
            End Set
        End Property
    End Class
End Namespace
