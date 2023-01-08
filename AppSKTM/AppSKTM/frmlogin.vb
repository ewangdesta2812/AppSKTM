Imports System.Data.SqlClient
Public Class frmlogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New SqlCommand("Select * From tbl_pegawai where namapegawai='" & TextBox1.Text & "' and passwordpegawai= '" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call BukaKunci()
            frmmenuutama.STLabel2.Text = Rd!namapegawai
            frmmenuutama.STLabel4.Text = Rd!levelpegawai
            If frmmenuutama.STLabel4.Text = "USER" Then
                frmmenuutama.RegisterUserToolStripMenuItem.Enabled = False
                frmmenuutama.PegawaiToolStripMenuItem.Enabled = False
            End If
        Else
            MsgBox("Username atau Password Salah!")
        End If
    End Sub
    Sub BukaKunci()
        frmmenuutama.LoginToolStripMenuItem.Enabled = False
        frmmenuutama.LogoutToolStripMenuItem.Enabled = True
        frmmenuutama.MasterToolStripMenuItem.Enabled = True
        frmmenuutama.CariDataToolStripMenuItem.Enabled = True
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "Ewang"
        TextBox2.Text = "123"
    End Sub
End Class