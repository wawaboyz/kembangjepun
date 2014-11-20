
Namespace BussinessObject.Common
    Public Class PenjualanTreatment
        Private idpenjualantreatment As PenjualanTreatmentId
        Private jumlah As Int32
        Private harga As Decimal
        Private subtotal As Decimal
        Private penjualanSet As Penjualan
        Private treatmentSet As Treatment
        Private iduser As Int32

        Sub New(ByVal idpentre As PenjualanTreatmentId, ByVal jum As Int32, ByVal har As Decimal, ByVal subt As Decimal, ByVal penjualanS As Penjualan, ByVal treatmentS As Treatment, ByVal idu As Int32)
            idpenjualantreatment = idpentre
            jumlah = jum
            harga = har
            subtotal = subt
            penjualanSet = penjualanS
            treatmentSet = treatmentS
            iduser = idu
        End Sub

        Public Overridable Property eidpenjualantreatment() As PenjualanTreatmentId
            Get
                Return idpenjualantreatment
            End Get

            Set(ByVal value As PenjualanTreatmentId)
                idpenjualantreatment = value
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

        Public Overridable Property epenjualanset() As Penjualan
            Get
                Return penjualanSet
            End Get

            Set(ByVal value As Penjualan)
                penjualanSet = value
            End Set
        End Property

        Public Overridable Property etreatmentset() As Treatment
            Get
                Return treatmentSet
            End Get

            Set(value As Treatment)
                treatmentSet = value
            End Set
        End Property

        Public Overridable Property eiduser() As Int32
            Get
                Return iduser
            End Get

            Set(value As Int32)
                iduser = value
            End Set
        End Property
    End Class
End Namespace
