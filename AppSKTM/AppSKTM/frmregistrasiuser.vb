Imports System.Data.SqlClient
Public Class frmregistrasiuser

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        Button1.Text = "INPUT"
        Button4.Text = "CLOSE"
        Button1.Enabled = True
        Button4.Enabled = True

        Call Koneksi()
        Da = New SqlDataAdapter("Select kodepegawai, namapegawai, levelpegawai From tbl_pegawai", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pegawai")
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
        TextBox3.PasswordChar = "*"
    End Sub

    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "CLOSE" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub frmregistrasiuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 30
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "Simpan"
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan Semua Field Terisi")
            Else
                Call Koneksi()
                Dim SimpanData As String = "Insert Into tbl_pegawai values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New SqlCommand(SimpanData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan")
                Call KondisiAwal()
            End If
        End If
    End Sub
End Class