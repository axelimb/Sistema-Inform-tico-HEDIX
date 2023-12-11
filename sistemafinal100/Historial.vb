Imports System.Data.SqlClient

Public Class Historial
    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarVentas()
    End Sub
    Sub MostrarVentas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Mostrar_Ventas", conexion)
            da.Fill(dt)
            PanelData.DataSource = dt
            Cerrar_Conexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Buscar_Compra", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", TextBox1.Text)
            da.Fill(dt)
            PanelData.DataSource = dt
            Cerrar_Conexion()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Buscar()
    End Sub

    Private Sub Historial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
    End Sub
End Class