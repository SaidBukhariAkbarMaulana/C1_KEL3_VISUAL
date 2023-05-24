<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProduk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProduk))
        Me.PBUbah = New System.Windows.Forms.PictureBox()
        Me.PBTambahGambar = New System.Windows.Forms.PictureBox()
        Me.PBGambar = New System.Windows.Forms.PictureBox()
        Me.PBClear = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CBJenis = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBUkuran = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTambahProduk = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnlutama = New System.Windows.Forms.Panel()
        Me.PBReturn = New System.Windows.Forms.PictureBox()
        Me.BPemesanan = New System.Windows.Forms.Button()
        Me.PBExit = New System.Windows.Forms.PictureBox()
        Me.BUser = New System.Windows.Forms.Button()
        Me.BDataProduk = New System.Windows.Forms.Button()
        Me.BHome = New System.Windows.Forms.Button()
        Me.PnlTambah = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBGaransi = New System.Windows.Forms.TextBox()
        Me.TBHarga = New System.Windows.Forms.TextBox()
        Me.TBNama = New System.Windows.Forms.TextBox()
        CType(Me.PBUbah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTambahGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlutama.SuspendLayout()
        CType(Me.PBReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTambah.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBUbah
        '
        Me.PBUbah.BackColor = System.Drawing.Color.Transparent
        Me.PBUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBUbah.Image = CType(resources.GetObject("PBUbah.Image"), System.Drawing.Image)
        Me.PBUbah.Location = New System.Drawing.Point(278, 287)
        Me.PBUbah.Name = "PBUbah"
        Me.PBUbah.Size = New System.Drawing.Size(45, 43)
        Me.PBUbah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBUbah.TabIndex = 57
        Me.PBUbah.TabStop = False
        '
        'PBTambahGambar
        '
        Me.PBTambahGambar.BackColor = System.Drawing.Color.Transparent
        Me.PBTambahGambar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBTambahGambar.Image = CType(resources.GetObject("PBTambahGambar.Image"), System.Drawing.Image)
        Me.PBTambahGambar.Location = New System.Drawing.Point(219, 287)
        Me.PBTambahGambar.Name = "PBTambahGambar"
        Me.PBTambahGambar.Size = New System.Drawing.Size(45, 43)
        Me.PBTambahGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBTambahGambar.TabIndex = 56
        Me.PBTambahGambar.TabStop = False
        '
        'PBGambar
        '
        Me.PBGambar.BackColor = System.Drawing.Color.Gray
        Me.PBGambar.Location = New System.Drawing.Point(549, 131)
        Me.PBGambar.Margin = New System.Windows.Forms.Padding(2)
        Me.PBGambar.Name = "PBGambar"
        Me.PBGambar.Size = New System.Drawing.Size(183, 136)
        Me.PBGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBGambar.TabIndex = 55
        Me.PBGambar.TabStop = False
        '
        'PBClear
        '
        Me.PBClear.BackColor = System.Drawing.Color.Transparent
        Me.PBClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBClear.Image = CType(resources.GetObject("PBClear.Image"), System.Drawing.Image)
        Me.PBClear.Location = New System.Drawing.Point(160, 287)
        Me.PBClear.Name = "PBClear"
        Me.PBClear.Size = New System.Drawing.Size(45, 43)
        Me.PBClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBClear.TabIndex = 53
        Me.PBClear.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(319, 174)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 15)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Jenis Handphone"
        '
        'CBJenis
        '
        Me.CBJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CBJenis.FormattingEnabled = True
        Me.CBJenis.Items.AddRange(New Object() {"SAMSUNG", "HUAWEI", "APPLE", "OPPO", "LENOVO", "ASUS"})
        Me.CBJenis.Location = New System.Drawing.Point(321, 196)
        Me.CBJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.CBJenis.Name = "CBJenis"
        Me.CBJenis.Size = New System.Drawing.Size(185, 23)
        Me.CBJenis.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(228, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Ukuran Handphone"
        '
        'TBUkuran
        '
        Me.TBUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TBUkuran.Location = New System.Drawing.Point(230, 256)
        Me.TBUkuran.Name = "TBUkuran"
        Me.TBUkuran.Size = New System.Drawing.Size(187, 21)
        Me.TBUkuran.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(200, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(480, 42)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "EDIT DATA HANDPHONE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(317, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Garansi Handphone"
        '
        'BTambahProduk
        '
        Me.BTambahProduk.BackColor = System.Drawing.Color.Transparent
        Me.BTambahProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTambahProduk.FlatAppearance.BorderSize = 0
        Me.BTambahProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTambahProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTambahProduk.ForeColor = System.Drawing.SystemColors.Control
        Me.BTambahProduk.Location = New System.Drawing.Point(135, 16)
        Me.BTambahProduk.Name = "BTambahProduk"
        Me.BTambahProduk.Size = New System.Drawing.Size(161, 37)
        Me.BTambahProduk.TabIndex = 2
        Me.BTambahProduk.Text = "TAMBAH PRODUK"
        Me.BTambahProduk.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pnlutama
        '
        Me.pnlutama.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.pnlutama.BackgroundImage = CType(resources.GetObject("pnlutama.BackgroundImage"), System.Drawing.Image)
        Me.pnlutama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlutama.Controls.Add(Me.PBReturn)
        Me.pnlutama.Controls.Add(Me.BPemesanan)
        Me.pnlutama.Controls.Add(Me.PBExit)
        Me.pnlutama.Controls.Add(Me.BUser)
        Me.pnlutama.Controls.Add(Me.BDataProduk)
        Me.pnlutama.Controls.Add(Me.BHome)
        Me.pnlutama.Controls.Add(Me.BTambahProduk)
        Me.pnlutama.Controls.Add(Me.PnlTambah)
        Me.pnlutama.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlutama.Location = New System.Drawing.Point(0, 0)
        Me.pnlutama.Name = "pnlutama"
        Me.pnlutama.Size = New System.Drawing.Size(878, 498)
        Me.pnlutama.TabIndex = 2
        '
        'PBReturn
        '
        Me.PBReturn.BackColor = System.Drawing.Color.Transparent
        Me.PBReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBReturn.Image = CType(resources.GetObject("PBReturn.Image"), System.Drawing.Image)
        Me.PBReturn.Location = New System.Drawing.Point(770, 16)
        Me.PBReturn.Name = "PBReturn"
        Me.PBReturn.Size = New System.Drawing.Size(34, 32)
        Me.PBReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBReturn.TabIndex = 59
        Me.PBReturn.TabStop = False
        '
        'BPemesanan
        '
        Me.BPemesanan.BackColor = System.Drawing.Color.Transparent
        Me.BPemesanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BPemesanan.FlatAppearance.BorderSize = 0
        Me.BPemesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPemesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPemesanan.ForeColor = System.Drawing.SystemColors.Control
        Me.BPemesanan.Location = New System.Drawing.Point(567, 16)
        Me.BPemesanan.Name = "BPemesanan"
        Me.BPemesanan.Size = New System.Drawing.Size(161, 37)
        Me.BPemesanan.TabIndex = 14
        Me.BPemesanan.Text = "DATA PEMBELIAN"
        Me.BPemesanan.UseVisualStyleBackColor = False
        '
        'PBExit
        '
        Me.PBExit.BackColor = System.Drawing.Color.Transparent
        Me.PBExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBExit.Image = CType(resources.GetObject("PBExit.Image"), System.Drawing.Image)
        Me.PBExit.Location = New System.Drawing.Point(827, 16)
        Me.PBExit.Name = "PBExit"
        Me.PBExit.Size = New System.Drawing.Size(35, 34)
        Me.PBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBExit.TabIndex = 58
        Me.PBExit.TabStop = False
        '
        'BUser
        '
        Me.BUser.BackColor = System.Drawing.Color.Transparent
        Me.BUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BUser.FlatAppearance.BorderSize = 0
        Me.BUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BUser.Location = New System.Drawing.Point(445, 16)
        Me.BUser.Name = "BUser"
        Me.BUser.Size = New System.Drawing.Size(123, 37)
        Me.BUser.TabIndex = 13
        Me.BUser.Text = "DATA USER"
        Me.BUser.UseVisualStyleBackColor = False
        '
        'BDataProduk
        '
        Me.BDataProduk.BackColor = System.Drawing.Color.Transparent
        Me.BDataProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BDataProduk.FlatAppearance.BorderSize = 0
        Me.BDataProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDataProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDataProduk.ForeColor = System.Drawing.SystemColors.Control
        Me.BDataProduk.Location = New System.Drawing.Point(311, 16)
        Me.BDataProduk.Name = "BDataProduk"
        Me.BDataProduk.Size = New System.Drawing.Size(129, 37)
        Me.BDataProduk.TabIndex = 12
        Me.BDataProduk.Text = "DATA PRODUK"
        Me.BDataProduk.UseVisualStyleBackColor = False
        '
        'BHome
        '
        Me.BHome.BackColor = System.Drawing.Color.Transparent
        Me.BHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BHome.FlatAppearance.BorderSize = 0
        Me.BHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHome.ForeColor = System.Drawing.SystemColors.Control
        Me.BHome.Location = New System.Drawing.Point(21, 16)
        Me.BHome.Name = "BHome"
        Me.BHome.Size = New System.Drawing.Size(97, 37)
        Me.BHome.TabIndex = 9
        Me.BHome.Text = "HOME"
        Me.BHome.UseVisualStyleBackColor = False
        '
        'PnlTambah
        '
        Me.PnlTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PnlTambah.BackgroundImage = CType(resources.GetObject("PnlTambah.BackgroundImage"), System.Drawing.Image)
        Me.PnlTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTambah.Controls.Add(Me.PBUbah)
        Me.PnlTambah.Controls.Add(Me.PBTambahGambar)
        Me.PnlTambah.Controls.Add(Me.PBGambar)
        Me.PnlTambah.Controls.Add(Me.PBClear)
        Me.PnlTambah.Controls.Add(Me.Label18)
        Me.PnlTambah.Controls.Add(Me.CBJenis)
        Me.PnlTambah.Controls.Add(Me.Label2)
        Me.PnlTambah.Controls.Add(Me.TBUkuran)
        Me.PnlTambah.Controls.Add(Me.Label9)
        Me.PnlTambah.Controls.Add(Me.Label8)
        Me.PnlTambah.Controls.Add(Me.Label6)
        Me.PnlTambah.Controls.Add(Me.Label3)
        Me.PnlTambah.Controls.Add(Me.TBGaransi)
        Me.PnlTambah.Controls.Add(Me.TBHarga)
        Me.PnlTambah.Controls.Add(Me.TBNama)
        Me.PnlTambah.Location = New System.Drawing.Point(0, 57)
        Me.PnlTambah.Name = "PnlTambah"
        Me.PnlTambah.Size = New System.Drawing.Size(878, 441)
        Me.PnlTambah.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(109, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Harga Handphone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(106, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Nama Handphone"
        '
        'TBGaransi
        '
        Me.TBGaransi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TBGaransi.Location = New System.Drawing.Point(321, 139)
        Me.TBGaransi.Name = "TBGaransi"
        Me.TBGaransi.Size = New System.Drawing.Size(187, 21)
        Me.TBGaransi.TabIndex = 42
        '
        'TBHarga
        '
        Me.TBHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TBHarga.Location = New System.Drawing.Point(113, 198)
        Me.TBHarga.Name = "TBHarga"
        Me.TBHarga.Size = New System.Drawing.Size(183, 21)
        Me.TBHarga.TabIndex = 41
        '
        'TBNama
        '
        Me.TBNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TBNama.Location = New System.Drawing.Point(111, 139)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(185, 21)
        Me.TBNama.TabIndex = 40
        '
        'EditProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 487)
        Me.Controls.Add(Me.pnlutama)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditProduk"
        Me.Text = "EditProduk"
        CType(Me.PBUbah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTambahGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlutama.ResumeLayout(False)
        CType(Me.PBReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTambah.ResumeLayout(False)
        Me.PnlTambah.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBUbah As PictureBox
    Friend WithEvents PBTambahGambar As PictureBox
    Friend WithEvents PBGambar As PictureBox
    Friend WithEvents PBClear As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CBJenis As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBUkuran As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTambahProduk As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pnlutama As Panel
    Friend WithEvents PBReturn As PictureBox
    Friend WithEvents BPemesanan As Button
    Friend WithEvents PBExit As PictureBox
    Friend WithEvents BUser As Button
    Friend WithEvents BDataProduk As Button
    Friend WithEvents BHome As Button
    Friend WithEvents PnlTambah As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBGaransi As TextBox
    Friend WithEvents TBHarga As TextBox
    Friend WithEvents TBNama As TextBox
End Class
