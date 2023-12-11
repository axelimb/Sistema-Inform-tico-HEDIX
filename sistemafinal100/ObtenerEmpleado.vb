Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module ObtenerEmpleado
    Dim Nombre As String
    Dim Apellido As String
    Dim Usuario As String
    Function empleado(ByVal Cedula As String) As String
        Try
            Abrir_Conexion()
            Dim command As New SqlCommand("ObtenerNombreApellidoPorCedulaLeche", conexion)
            command.CommandType = CommandType.StoredProcedure
            ' Agrega el parámetro para la cédula
            command.Parameters.AddWithValue("@Cedula", Cedula)
            ' Ejecuta el procedimiento y guarda el resultado
            Dim resultado As SqlDataReader = command.ExecuteReader()
            If resultado.Read() Then
                Nombre = resultado("Nombre").ToString()
                Apellido = resultado("Apellido").ToString()

                Usuario = Nombre + " " + Apellido
            Else
                MessageBox.Show("A ocurrido un error")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then
                Cerrar_Conexion()
            End If
        End Try
        Return Usuario
    End Function
End Module
