Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Detail

    Public Sub LoadData()
        Dim query As String
        query = "SELECT * FROM tbkcmt " + "WHERE idkcmt='" + Me.Name + "'"

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        While (RD.Read())
            PicBoxGambar.Image = ByteToImg(RD.Item("Gambarkcmt"))
            Text = RD.Item("namakcmt")
            TxtNama.Text = RD.Item("namakcmt")
            'TxtHargaProduk.Text = StrConv(RD.Item("hargakcmt"), VbStrConv.ProperCase)
            TxtHarga.Text = "Rp " & RD.Item("hargakcmt")
            TxtGaransiProduk.Text = RD.Item("garansikcmt")
            TxtUkuranProduk.Text = RD.Item("ukurankcmt")
            TxtJenisProduk.Text = RD.Item("Jeniskcmt")

        End While

        RD.Close()
    End Sub

    ' -- FORM -----------------------------------------------------------------------------------------------

    Private Sub Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    ' -- BUTTON -----------------------------------------------------------------------------------------------

    ' hapus Produk
    Private Sub BtnHapusProduk_Click(sender As Object, e As EventArgs) Handles BtnHapusProduk.Click
        Dim hapus As String,
    query As String
        hapus = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus" & vbCrLf & "produk ini?",
            "Peringatan",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        )

        If hapus = DialogResult.OK Then
            query = "DELETE FROM tbkcmt " &
                    "WHERE idkcmt='" & Me.Name & "'"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Produk telah berhasil dihapus!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            MenuAdmin.Show()

            Me.Close()
        End If
    End Sub

    Private Sub BtnEditProduk_Click(sender As Object, e As EventArgs) Handles BtnEditProduk.Click
        ' buka halaman edit
        MenuAdmin.Show()
    End Sub

    ' -- BUTTON -----------------------------------------------------------------------------------------------

    ' hapus Produk
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapusProduk.Click
        Dim hapus As String,
            query As String
        hapus = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus" & vbCrLf & "produk ini?",
            "Peringatan",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        )

        If hapus = DialogResult.OK Then
            query = "DELETE FROM kcmt " &
                    "WHERE idkcmt='" & Me.Name & "'"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Produk telah berhasil dihapus!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            MenuAdmin.Show()

            Me.Close()
        End If
    End Sub

    ' -- TEXTBOX -------------------------------------------------------------------------------------------------

    ' Jumlah - KeyPress
    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    ' Jumlah - LostFocus
    Private Sub TxtJumlah_LostFocus(sender As Object, e As EventArgs) Handles TxtJumlah.LostFocus
        If Val(sender.Text) < 1 Then
            sender.Text = 1
        End If
    End Sub

End Class