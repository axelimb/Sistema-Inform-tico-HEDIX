Imports System.Data.SqlClient

Public Class ListarClientes
    Dim idlector
    Private Sub ListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCliente()
        Panel2.Visible = False
    End Sub
    Sub MostrarCliente()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Mostrar_Clientes", conexion)
            da.Fill(dt)
            PanelData.DataSource = dt
            Cerrar_Conexion()
        Catch ex As Exception

        End Try
    End Sub
    Sub Buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Buscar_Comprador", conexion)
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










    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As New SqlCommand
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Try
                Panel1.Visible = False
                Abrir_Conexion()
                cmd = New SqlCommand("Editar_Cliente", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idcliente", idlector)
                cmd.Parameters.AddWithValue("@Nombre", TextBox2.Text.ToString)
                cmd.Parameters.AddWithValue("@Apellido", TextBox3.Text.ToString)
                cmd.Parameters.AddWithValue("@Direccion", TextBox4.Text.ToString)
                cmd.Parameters.AddWithValue("@NumeroTelefono", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Cedula", TextBox6.Text.ToString)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()
                Panel2.Visible = False
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                Panel1.Visible = True
                PanelData.Visible = True
                MostrarCliente()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Ningún campo pueder estar vacío")
        End If
        Application.DoEvents()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Visible = False
        Panel1.Visible = True
        PanelData.Visible = True


    End Sub



    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PanelData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PanelData.CellDoubleClick
        Try
            If PanelData.SelectedCells.Count > 0 Then
                ' Obtener el índice de la primera celda seleccionada
                Dim indiceFila As Integer = PanelData.SelectedCells(0).RowIndex

                ' Verificar si el índice de fila es válido y la celda no está vacía
                If indiceFila >= 0 AndAlso indiceFila < PanelData.Rows.Count AndAlso Not String.IsNullOrEmpty(PanelData.Rows(indiceFila).Cells("Nombre").Value.ToString()) Then
                    ' Obtener la fila correspondiente al índice
                    Dim filaSeleccionada As DataGridViewRow = PanelData.Rows(indiceFila)

                    ' Acceder a las celdas por nombre de columna
                    TextBox2.Text = filaSeleccionada.Cells("Nombre").Value.ToString()
                    TextBox3.Text = filaSeleccionada.Cells("Apellido").Value.ToString()
                    TextBox4.Text = filaSeleccionada.Cells("Direccion").Value.ToString()
                    TextBox5.Text = filaSeleccionada.Cells("NumeroTelefono").Value.ToString()
                    TextBox6.Text = filaSeleccionada.Cells("Cedula").Value.ToString()
                    idlector = filaSeleccionada.Cells("ID").Value.ToString()
                    Panel2.Visible = True
                    Panel1.Visible = False
                    PanelData.Visible = False
                    TextBox1.Clear()
                Else
                    MessageBox.Show("La fila seleccionada está vacía o el índice de fila está fuera de rango.")
                End If
            Else
                MessageBox.Show("No hay celdas seleccionadas.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListarClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
    End Sub
    Private Sub PanelData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PanelData.CellContentClick
        ' Verificar si la columna es la columna "Eliminar"
        If PanelData.Columns(e.ColumnIndex).Name = "Eliminar" Then
            Dim result As MsgBoxResult
            result = MsgBox("El registro se borrará permanentemente, ¿desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Sistema HENIX")

            If result = MsgBoxResult.Ok Then
                Dim cmd As New SqlCommand
                Try
                    Abrir_Conexion()
                    cmd = New SqlCommand("Eliminar_Cliente", conexion)
                    cmd.CommandType = 4

                    ' Obtener el índice de la fila seleccionada
                    Dim indiceFila As Integer = e.RowIndex

                    ' Verificar si el índice de fila es válido y la celda no está vacía
                    If indiceFila >= 0 AndAlso indiceFila < PanelData.Rows.Count AndAlso Not String.IsNullOrEmpty(PanelData.Rows(indiceFila).Cells("ID").Value.ToString()) Then
                        ' Obtener la fila correspondiente al índice
                        Dim filaSeleccionada As DataGridViewRow = PanelData.Rows(indiceFila)

                        ' Acceder a las celdas por nombre de columna
                        Dim valorCelda As Object = filaSeleccionada.Cells("ID").Value
                        cmd.Parameters.AddWithValue("@ID", valorCelda)
                    Else
                        MessageBox.Show("La fila seleccionada está vacía o el índice de fila está fuera de rango.")
                    End If

                    cmd.ExecuteNonQuery()
                    Cerrar_Conexion()
                    MostrarCliente()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            ElseIf result = MsgBoxResult.Cancel Then
                ' Aquí va el código que quieres ejecutar cuando se presiona el botón "Cancelar"
            End If
        End If
    End Sub


    Private Sub PanelData_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelData.MouseDown

    End Sub
End Class