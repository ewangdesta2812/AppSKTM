﻿Imports System.Data.SqlClient
Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "data source=DESKTOP-2Q9PCIP\SQLEXPRESS;initial catalog=db_sktm; integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
