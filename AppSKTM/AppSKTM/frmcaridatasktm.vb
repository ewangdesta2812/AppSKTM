Imports System.Data.SqlClient
Public Class frmcaridatasktm

    Private Sub frmcaridatasktm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("Select * From tbl_warga", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_warga")
        DataGridView1.DataSource = (Ds.Tables("tbl_warga"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New SqlCommand("Select * from tbl_warga where namawarga Like '%" & TextBox1.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call Koneksi()
            Da = New SqlDataAdapter("Select * from tbl_warga where namawarga Like '%" & TextBox1.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DataGridView1.DataSource = (Ds.Tables("KetemuData"))
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call Koneksi()
        Cmd = New SqlCommand("Select * from tbl_warga where namawarga Like '%" & TextBox1.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call Koneksi()
            Da = New SqlDataAdapter("Select * from tbl_warga where namawarga Like '%" & TextBox1.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DataGridView1.DataSource = (Ds.Tables("KetemuData"))
        End If
    End Sub
End Class