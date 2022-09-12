Imports System.Data
Imports Npgsql

Public Class Form1

    Dim lv As ListViewItem
    Dim Selected As String

    Private Sub ExecutedNoQuery(query As String)
        openCon()
        cmd = New NpgsqlCommand(query, cn)
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub

    Private Sub ClearAllTextbox()
        Me.txtSID.Text = ""
        Me.txtlastname.Text = ""
        Me.txtfirstname.Text = ""
        Me.txtmiddle.Text = ""
        Me.txtaddress.Text = ""
        Me.cmbgender.Text = ""
        Me.txtcontact.Text = ""
        Me.cmbcourse.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PoplistView()


    End Sub
    Private Sub PoplistView()
        Listview1.Clear()

        With Listview1
            .HideSelection = True
            .FullRowSelect = True
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

    Private Sub btnAddnewStud_Click(sender As Object, e As EventArgs) Handles btnAddnewStud.Click
        If MsgBox("Are you sure to save this record?", (vbYesNo + vbQuestion)) Then
            openCon()
            sql = "INSERT INTO tblstudinfo (studno, studlastname, studfirstname, studmiddle, studaddress, studgender, studconatct, studcourse) VALUES (" & Me.txtSID.Text & ", '" & (Me.txtlastname.Text) & "', '" & (Me.txtfirstname.Text) & "', '" & (Me.txtmiddle.Text) & "', '" & (Me.txtaddress.Text) & "', '" & (Me.cmbgender.Text) & "', '" & (Me.txtcontact.Text) & "', '" & (Me.cmbcourse.Text) & "')"
            cmd = New NpgsqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()

        End If

        PoplistView()
    End Sub

    Private Sub Listview1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listview1.SelectedIndexChanged
        'If Listview1.SelectedItems.Count = 1 Then
        '    txtSID.Text = Listview1.SelectedItems.Item(0).SubItems(0).Text
        '    txtlastname.Text = Listview1.SelectedItems.Item(0).SubItems(1).Text
        '    txtfirstname.Text = Listview1.SelectedItems.Item(0).SubItems(2).Text
        '    txtmiddle.Text = Listview1.SelectedItems.Item(0).SubItems(3).Text
        '    txtaddress.Text = Listview1.SelectedItems.Item(0).SubItems(4).Text
        '    cmbgender.Text = Listview1.SelectedItems.Item(0).SubItems(5).Text
        '    txtcontact.Text = Listview1.SelectedItems.Item(0).SubItems(6).Text
        '    cmbcourse.Text = Listview1.SelectedItems.Item(0).SubItems(7).Text

        'End If

        Dim i As Integer
        For i = 0 To Listview1.SelectedItems.Count - 1
            Selected = Listview1.SelectedItems(i).Text

            openCon()
            sql = "SELECT  * from tblstudinfo WHERE studno = " & Selected & " "
            cmd = New NpgsqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            dr.Read()
            Me.txtSID.Text = dr("studno")
            Me.txtlastname.Text = dr("studlastname")
            Me.txtfirstname.Text = dr("studfirstname")
            Me.txtmiddle.Text = dr("studmiddle")
            Me.txtaddress.Text = ("studaddress")
            Me.cmbgender.Text = dr("studgender")
            Me.txtcontact.Text = dr("studconatct")
            Me.cmbcourse.Text = dr("studcourse")

            cn.Close()

        Next
    End Sub

    Private Sub btnUpdateStud_Click(sender As Object, e As EventArgs) Handles btnUpdateStud.Click
        If MsgBox("Are you sure to Update this?", (vbYesNo + vbExclamation)) Then
            Dim query As String = "UPDATE tblstudinfo SET studlastname = '" & (Me.txtlastname.Text) & "', studfirstname = '" & (Me.txtfirstname.Text) & "', studmiddle = '" & (Me.txtmiddle.Text) & "', studaddress = '" & (Me.txtaddress.Text) & "', studgender =  '" & (Me.cmbgender.Text) & "', studconatct = '" & (Me.txtcontact.Text) & "', studcourse = '" & (Me.cmbcourse.Text) & "' WHERE studno = '" & (Me.txtSID.Text) & "' "
            ExecutedNoQuery(query)
            PoplistView()
            ClearAllTextbox()
        End If
    End Sub

    Private Sub btnDeleteStud_Click(sender As Object, e As EventArgs) Handles btnDeleteStud.Click
        If MsgBox("Are you sure to Delete this?", (vbYesNo + vbExclamation)) Then
            Dim query As String = "DELETE FROM tblstudinfo WHERE studno = ' " & (txtSID.Text) & " ' "
            ExecutedNoQuery(query)
            PoplistView()
            ClearAllTextbox()
        End If
    End Sub
End Class
