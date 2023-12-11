Imports System.Data.SqlClient

Public Class registrouser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            If TextBox7.Text <> "1234567" Then
                MessageBox.Show("Clave de Registro de Usuario Inválida")
            Else
                Try
                    Dim cmd As New SqlCommand
                    Abrir_Conexion()
                    cmd = New SqlCommand("InsertarEmpleado", conexion)
                    cmd.CommandType = 4

                    cmd.Parameters.AddWithValue("@Nombre", TextBox1.Text.ToString)
                    cmd.Parameters.AddWithValue("@Apellido", TextBox2.Text.ToString)
                    cmd.Parameters.AddWithValue("@Edad", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@Direccion", TextBox4.Text.ToString)
                    cmd.Parameters.AddWithValue("@CedulaParaguaya", TextBox5.Text.ToString)
                    cmd.Parameters.AddWithValue("@Contraseña", TextBox6.Text.ToString)
                    cmd.ExecuteNonQuery()
                    Cerrar_Conexion()
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Debe completar todos los campos")
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub registrouser(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
End Class