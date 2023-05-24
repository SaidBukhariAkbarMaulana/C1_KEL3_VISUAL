﻿Imports System.IO
Imports MySql.Data.MySqlClient

Public Class EditProduk

    Public Sub LoadData()
        Dim query As String
        query = "SELECT * FROM tbhp " +
                "WHERE idhp='" & MenuAdmin.TxtCariProduk.Text & "'"

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        While (RD.Read())
            Text = RD.Item("namahp")
            MenuAdmin.Lid.Text = RD.Item("idhp")
            TBNama.Text = RD.Item("namahp")
            CBJenis.Text = StrConv(RD.Item("Jenishp"), VbStrConv.ProperCase)
            TBHarga.Text = RD.Item("hargahp")
            TBGaransi.Text = RD.Item("garansihp")
            TBUkuran.Text = RD.Item("ukuranhp")
        End While
        RD.Close()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BHome.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub BTambahProduk_Click(sender As Object, e As EventArgs) Handles BTambahProduk.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub BDataProduk_Click(sender As Object, e As EventArgs) Handles BDataProduk.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub BUser_Click(sender As Object, e As EventArgs) Handles BUser.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub BPemesanan_Click(sender As Object, e As EventArgs) Handles BPemesanan.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Sub Clear()
        TBNama.Text = ""
        TBHarga.Text = ""
        TBGaransi.Text = ""
        TBUkuran.Text = ""
        CBJenis.Text = ""
        'PBGambar.Image = Nothing
    End Sub

    Sub Lihatdatakacamata()
        DA = New MySqlDataAdapter("Select * From tbhp", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbhp")
        MenuAdmin.DGVProduk.DataSource = DS.Tables("tbhp")
        MenuAdmin.DGVProduk.Refresh()
    End Sub

    Private Sub PBUbah_Click(sender As Object, e As EventArgs) Handles PBUbah.Click
        If TBNama.Text = "" Or TBHarga.Text = "" Or TBGaransi.Text = "" Or TBUkuran.Text = "" Then
            MsgBox("Data belum lengkap")
            TBNama.Focus()
        Else
            Call Koneksi()
            Dim Ubah As String = "Update tbhp set namahp ='" & TBNama.Text & "', hargahp ='" & TBHarga.Text & "', 
                               garansihp ='" & TBGaransi.Text & "', ukuranhp ='" & TBUkuran.Text & "', Gambarhp='" & MenuAdmin.Gambar & "'
                               where idhp = '" & MenuAdmin.Lid.Text & "'"
            PBGambar.Image.Save("C:\Users\LENOVO\Downloads\GambarProduk\" & MenuAdmin.Gambar & "")
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Lihatdatakacamata()
            Call Clear()
            TBNama.Focus()
            MenuAdmin.AutoNumber()
        End If
    End Sub

    Private Sub EditProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Koneksi()
        Lihatdatakacamata()
    End Sub

    Private Sub PBTambahGambar_Click(sender As Object, e As EventArgs) Handles PBTambahGambar.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PBGambar.Image = Image.FromFile(OpenFileDialog1.FileName)
            MenuAdmin.Gambar = Path.GetFileName(OpenFileDialog1.FileName)
        End If
        RD.Close()
    End Sub
End Class