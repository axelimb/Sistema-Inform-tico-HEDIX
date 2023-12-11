Imports System.Data.SqlClient

Public Class FormComprador
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            Try
                Abrir_Conexion()

                Dim cmd As New SqlCommand("InsertarComprador", conexion)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Nombre", TextBox1.Text.ToString)
                cmd.Parameters.AddWithValue("@Apellido", TextBox2.Text.ToString)
                cmd.Parameters.AddWithValue("@Direccion", TextBox3.Text.ToString)
                cmd.Parameters.AddWithValue("@NumeroTelefono", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Cedula", TextBox5.Text.ToString)

                cmd.ExecuteNonQuery()

                Cerrar_Conexion()
                Me.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Todos los campos deben ser completados")
        End If


    End Sub
    Private Sub FormComprador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class