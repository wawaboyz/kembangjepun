<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpdatapembelian = New System.Windows.Forms.GroupBox()
        Me.txtsupplier = New System.Windows.Forms.TextBox()
        Me.datebeli = New System.Windows.Forms.DateTimePicker()
        Me.txtidbeli = New System.Windows.Forms.TextBox()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.lblsupplier = New System.Windows.Forms.Label()
        Me.lblidfaktur = New System.Windows.Forms.Label()
        Me.grouplistbarang = New System.Windows.Forms.GroupBox()
        Me.dglistbarang = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.lblcari = New System.Windows.Forms.Label()
        Me.groupbarang = New System.Windows.Forms.GroupBox()
        Me.btntambahbarang = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthargabeli = New System.Windows.Forms.TextBox()
        Me.txtjum = New System.Windows.Forms.TextBox()
        Me.txtstokbarang = New System.Windows.Forms.TextBox()
        Me.txtnmbarang = New System.Windows.Forms.TextBox()
        Me.txtidbarang = New System.Windows.Forms.TextBox()
        Me.lblhargabeli = New System.Windows.Forms.Label()
        Me.lbljumlahbeli = New System.Windows.Forms.Label()
        Me.lblstokbarang = New System.Windows.Forms.Label()
        Me.lblnmbarang = New System.Windows.Forms.Label()
        Me.lblidbarang = New System.Windows.Forms.Label()
        Me.grpdatatransaksi = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.dgtransaksi = New System.Windows.Forms.DataGridView()
        Me.chktax = New System.Windows.Forms.CheckBox()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpdatapembelian.SuspendLayout()
        Me.grouplistbarang.SuspendLayout()
        CType(Me.dglistbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbarang.SuspendLayout()
        Me.grpdatatransaksi.SuspendLayout()
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpdatapembelian
        '
        Me.grpdatapembelian.Controls.Add(Me.txtsupplier)
        Me.grpdatapembelian.Controls.Add(Me.datebeli)
        Me.grpdatapembelian.Controls.Add(Me.txtidbeli)
        Me.grpdatapembelian.Controls.Add(Me.lbltanggal)
        Me.grpdatapembelian.Controls.Add(Me.lblsupplier)
        Me.grpdatapembelian.Controls.Add(Me.lblidfaktur)
        Me.grpdatapembelian.Location = New System.Drawing.Point(12, 13)
        Me.grpdatapembelian.Name = "grpdatapembelian"
        Me.grpdatapembelian.Size = New System.Drawing.Size(467, 139)
        Me.grpdatapembelian.TabIndex = 0
        Me.grpdatapembelian.TabStop = False
        Me.grpdatapembelian.Text = "DATA PEMBELIAN"
        '
        'txtsupplier
        '
        Me.txtsupplier.Location = New System.Drawing.Point(119, 96)
        Me.txtsupplier.Name = "txtsupplier"
        Me.txtsupplier.Size = New System.Drawing.Size(326, 20)
        Me.txtsupplier.TabIndex = 6
        '
        'datebeli
        '
        Me.datebeli.Location = New System.Drawing.Point(119, 62)
        Me.datebeli.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.datebeli.Name = "datebeli"
        Me.datebeli.Size = New System.Drawing.Size(200, 20)
        Me.datebeli.TabIndex = 5
        '
        'txtidbeli
        '
        Me.txtidbeli.Location = New System.Drawing.Point(119, 33)
        Me.txtidbeli.Name = "txtidbeli"
        Me.txtidbeli.Size = New System.Drawing.Size(84, 20)
        Me.txtidbeli.TabIndex = 4
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Location = New System.Drawing.Point(14, 67)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(84, 13)
        Me.lbltanggal.TabIndex = 2
        Me.lbltanggal.Text = "TANGGAL BELI"
        '
        'lblsupplier
        '
        Me.lblsupplier.AutoSize = True
        Me.lblsupplier.Location = New System.Drawing.Point(34, 96)
        Me.lblsupplier.Name = "lblsupplier"
        Me.lblsupplier.Size = New System.Drawing.Size(60, 13)
        Me.lblsupplier.TabIndex = 1
        Me.lblsupplier.Text = "SUPPLIER"
        '
        'lblidfaktur
        '
        Me.lblidfaktur.AutoSize = True
        Me.lblidfaktur.Location = New System.Drawing.Point(34, 36)
        Me.lblidfaktur.Name = "lblidfaktur"
        Me.lblidfaktur.Size = New System.Drawing.Size(64, 13)
        Me.lblidfaktur.TabIndex = 0
        Me.lblidfaktur.Text = "ID FAKTUR"
        '
        'grouplistbarang
        '
        Me.grouplistbarang.Controls.Add(Me.dglistbarang)
        Me.grouplistbarang.Controls.Add(Me.txtcari)
        Me.grouplistbarang.Controls.Add(Me.lblcari)
        Me.grouplistbarang.Location = New System.Drawing.Point(495, 13)
        Me.grouplistbarang.Name = "grouplistbarang"
        Me.grouplistbarang.Size = New System.Drawing.Size(341, 340)
        Me.grouplistbarang.TabIndex = 1
        Me.grouplistbarang.TabStop = False
        Me.grouplistbarang.Text = "LIST BARANG"
        '
        'dglistbarang
        '
        Me.dglistbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistbarang.Location = New System.Drawing.Point(18, 50)
        Me.dglistbarang.Name = "dglistbarang"
        Me.dglistbarang.ReadOnly = True
        Me.dglistbarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dglistbarang.Size = New System.Drawing.Size(312, 269)
        Me.dglistbarang.TabIndex = 2
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(101, 21)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(149, 20)
        Me.txtcari.TabIndex = 1
        '
        'lblcari
        '
        Me.lblcari.AutoSize = True
        Me.lblcari.Location = New System.Drawing.Point(15, 24)
        Me.lblcari.Name = "lblcari"
        Me.lblcari.Size = New System.Drawing.Size(80, 13)
        Me.lblcari.TabIndex = 0
        Me.lblcari.Text = "CARI BARANG"
        '
        'groupbarang
        '
        Me.groupbarang.Controls.Add(Me.btntambahbarang)
        Me.groupbarang.Controls.Add(Me.Label2)
        Me.groupbarang.Controls.Add(Me.Label1)
        Me.groupbarang.Controls.Add(Me.txthargabeli)
        Me.groupbarang.Controls.Add(Me.txtjum)
        Me.groupbarang.Controls.Add(Me.txtstokbarang)
        Me.groupbarang.Controls.Add(Me.txtnmbarang)
        Me.groupbarang.Controls.Add(Me.txtidbarang)
        Me.groupbarang.Controls.Add(Me.lblhargabeli)
        Me.groupbarang.Controls.Add(Me.lbljumlahbeli)
        Me.groupbarang.Controls.Add(Me.lblstokbarang)
        Me.groupbarang.Controls.Add(Me.lblnmbarang)
        Me.groupbarang.Controls.Add(Me.lblidbarang)
        Me.groupbarang.Location = New System.Drawing.Point(20, 158)
        Me.groupbarang.Name = "groupbarang"
        Me.groupbarang.Size = New System.Drawing.Size(459, 194)
        Me.groupbarang.TabIndex = 2
        Me.groupbarang.TabStop = False
        Me.groupbarang.Text = "BARANG"
        '
        'btntambahbarang
        '
        Me.btntambahbarang.Location = New System.Drawing.Point(152, 152)
        Me.btntambahbarang.Name = "btntambahbarang"
        Me.btntambahbarang.Size = New System.Drawing.Size(141, 23)
        Me.btntambahbarang.TabIndex = 13
        Me.btntambahbarang.Text = "TAMBAH BARANG"
        Me.btntambahbarang.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "/ SATUAN BARANG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Rp"
        '
        'txthargabeli
        '
        Me.txthargabeli.Location = New System.Drawing.Point(131, 123)
        Me.txthargabeli.Name = "txthargabeli"
        Me.txthargabeli.Size = New System.Drawing.Size(108, 20)
        Me.txthargabeli.TabIndex = 10
        Me.txthargabeli.Text = "0"
        Me.txthargabeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtjum
        '
        Me.txtjum.Location = New System.Drawing.Point(111, 99)
        Me.txtjum.Name = "txtjum"
        Me.txtjum.Size = New System.Drawing.Size(59, 20)
        Me.txtjum.TabIndex = 9
        Me.txtjum.Text = "0"
        Me.txtjum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtstokbarang
        '
        Me.txtstokbarang.Location = New System.Drawing.Point(110, 74)
        Me.txtstokbarang.Name = "txtstokbarang"
        Me.txtstokbarang.ReadOnly = True
        Me.txtstokbarang.Size = New System.Drawing.Size(60, 20)
        Me.txtstokbarang.TabIndex = 8
        Me.txtstokbarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnmbarang
        '
        Me.txtnmbarang.Location = New System.Drawing.Point(110, 48)
        Me.txtnmbarang.Name = "txtnmbarang"
        Me.txtnmbarang.ReadOnly = True
        Me.txtnmbarang.Size = New System.Drawing.Size(181, 20)
        Me.txtnmbarang.TabIndex = 7
        '
        'txtidbarang
        '
        Me.txtidbarang.Location = New System.Drawing.Point(111, 23)
        Me.txtidbarang.Name = "txtidbarang"
        Me.txtidbarang.ReadOnly = True
        Me.txtidbarang.Size = New System.Drawing.Size(100, 20)
        Me.txtidbarang.TabIndex = 6
        '
        'lblhargabeli
        '
        Me.lblhargabeli.AutoSize = True
        Me.lblhargabeli.Location = New System.Drawing.Point(30, 126)
        Me.lblhargabeli.Name = "lblhargabeli"
        Me.lblhargabeli.Size = New System.Drawing.Size(74, 13)
        Me.lblhargabeli.TabIndex = 5
        Me.lblhargabeli.Text = "HARGA BELI "
        '
        'lbljumlahbeli
        '
        Me.lbljumlahbeli.AutoSize = True
        Me.lbljumlahbeli.Location = New System.Drawing.Point(26, 102)
        Me.lbljumlahbeli.Name = "lbljumlahbeli"
        Me.lbljumlahbeli.Size = New System.Drawing.Size(76, 13)
        Me.lbljumlahbeli.TabIndex = 4
        Me.lbljumlahbeli.Text = "JUMLAH BELI"
        '
        'lblstokbarang
        '
        Me.lblstokbarang.AutoSize = True
        Me.lblstokbarang.Location = New System.Drawing.Point(20, 77)
        Me.lblstokbarang.Name = "lblstokbarang"
        Me.lblstokbarang.Size = New System.Drawing.Size(84, 13)
        Me.lblstokbarang.TabIndex = 3
        Me.lblstokbarang.Text = "STOK BARANG"
        '
        'lblnmbarang
        '
        Me.lblnmbarang.AutoSize = True
        Me.lblnmbarang.Location = New System.Drawing.Point(18, 51)
        Me.lblnmbarang.Name = "lblnmbarang"
        Me.lblnmbarang.Size = New System.Drawing.Size(86, 13)
        Me.lblnmbarang.TabIndex = 1
        Me.lblnmbarang.Text = "NAMA BARANG"
        '
        'lblidbarang
        '
        Me.lblidbarang.AutoSize = True
        Me.lblidbarang.Location = New System.Drawing.Point(38, 26)
        Me.lblidbarang.Name = "lblidbarang"
        Me.lblidbarang.Size = New System.Drawing.Size(66, 13)
        Me.lblidbarang.TabIndex = 0
        Me.lblidbarang.Text = "ID BARANG"
        '
        'grpdatatransaksi
        '
        Me.grpdatatransaksi.Controls.Add(Me.btndelete)
        Me.grpdatatransaksi.Controls.Add(Me.dgtransaksi)
        Me.grpdatatransaksi.Location = New System.Drawing.Point(20, 370)
        Me.grpdatatransaksi.Name = "grpdatatransaksi"
        Me.grpdatatransaksi.Size = New System.Drawing.Size(816, 196)
        Me.grpdatatransaksi.TabIndex = 3
        Me.grpdatatransaksi.TabStop = False
        Me.grpdatatransaksi.Text = "DATA TRANSAKSI"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(705, 165)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 11
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'dgtransaksi
        '
        Me.dgtransaksi.AllowUserToAddRows = False
        Me.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtransaksi.Location = New System.Drawing.Point(9, 19)
        Me.dgtransaksi.Name = "dgtransaksi"
        Me.dgtransaksi.ReadOnly = True
        Me.dgtransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtransaksi.Size = New System.Drawing.Size(785, 140)
        Me.dgtransaksi.TabIndex = 0
        '
        'chktax
        '
        Me.chktax.AutoSize = True
        Me.chktax.Location = New System.Drawing.Point(29, 572)
        Me.chktax.Name = "chktax"
        Me.chktax.Size = New System.Drawing.Size(47, 17)
        Me.chktax.TabIndex = 2
        Me.chktax.Text = "TAX"
        Me.chktax.UseVisualStyleBackColor = True
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltax.Location = New System.Drawing.Point(549, 584)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(53, 25)
        Me.lbltax.TabIndex = 4
        Me.lbltax.Text = "TAX"
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrandtotal.Location = New System.Drawing.Point(441, 619)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(161, 25)
        Me.lblgrandtotal.TabIndex = 5
        Me.lblgrandtotal.Text = "GRAND TOTAL"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(651, 581)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(185, 31)
        Me.TextBox6.TabIndex = 6
        Me.TextBox6.Text = "0"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(651, 618)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(186, 31)
        Me.TextBox7.TabIndex = 7
        Me.TextBox7.Text = "0"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(608, 584)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(606, 619)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Rp"
        '
        'frmpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(953, 664)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.lblgrandtotal)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.chktax)
        Me.Controls.Add(Me.grpdatatransaksi)
        Me.Controls.Add(Me.groupbarang)
        Me.Controls.Add(Me.grouplistbarang)
        Me.Controls.Add(Me.grpdatapembelian)
        Me.Name = "frmpembelian"
        Me.Text = "frmpembelian"
        Me.grpdatapembelian.ResumeLayout(False)
        Me.grpdatapembelian.PerformLayout()
        Me.grouplistbarang.ResumeLayout(False)
        Me.grouplistbarang.PerformLayout()
        CType(Me.dglistbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbarang.ResumeLayout(False)
        Me.groupbarang.PerformLayout()
        Me.grpdatatransaksi.ResumeLayout(False)
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpdatapembelian As System.Windows.Forms.GroupBox
    Friend WithEvents lbltanggal As System.Windows.Forms.Label
    Friend WithEvents lblsupplier As System.Windows.Forms.Label
    Friend WithEvents lblidfaktur As System.Windows.Forms.Label
    Friend WithEvents datebeli As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtidbeli As System.Windows.Forms.TextBox
    Friend WithEvents txtsupplier As System.Windows.Forms.TextBox
    Friend WithEvents grouplistbarang As System.Windows.Forms.GroupBox
    Friend WithEvents dglistbarang As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents lblcari As System.Windows.Forms.Label
    Friend WithEvents groupbarang As System.Windows.Forms.GroupBox
    Friend WithEvents lblhargabeli As System.Windows.Forms.Label
    Friend WithEvents lbljumlahbeli As System.Windows.Forms.Label
    Friend WithEvents lblstokbarang As System.Windows.Forms.Label
    Friend WithEvents lblnmbarang As System.Windows.Forms.Label
    Friend WithEvents lblidbarang As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txthargabeli As System.Windows.Forms.TextBox
    Friend WithEvents txtjum As System.Windows.Forms.TextBox
    Friend WithEvents txtstokbarang As System.Windows.Forms.TextBox
    Friend WithEvents txtnmbarang As System.Windows.Forms.TextBox
    Friend WithEvents txtidbarang As System.Windows.Forms.TextBox
    Friend WithEvents grpdatatransaksi As System.Windows.Forms.GroupBox
    Friend WithEvents chktax As System.Windows.Forms.CheckBox
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents lblgrandtotal As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btntambahbarang As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents dgtransaksi As System.Windows.Forms.DataGridView
End Class
