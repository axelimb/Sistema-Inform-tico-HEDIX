Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Module conexionmaestra
    Public conexion As New SqlConnection("server=DESKTOP-4KE6Q84\SQLSERVER;database=sistemacrud; integrated security=true")
    Sub Abrir_Conexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    Sub Cerrar_Conexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub

End Module
