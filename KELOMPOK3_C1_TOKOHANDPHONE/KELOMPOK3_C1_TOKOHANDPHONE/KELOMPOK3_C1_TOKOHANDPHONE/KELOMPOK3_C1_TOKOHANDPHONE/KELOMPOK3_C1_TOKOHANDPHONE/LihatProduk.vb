Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class LihatProduk

    ' buka halaman detail
    Private Sub OpenDetail(sender As Object, e As EventArgs)

        ' jika sedang terbuka
        If Detail.IsHandleCreated Then
            Detail.Close()
        End If

        Detail.Name = sender.Name
        Detail.Show()

    End Sub

    ' pilih Produk
    Private Sub SelectProduk(sender As Object, e As EventArgs)
        With sender.FlatAppearance

            If .BorderColor = Color.Silver Then
                sender.Tag = "selected"
                sender.BackColor = C_SELECT
                .BorderColor = Color.Teal
            Else
                sender.Tag = ""
                sender.BackColor = Color.White
                .BorderColor = Color.Silver
            End If

            Dim selected As Integer = 0
            For Each Produk In ListProduk.Controls.OfType(Of Button)
                selected = IIf(Produk.Tag = "selected", selected + 1, selected)
            Next


            'MenuAdmin.LblStatus.Text = selected & " dipilih"
        End With
    End Sub

    ' unselect pilihan Produk
    Private Sub UnselectAll()
        For Each Produk In ListProduk.Controls.OfType(Of Button)
            Produk.FlatAppearance.BorderColor = Color.Silver
            Produk.BackColor = Color.White
            Produk.Tag = ""
        Next

        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnPilih.Text = "Pilih"
        'MenuAdmin.LblStatus.Visible = False
        'MenuAdmin.LblStatus.Text = "0 dipilih"
    End Sub

    ' tampilkan Produk
    Public Sub LoadProduk(query As String)
        ListProduk.Controls.Clear()

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        Do While (RD.Read())
            Dim Produk As New Button

            With Produk
                .Font = New Drawing.Font("Verdana", 8)
                .Size = New Size(145, 200)

                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 1
                .FlatAppearance.BorderColor = Color.Silver

                .Padding = New Padding(3, 0, 3, 0)
                .Margin = New Padding(11, 0, 0, 10)

                Dim img As Image
                img = ByteToImg(RD.Item("Gambarkcmt"))
                img = ResizeImg(img, 128, 128)

                .Image = img
                .ImageAlign = ContentAlignment.TopLeft

                .TextImageRelation = TextImageRelation.ImageAboveText
                .TextAlign = ContentAlignment.TopLeft

                .Name = RD.Item("idkcmt")
                .Text = vbCrLf + RD.Item("namakcmt") + vbCrLf + "Rp " + RD.Item("hargakcmt").ToString()

                ' tambahkan event ke tiap-tiap Produk
                AddHandler .Click, AddressOf OpenDetail

            End With

            ListProduk.Controls.Add(Produk)
        Loop
        RD.Close()


    End Sub

    Public Sub ResetFilter()
        TxtSearch.Clear()
        CbBoxJenis.SelectedIndex = 0
        CbBoxSort.SelectedIndex = 0
    End Sub


    ' -- FORM -----------------------------------------------------------------------------------------------

    ' Form - Load
    Private Sub LihatProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False

        BtnEdit.Visible = False
        BtnHapus.Visible = False
        'MenuAdmin.LblStatus.Visible = False

        'BtnPilih.Visible = False

        'CbBoxJenis.Items.Add("Semua")
        'CbBoxJenis.Items.Add("Produk Hias")
        'CbBoxJenis.Items.Add("Produk Buah")
        'CbBoxJenis.Items.Add("Benih Produk")

        CbBoxSort.Items.Add("namakcmt ASC")
        CbBoxSort.Items.Add("namakcmt DESC")
        CbBoxSort.Items.Add("Hargakcmt ASC")
        CbBoxSort.Items.Add("Hargakcmt DESC")

        CbBoxSort.SelectedIndex = 0
        'CbBoxJenis.SelectedIndex = 0

        ' produk yg tersedia
        LoadProduk(
            "SELECT * FROM tbkcmt " +
            "ORDER BY " + CbBoxSort.Text
        )
    End Sub

    ' -- BUTTON -----------------------------------------------------------------------------------------------

    ' Pilih - Click
    Private Sub BtnPilih_Click(sender As Object, e As EventArgs) Handles BtnPilih.Click
        sender.Text = IIf(sender.Text = "Pilih", "Batal", "Pilih")

        For Each Produk In ListProduk.Controls.OfType(Of Button)
            If sender.Text = "Batal" Then
                'MainWindow.LblStatus.Visible = True
                RemoveHandler Produk.Click, AddressOf OpenDetail
                AddHandler Produk.Click, AddressOf SelectProduk
            Else
                UnselectAll()
                RemoveHandler Produk.Click, AddressOf SelectProduk
                AddHandler Produk.Click, AddressOf OpenDetail
            End If
        Next

    End Sub

    ' Hapus - Click
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        Dim hapus As String,
            query As String

        hapus = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus " & vbCrLf & "produk yang dipilih?",
            "Peringatan",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        )

        ' hapus Produk
        If hapus = MsgBoxResult.Ok Then

            For Each Produk In ListProduk.Controls.OfType(Of Button)
                If Produk.Tag = "selected" Then

                    query = "DELETE FROM tbkcmt " &
                            "WHERE idkcmt='" & Produk.Name & "'"
                    CMD = New MySqlCommand(query, CONN)
                    CMD.ExecuteNonQuery()

                End If
            Next

            MessageBox.Show(
                "Produk telah berhasil dihapus!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadProduk(
                "SELECT * FROM tbkcmt " &
                IIf(CbBoxJenis.Text = "Semua", "", "WHERE jeniskcmt='" & CbBoxJenis.Text & "' ") &
                "ORDER BY " & CbBoxSort.Text
            )
        End If

    End Sub

    ' Edit - Click
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' buka halaman edit Produk
        For Each Produk In ListProduk.Controls.OfType(Of Button)
            If Produk.Tag = "selected" Then
                MenuAdmin.Show()
            End If
        Next
    End Sub


    ' -- TEXTBOX -------------------------------------------------------------------------------------------------

    ' Search - GotFocus
    Private Sub TxtSearch_GotFocus(sender As Object, e As EventArgs) Handles TxtSearch.GotFocus
        If sender.Text = "Search" Then
            sender.Clear()
        End If

        sender.ForeColor = Color.Black
        UnselectAll()
    End Sub

    ' Search - LostFocus 
    Private Sub TxtSearch_LostFocus(sender As Object, e As EventArgs) Handles TxtSearch.LostFocus
        If sender.Text = vbNullString Then
            sender.Text = "Search"
            sender.ForeColor = Color.DarkGray
        Else
            sender.ForeColor = Color.Black
        End If
    End Sub

    ' Search - KeyPress
    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            LoadProduk(
                "SELECT * FROM tbkcmt " +
                "WHERE namakcmt LIKE '%" + sender.Text + "%' " +
                "ORDER BY " + CbBoxSort.Text
            )
            CbBoxJenis.SelectedIndex = 0
        End If

    End Sub

    ' Search - TextChanged
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        If sender.Text = vbNullString Then
            LoadProduk(
                "SELECT * FROM tbkcmt " +
                If(CbBoxJenis.Text = "Semua", "", "WHERE jeniskcmt='" & CbBoxJenis.Text & "' ") +
                "ORDER BY " & CbBoxSort.Text
            )
        End If
    End Sub

    ' -- COMBOBOX -------------------------------------------------------------------------------------------------

    ' Jenis & Sort - SelectedIndexChanged
    Private Sub CbBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CbBoxJenis.SelectedIndexChanged, CbBoxSort.SelectedIndexChanged

        If TxtSearch.Text = "Search" Then
            LoadProduk(
                "SELECT * FROM tbkcmt " +
                IIf(CbBoxJenis.Text = "Semua", "", "WHERE jeniskcmt='" & CbBoxJenis.Text & "' ") +
                "ORDER BY " & CbBoxSort.Text
            )
        Else
            LoadProduk(
                "SELECT * FROM tbkcmt " +
                "WHERE namakcmt LIKE '%" & TxtSearch.Text & "%' " +
                IIf(CbBoxJenis.Text = "Semua", "", "AND jeniskcmt='" & CbBoxJenis.Text & "' ") +
                "ORDER BY " & CbBoxSort.Text
            )
        End If
    End Sub

End Class