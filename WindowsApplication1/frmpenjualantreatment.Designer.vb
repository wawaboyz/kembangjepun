<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpenjualantreatment
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
        Me.grouppenjualantreatment = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblpelanggan = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.lblnamacustomer = New System.Windows.Forms.Label()
        Me.lblidpenjualan = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.cbtherapist = New System.Windows.Forms.ComboBox()
        Me.cbtreatment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lbljum = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.lbltreatment = New System.Windows.Forms.Label()
        Me.grppembayaran = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.grpdttransaksi = New System.Windows.Forms.GroupBox()
        Me.dttransaksi = New System.Windows.Forms.DataGridView()
        Me.rowtreatment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rowtherapist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rowjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rowjumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rowharga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rowsubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTAX = New System.Windows.Forms.Label()
        Me.lbldiskon = New System.Windows.Forms.Label()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.txtgrandtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grouppenjualantreatment.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grppembayaran.SuspendLayout()
        Me.grpdttransaksi.SuspendLayout()
        CType(Me.dttransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grouppenjualantreatment
        '
        Me.grouppenjualantreatment.Controls.Add(Me.TextBox4)
        Me.grouppenjualantreatment.Controls.Add(Me.lblpelanggan)
        Me.grouppenjualantreatment.Controls.Add(Me.TextBox3)
        Me.grouppenjualantreatment.Controls.Add(Me.TextBox2)
        Me.grouppenjualantreatment.Controls.Add(Me.TextBox1)
        Me.grouppenjualantreatment.Controls.Add(Me.lbltanggal)
        Me.grouppenjualantreatment.Controls.Add(Me.lblnamacustomer)
        Me.grouppenjualantreatment.Controls.Add(Me.lblidpenjualan)
        Me.grouppenjualantreatment.Location = New System.Drawing.Point(12, 12)
        Me.grouppenjualantreatment.Name = "grouppenjualantreatment"
        Me.grouppenjualantreatment.Size = New System.Drawing.Size(842, 85)
        Me.grouppenjualantreatment.TabIndex = 0
        Me.grouppenjualantreatment.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(611, 50)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(160, 20)
        Me.TextBox4.TabIndex = 7
        '
        'lblpelanggan
        '
        Me.lblpelanggan.AutoSize = True
        Me.lblpelanggan.Location = New System.Drawing.Point(519, 50)
        Me.lblpelanggan.Name = "lblpelanggan"
        Me.lblpelanggan.Size = New System.Drawing.Size(73, 13)
        Me.lblpelanggan.TabIndex = 6
        Me.lblpelanggan.Text = "PELANGGAN"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(611, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(123, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Location = New System.Drawing.Point(534, 29)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(58, 13)
        Me.lbltanggal.TabIndex = 2
        Me.lbltanggal.Text = "TANGGAL"
        '
        'lblnamacustomer
        '
        Me.lblnamacustomer.AutoSize = True
        Me.lblnamacustomer.Location = New System.Drawing.Point(32, 55)
        Me.lblnamacustomer.Name = "lblnamacustomer"
        Me.lblnamacustomer.Size = New System.Drawing.Size(76, 13)
        Me.lblnamacustomer.TabIndex = 1
        Me.lblnamacustomer.Text = "PELANGGAN "
        '
        'lblidpenjualan
        '
        Me.lblidpenjualan.AutoSize = True
        Me.lblidpenjualan.Location = New System.Drawing.Point(24, 29)
        Me.lblidpenjualan.Name = "lblidpenjualan"
        Me.lblidpenjualan.Size = New System.Drawing.Size(84, 13)
        Me.lblidpenjualan.TabIndex = 0
        Me.lblidpenjualan.Text = "ID PENJUALAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btntambah)
        Me.GroupBox1.Controls.Add(Me.cbtherapist)
        Me.GroupBox1.Controls.Add(Me.cbtreatment)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.lblharga)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.lbljum)
        Me.GroupBox1.Controls.Add(Me.lbljam)
        Me.GroupBox1.Controls.Add(Me.lbltreatment)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 190)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TREATMENT"
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(130, 147)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(133, 23)
        Me.btntambah.TabIndex = 12
        Me.btntambah.Text = "TAMBAH TRANSAKSI"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'cbtherapist
        '
        Me.cbtherapist.FormattingEnabled = True
        Me.cbtherapist.Location = New System.Drawing.Point(123, 120)
        Me.cbtherapist.Name = "cbtherapist"
        Me.cbtherapist.Size = New System.Drawing.Size(196, 21)
        Me.cbtherapist.TabIndex = 11
        '
        'cbtreatment
        '
        Me.cbtreatment.FormattingEnabled = True
        Me.cbtreatment.Location = New System.Drawing.Point(123, 24)
        Me.cbtreatment.Name = "cbtreatment"
        Me.cbtreatment.Size = New System.Drawing.Size(160, 21)
        Me.cbtreatment.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "THERAPIST"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(145, 97)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(118, 20)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "0"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Location = New System.Drawing.Point(53, 101)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(45, 13)
        Me.lblharga.TabIndex = 6
        Me.lblharga.Text = "HARGA"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(123, 74)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(35, 20)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(123, 48)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(35, 20)
        Me.TextBox7.TabIndex = 4
        '
        'lbljum
        '
        Me.lbljum.AutoSize = True
        Me.lbljum.Location = New System.Drawing.Point(49, 77)
        Me.lbljum.Name = "lbljum"
        Me.lbljum.Size = New System.Drawing.Size(50, 13)
        Me.lbljum.TabIndex = 2
        Me.lbljum.Text = "JUMLAH"
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Location = New System.Drawing.Point(70, 55)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(28, 13)
        Me.lbljam.TabIndex = 1
        Me.lbljam.Text = "JAM"
        '
        'lbltreatment
        '
        Me.lbltreatment.AutoSize = True
        Me.lbltreatment.Location = New System.Drawing.Point(25, 29)
        Me.lbltreatment.Name = "lbltreatment"
        Me.lbltreatment.Size = New System.Drawing.Size(74, 13)
        Me.lbltreatment.TabIndex = 0
        Me.lbltreatment.Text = "TREATMENT"
        '
        'grppembayaran
        '
        Me.grppembayaran.Controls.Add(Me.RadioButton5)
        Me.grppembayaran.Controls.Add(Me.RadioButton4)
        Me.grppembayaran.Controls.Add(Me.RadioButton3)
        Me.grppembayaran.Controls.Add(Me.RadioButton2)
        Me.grppembayaran.Controls.Add(Me.RadioButton1)
        Me.grppembayaran.Location = New System.Drawing.Point(437, 103)
        Me.grppembayaran.Name = "grppembayaran"
        Me.grppembayaran.Size = New System.Drawing.Size(417, 164)
        Me.grppembayaran.TabIndex = 9
        Me.grppembayaran.TabStop = False
        Me.grppembayaran.Text = "PEMBAYARAN"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(20, 119)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "VOUCHER"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(20, 96)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "COMPLIMENT"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(20, 73)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "KREDIT"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(20, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "DEBET"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(20, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "TUNAI"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'grpdttransaksi
        '
        Me.grpdttransaksi.Controls.Add(Me.dttransaksi)
        Me.grpdttransaksi.Location = New System.Drawing.Point(12, 299)
        Me.grpdttransaksi.Name = "grpdttransaksi"
        Me.grpdttransaksi.Size = New System.Drawing.Size(832, 247)
        Me.grpdttransaksi.TabIndex = 10
        Me.grpdttransaksi.TabStop = False
        Me.grpdttransaksi.Text = "LIST TRANSAKSI"
        '
        'dttransaksi
        '
        Me.dttransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dttransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rowtreatment, Me.rowtherapist, Me.rowjam, Me.rowjumlah, Me.rowharga, Me.rowsubtotal})
        Me.dttransaksi.Location = New System.Drawing.Point(15, 19)
        Me.dttransaksi.Name = "dttransaksi"
        Me.dttransaksi.Size = New System.Drawing.Size(801, 211)
        Me.dttransaksi.TabIndex = 0
        '
        'rowtreatment
        '
        Me.rowtreatment.HeaderText = "TREATMENT"
        Me.rowtreatment.Name = "rowtreatment"
        Me.rowtreatment.ReadOnly = True
        Me.rowtreatment.Width = 150
        '
        'rowtherapist
        '
        Me.rowtherapist.HeaderText = "THERAPIST"
        Me.rowtherapist.Name = "rowtherapist"
        Me.rowtherapist.ReadOnly = True
        Me.rowtherapist.Width = 150
        '
        'rowjam
        '
        Me.rowjam.HeaderText = "JAM"
        Me.rowjam.Name = "rowjam"
        Me.rowjam.ReadOnly = True
        Me.rowjam.Width = 40
        '
        'rowjumlah
        '
        Me.rowjumlah.HeaderText = "JUMLAH"
        Me.rowjumlah.Name = "rowjumlah"
        Me.rowjumlah.ReadOnly = True
        Me.rowjumlah.Width = 80
        '
        'rowharga
        '
        Me.rowharga.HeaderText = "HARGA"
        Me.rowharga.Name = "rowharga"
        Me.rowharga.ReadOnly = True
        Me.rowharga.Width = 130
        '
        'rowsubtotal
        '
        Me.rowsubtotal.HeaderText = "SUBTOTAL"
        Me.rowsubtotal.Name = "rowsubtotal"
        Me.rowsubtotal.ReadOnly = True
        Me.rowsubtotal.Width = 150
        '
        'lblTAX
        '
        Me.lblTAX.AutoSize = True
        Me.lblTAX.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTAX.Location = New System.Drawing.Point(515, 602)
        Me.lblTAX.Name = "lblTAX"
        Me.lblTAX.Size = New System.Drawing.Size(61, 29)
        Me.lblTAX.TabIndex = 11
        Me.lblTAX.Text = "TAX"
        '
        'lbldiskon
        '
        Me.lbldiskon.AutoSize = True
        Me.lbldiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiskon.Location = New System.Drawing.Point(442, 563)
        Me.lbldiskon.Name = "lbldiskon"
        Me.lbldiskon.Size = New System.Drawing.Size(139, 29)
        Me.lbldiskon.TabIndex = 12
        Me.lbldiskon.Text = "DISCOUNT"
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrandtotal.Location = New System.Drawing.Point(404, 638)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(177, 29)
        Me.lblgrandtotal.TabIndex = 13
        Me.lblgrandtotal.Text = "GRANDTOTAL"
        '
        'txtdiskon
        '
        Me.txtdiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiskon.Location = New System.Drawing.Point(648, 560)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(180, 35)
        Me.txtdiskon.TabIndex = 14
        Me.txtdiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttax
        '
        Me.txttax.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttax.Location = New System.Drawing.Point(648, 599)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(180, 35)
        Me.txttax.TabIndex = 15
        Me.txttax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrandtotal.Location = New System.Drawing.Point(648, 638)
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(180, 31)
        Me.txtgrandtotal.TabIndex = 16
        Me.txtgrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(605, 563)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Rp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(605, 605)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 29)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Rp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(605, 638)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 29)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Rp"
        '
        'frmpenjualantreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 689)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtgrandtotal)
        Me.Controls.Add(Me.txttax)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.lblgrandtotal)
        Me.Controls.Add(Me.lbldiskon)
        Me.Controls.Add(Me.lblTAX)
        Me.Controls.Add(Me.grpdttransaksi)
        Me.Controls.Add(Me.grppembayaran)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grouppenjualantreatment)
        Me.Name = "frmpenjualantreatment"
        Me.Text = "frmpenjualantreatment"
        Me.grouppenjualantreatment.ResumeLayout(False)
        Me.grouppenjualantreatment.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grppembayaran.ResumeLayout(False)
        Me.grppembayaran.PerformLayout()
        Me.grpdttransaksi.ResumeLayout(False)
        CType(Me.dttransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grouppenjualantreatment As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbltanggal As System.Windows.Forms.Label
    Friend WithEvents lblnamacustomer As System.Windows.Forms.Label
    Friend WithEvents lblidpenjualan As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblpelanggan As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents lblharga As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents lbljum As System.Windows.Forms.Label
    Friend WithEvents lbljam As System.Windows.Forms.Label
    Friend WithEvents lbltreatment As System.Windows.Forms.Label
    Friend WithEvents cbtherapist As System.Windows.Forms.ComboBox
    Friend WithEvents cbtreatment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents grppembayaran As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents grpdttransaksi As System.Windows.Forms.GroupBox
    Friend WithEvents dttransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents rowtreatment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rowtherapist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rowjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rowjumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rowharga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rowsubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTAX As System.Windows.Forms.Label
    Friend WithEvents lbldiskon As System.Windows.Forms.Label
    Friend WithEvents lblgrandtotal As System.Windows.Forms.Label
    Friend WithEvents txtdiskon As System.Windows.Forms.TextBox
    Friend WithEvents txttax As System.Windows.Forms.TextBox
    Friend WithEvents txtgrandtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
