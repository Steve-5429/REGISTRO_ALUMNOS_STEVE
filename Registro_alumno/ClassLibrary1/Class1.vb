Imports System.Data.SqlClient
Public Class Class1
    Dim cnx As New SqlConnection("server=localhost\SQLEXPRESS;integrated security=true;Database=steve")

    REM para llenar los dato :) Y hacer la conexion 

    Public Function ListAlumnos() As DataTable
        Dim a As New SqlDataAdapter("pb_listas", cnx)
        Dim b As New DataTable
        a.Fill(b)
        Return b

    End Function

    REM funcion para registrar 
    Public Function Insertar(id_a As String, nom As String, ape As String, dire As String, ema As String, fecha_ing As Date, regist As Char)
        Dim a As New SqlCommand("pb_nuevo", cnx)
        a.CommandType = CommandType.StoredProcedure
        a.Parameters.AddWithValue("@id", id_a)
        a.Parameters.AddWithValue("@nombre", nom)
        a.Parameters.AddWithValue("@apellido", ape)
        a.Parameters.AddWithValue("@direccion", dire)
        a.Parameters.AddWithValue("@email", ema)
        a.Parameters.AddWithValue("@fechaing", fecha_ing)
        a.Parameters.AddWithValue("@reg", regist)
        cnx.Open()
        Dim resp As Integer
        Try
            resp = a.ExecuteNonQuery
            cnx.Close()

        Catch ex As Exception
            MsgBox("Error al registrar usuario")

        End Try
        Return resp

    End Function
    Public Function Eliminar(codigo As String)
        Dim elim As New SqlCommand("pb_eliminar", cnx)
        elim.CommandType = CommandType.StoredProcedure
        elim.Parameters.AddWithValue("@codigo", codigo)
        cnx.Open()
        Dim elim1 As String = elim.ExecuteNonQuery
        cnx.Close()
        Return elim1
    End Function
    Public Function Modificar(codigo As String, id_a As String, nombre As String, apellido As String, direccion As String, ema As String, fecha_ing As Date, regist As Char) As Integer
        Dim c As New SqlCommand("pb_modificar", cnx)
        c.CommandType = CommandType.StoredProcedure
        c.Parameters.AddWithValue("@codigo", codigo)
        c.Parameters.AddWithValue("@id", id_a)
        c.Parameters.AddWithValue("@nombre", nombre)
        c.Parameters.AddWithValue("@apellido", apellido)
        c.Parameters.AddWithValue("@direccion", direccion)
        c.Parameters.AddWithValue("@email", ema)
        c.Parameters.AddWithValue("@fechaing", fecha_ing)
        c.Parameters.AddWithValue("@reg", regist)
        cnx.Open()
        Dim actu1 As String = c.ExecuteNonQuery
        cnx.Close()
        Return actu1
    End Function


End Class
