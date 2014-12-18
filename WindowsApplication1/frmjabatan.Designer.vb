<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmjabatan
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
        Me.txtcarijabatan = New System.Windows.Forms.TextBox()
        Me.txtkomisi = New System.Windows.Forms.TextBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.lblkomisi = New System.Windows.Forms.Label()
        Me.lbljabatan = New System.Windows.Forms.Label()
        Me.grouplistjabatan = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.dglistjabatan = New System.Windows.Forms.DataGridView()
        Me.groupjabatan = New System.Windows.Forms.GroupBox()
        Me.groupmenu = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.chklaporan = New System.Windows.Forms.CheckBox()
        Me.chkpembelian = New System.Windows.Forms.CheckBox()
        Me.chkpenjualan = New System.Windows.Forms.CheckBox()
        Me.chkmaster = New System.Windows.Forms.CheckBox()
        Me.lblmenu = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.grouplistjabatan.SuspendLayout()
        CType(Me.dglistjabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupjabatan.SuspendLayout()
        Me.groupmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcarijabatan
        '
        Me.txtcarijabatan.Location = New System.Drawing.Point(67, 19)
        Me.txtcarijabatan.Name = "txtcarijabatan"
        Me.txtcarijabatan.Size = New System.Drawing.Size(168, 20)
        Me.txtcarijabatan.TabIndex = 2
        '
        'txtkomisi
        '
        Me.txtkomisi.Location = New System.Drawing.Point(102, 53)
        Me.txtkomisi.Name = "txtkomisi"
        Me.txtkomisi.Size = New System.Drawing.Size(150, 20)
        Me.txtkomisi.TabIndex = 3
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(102, 27)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(212, 20)
        Me.txtjabatan.TabIndex = 2
        '
        'lblkomisi
        '
        Me.lblkomisi.AutoSize = True
        Me.lblkomisi.Location = New System.Drawing.Point(36, 56)
        Me.lblkomisi.Name = "lblkomisi"
        Me.lblkomisi.Size = New System.Drawing.Size(44, 13)
        Me.lblkomisi.TabIndex = 1
        Me.lblkomisi.Text = "KOMISI"
        '
        'lbljabatan
        '
        Me.lbljabatan.AutoSize = True
        Me.lbljabatan.Location = New System.Drawing.Point(25, 30)
        Me.lbljabatan.Name = "lbljabatan"
        Me.lbljabatan.Size = New System.Drawing.Size(55, 13)
        Me.lbljabatan.TabIndex = 0
        Me.lbljabatan.Text = "JABATAN"
        '
        'grouplistjabatan
        '
        Me.grouplistjabatan.Controls.Add(Me.btndelete)
        Me.grouplistjabatan.Controls.Add(Me.btnedit)
        Me.grouplistjabatan.Controls.Add(Me.btnnew)
        Me.grouplistjabatan.Controls.Add(Me.txtcarijabatan)
        Me.grouplistjabatan.Controls.Add(Me.lblsearch)
        Me.grouplistjabatan.Controls.Add(Me.dglistjabatan)
        Me.grouplistjabatan.Location = New System.Drawing.Point(12, 12)
        Me.grouplistjabatan.Name = "grouplistjabatan"
        Me.grouplistjabatan.Size = New System.Drawing.Size(653, 243)
        Me.grouplistjabatan.TabIndex = 50
        Me.grouplistjabatan.TabStop = False
        Me.grouplistjabatan.Text = "LIST JABATAN"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(466, 203)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(267, 203)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(77, 203)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(7, 22)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(51, 13)
        Me.lblsearch.TabIndex = 1
        Me.lblsearch.Text = "SEARCH"
        '
        'dglistjabatan
        '
        Me.dglistjabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistjabatan.Location = New System.Drawing.Point(10, 45)
        Me.dglistjabatan.Name = "dglistjabatan"
        Me.dglistjabatan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dglistjabatan.Size = New System.Drawing.Size(608, 152)
        Me.dglistjabatan.TabIndex = 0
        '
        'groupjabatan
        '
        Me.groupjabatan.Controls.Add(Me.groupmenu)
        Me.groupjabatan.Controls.Add(Me.lblmenu)
        Me.groupjabatan.Controls.Add(Me.btncancel)
        Me.groupjabatan.Controls.Add(Me.btnsave)
        Me.groupjabatan.Controls.Add(Me.txtkomisi)
        Me.groupjabatan.Controls.Add(Me.txtjabatan)
        Me.groupjabatan.Controls.Add(Me.lblkomisi)
        Me.groupjabatan.Controls.Add(Me.lbljabatan)
        Me.groupjabatan.Enabled = False
        Me.groupjabatan.Location = New System.Drawing.Point(14, 275)
        Me.groupjabatan.Name = "groupjabatan"
        Me.groupjabatan.Size = New System.Drawing.Size(651, 281)
        Me.groupjabatan.TabIndex = 51
        Me.groupjabatan.TabStop = False
        Me.groupjabatan.Text = "JABATAN"
        '
        'groupmenu
        '
        Me.groupmenu.Controls.Add(Me.CheckBox5)
        Me.groupmenu.Controls.Add(Me.CheckBox6)
        Me.groupmenu.Controls.Add(Me.CheckBox7)
        Me.groupmenu.Controls.Add(Me.CheckBox8)
        Me.groupmenu.Controls.Add(Me.chklaporan)
        Me.groupmenu.Controls.Add(Me.chkpembelian)
        Me.groupmenu.Controls.Add(Me.chkpenjualan)
        Me.groupmenu.Controls.Add(Me.chkmaster)
        Me.groupmenu.Location = New System.Drawing.Point(102, 83)
        Me.groupmenu.Name = "groupmenu"
        Me.groupmenu.Size = New System.Drawing.Size(272, 132)
        Me.groupmenu.TabIndex = 16
        Me.groupmenu.TabStop = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(144, 87)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 23
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(144, 64)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 22
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(144, 41)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 21
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(144, 18)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 20
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'chklaporan
        '
        Me.chklaporan.AutoSize = True
        Me.chklaporan.Location = New System.Drawing.Point(13, 87)
        Me.chklaporan.Name = "chklaporan"
        Me.chklaporan.Size = New System.Drawing.Size(77, 17)
        Me.chklaporan.TabIndex = 19
        Me.chklaporan.Text = "LAPORAN"
        Me.chklaporan.UseVisualStyleBackColor = True
        '
        'chkpembelian
        '
        Me.chkpembelian.AutoSize = True
        Me.chkpembelian.Location = New System.Drawing.Point(13, 64)
        Me.chkpembelian.Name = "chkpembelian"
        Me.chkpembelian.Size = New System.Drawing.Size(87, 17)
        Me.chkpembelian.TabIndex = 18
        Me.chkpembelian.Text = "PEMBELIAN"
        Me.chkpembelian.UseVisualStyleBackColor = True
        '
        'chkpenjualan
        '
        Me.chkpenjualan.AutoSize = True
        Me.chkpenjualan.Location = New System.Drawing.Point(13, 41)
        Me.chkpenjualan.Name = "chkpenjualan"
        Me.chkpenjualan.Size = New System.Drawing.Size(89, 17)
        Me.chkpenjualan.TabIndex = 17
        Me.chkpenjualan.Text = "PENJUALAN"
        Me.chkpenjualan.UseVisualStyleBackColor = True
        '
        'chkmaster
        '
        Me.chkmaster.AutoSize = True
        Me.chkmaster.Location = New System.Drawing.Point(13, 18)
        Me.chkmaster.Name = "chkmaster"
        Me.chkmaster.Size = New System.Drawing.Size(71, 17)
        Me.chkmaster.TabIndex = 16
        Me.chkmaster.Text = "MASTER"
        Me.chkmaster.UseVisualStyleBackColor = True
        '
        'lblmenu
        '
        Me.lblmenu.AutoSize = True
        Me.lblmenu.Location = New System.Drawing.Point(36, 83)
        Me.lblmenu.Name = "lblmenu"
        Me.lblmenu.Size = New System.Drawing.Size(39, 13)
        Me.lblmenu.TabIndex = 7
        Me.lblmenu.Text = "MENU"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(387, 247)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(158, 247)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmjabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 571)
        Me.Controls.Add(Me.grouplistjabatan)
        Me.Controls.Add(Me.groupjabatan)
        Me.Name = "frmjabatan"
        Me.Text = "frmjabatan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grouplistjabatan.ResumeLayout(False)
        Me.grouplistjabatan.PerformLayout()
        CType(Me.dglistjabatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupjabatan.ResumeLayout(False)
        Me.groupjabatan.PerformLayout()
        Me.groupmenu.ResumeLayout(False)
        Me.groupmenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtcarijabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtkomisi As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents lblkomisi As System.Windows.Forms.Label
    Friend WithEvents lbljabatan As System.Windows.Forms.Label
    Friend WithEvents grouplistjabatan As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents dglistjabatan As System.Windows.Forms.DataGridView
    Friend WithEvents groupjabatan As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents lblmenu As System.Windows.Forms.Label
    Friend WithEvents groupmenu As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents chklaporan As System.Windows.Forms.CheckBox
    Friend WithEvents chkpembelian As System.Windows.Forms.CheckBox
    Friend WithEvents chkpenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents chkmaster As System.Windows.Forms.CheckBox
End Class
