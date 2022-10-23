﻿Imports ClassLibrary1
Public Class Form1

    Dim obj As New Class1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = obj.ListAlumnos

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        lblcodi1.Text = DataGridView1.Item(0, e.RowIndex).Value
        txtID.Text = DataGridView1.Item(1, e.RowIndex).Value
        txtnombre.Text = DataGridView1.Item(2, e.RowIndex).Value
        txtapellido.Text = DataGridView1.Item(3, e.RowIndex).Value
        txtdireccion.Text = DataGridView1.Item(4, e.RowIndex).Value
        DateTimePicker1.Text = DataGridView1.Item(5, e.RowIndex).Value
        txtemail.Text = DataGridView1.Item(6, e.RowIndex).Value

    End Sub

    Private Sub REGISTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARToolStripMenuItem.Click
        Try


        Catch ex As Exception
            obj.Insertar(lblcodi1.Text, txtID.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text, (CDate(DateTimePicker1.Text)), txtemail.Text)
            DataGridView1.DataSource = obj.ListAlumnos
            MsgBox("se registro" + txtnombre.Text)
            txtID.Text = ""
            txtapellido.Text = ""
            txtapellido.Text = ""
            txtdireccion.Text = ""
            txtemail.Text = ""
            lblcodi1.Text = "C0000"
            DateTimePicker1.Value = DateTime.Now
        End Try
    End Sub

    Private Sub MODIFICARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem.Click
        Try
            obj.Modificar(lblcodi1.Text, txtID.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text, DateTimePicker1.Text,txtemail.Text )
            DataGridView1.DataSource = obj.ListAlumnos
            MsgBox("se registro :" + lblcodi1.Text)
            txtID.Text = ""
            txtapellido.Text = ""
            txtapellido.Text = ""
            txtdireccion.Text = ""
            txtemail.Text = ""
            lblcodi1.Text = "C0000"
            DateTimePicker1.Value = DateTime.Now

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Try
            obj.Eliminar(lblcodi1.Text)
            DataGridView1.DataSource = obj.ListAlumnos
            MsgBox("se registro el usuario con un codigo" + lblcodi1.Text)
            txtID.Text = ""
            txtapellido.Text = ""
            txtapellido.Text = ""
            txtdireccion.Text = ""
            txtemail.Text = ""
            lblcodi1.Text = "C0000"
            DateTimePicker1.Value = DateTime.Now

        Catch ex As Exception

        End Try
    End Sub

    Private Sub NUEVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem.Click
        txtID.Text = ""
        txtapellido.Text = ""
        txtapellido.Text = ""
        txtdireccion.Text = ""
        txtemail.Text = ""
        lblcodi1.Text = "C0000"
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
