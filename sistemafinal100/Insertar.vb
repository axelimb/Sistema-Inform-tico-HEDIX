Imports System.Data.SqlClient


Module ModuloInsercion

    Sub InsertarDatos(ByVal tabla As String, ByVal cantidadUnidad As String, ByVal personalACargo As String)
        tabla = If(tabla <> "", tabla, 0)
        cantidadUnidad = If(cantidadUnidad <> "", cantidadUnidad, 0)
        personalACargo = If(personalACargo <> "", personalACargo, 0)

        Try
            Dim cmd As New SqlCommand
            Abrir_Conexion()

            cmd = New SqlCommand("InsertarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ajusta los nombres de los parámetros según tu procedimiento almacenado
            cmd.Parameters.AddWithValue("@Tabla", tabla)
            cmd.Parameters.AddWithValue("@CantidadUnidad", cantidadUnidad)
            cmd.Parameters.AddWithValue("@PersonalACargo", personalACargo)

            cmd.ExecuteNonQuery()

            Cerrar_Conexion()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module

