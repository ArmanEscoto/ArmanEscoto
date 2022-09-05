Imports System.Data
Imports Npgsql

Public Class Form1

    Dim lv As ListViewItem
    Dim Selected As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PoplistView()


    End Sub
    Private Sub PoplistView()
        Listview1.Clear()

        With Listview1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Lastname", 110)
            .Columns.Add("Firstname", 110)
            .Columns.Add("Middlename", 110)
            .Columns.Add("Adress", 150)
            .Columns.Add("Gender", 100)
            .Columns.Add("Contact no.", 110)
            .Columns.Add("Course", 110)
        End With

        openCon()
        sql = "Select * FROM tblstudinfo"
        cmd = New NpgsqlCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            lv = New ListViewItem(dr("studno").ToString)
            lv.SubItems.Add(dr("studlastname"))
            lv.SubItems.Add(dr("studfirstname"))
            lv.SubItems.Add(dr("studmiddle"))
            lv.SubItems.Add(dr("studaddress"))
            lv.SubItems.Add(dr("studgender"))
            lv.SubItems.Add(dr("studconatct"))
            lv.SubItems.Add(dr("studcourse"))
            Listview1.Items.Add(lv)
        Loop
        cn.Close()
    End Sub


End Class
