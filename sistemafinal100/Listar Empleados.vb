Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Data.SqlClient
Imports System.Net.Security

Public Class Listar_Empleados
    Dim verificar
    Dim idempleado
    Private Sub Listar_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEmpleado()
        Panel2.Visible = False
        Panel3.Parent = Me
        Panel4.Visible = False

        Panel3.Visible = False

    End Sub
    Sub MostrarEmpleado()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Mostrar_Empleados", conexion)
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
            da = New SqlDataAdapter("Buscar_Empleado", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", TextBox1.Text)
            da.Fill(dt)
            PanelData.DataSource = dt
            Cerrar_Conexion()



        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PanelData.CellFormatting
        ' Verificar si la columna actual es la de Contraseña
        If PanelData.Columns(e.ColumnIndex).Name = "Contraseña" AndAlso e.Value IsNot Nothing Then
            ' Mostrar asteriscos en lugar de la contraseña real
            e.Value = New String("*", e.Value.ToString().Length)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Buscar()
    End Sub

    Private Sub Listar_Empleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
    End Sub

    Private Sub PanelData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PanelData.CellDoubleClick
        PanelData.Visible = False



        Try
            If PanelData.SelectedCells.Count > 0 Then
                ' Obtener el índice de la primera celda seleccionada
                Dim indiceFila As Integer = PanelData.SelectedCells(0).RowIndex

                ' Verificar si el índice de fila es válido y la celda no está vacía
                If indiceFila >= 0 AndAlso indiceFila < PanelData.Rows.Count AndAlso Not String.IsNullOrEmpty(PanelData.Rows(indiceFila).Cells("Nombre").Value.ToString()) Then
                    ' Obtener la fila correspondiente al índice
                    Dim filaSeleccionada As DataGridViewRow = PanelData.Rows(indiceFila)

                    ' Acceder a las celdas por nombre de columna
                    TextBox8.Text = filaSeleccionada.Cells(2).Value.ToString()
                    TextBox2.Text = filaSeleccionada.Cells(3).Value.ToString()
                    TextBox3.Text = filaSeleccionada.Cells(4).Value.ToString()
                    TextBox4.Text = filaSeleccionada.Cells(5).Value.ToString()
                    TextBox5.Text = filaSeleccionada.Cells(1).Value.ToString()
                    TextBox6.Text = filaSeleccionada.Cells(6).Value.ToString()




                    ' Resto de tu código
                    idempleado = filaSeleccionada.Cells("ID").Value.ToString()
                    Panel2.Visible = False
                    Panel1.Visible = False
                    Panel3.Visible = True

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        If TextBox8.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Try

                Abrir_Conexion()
                cmd = New SqlCommand("Editar_Empleado", conexion)
                cmd.CommandType = 4

                cmd.Parameters.AddWithValue("@idEmpleado", idempleado)
                cmd.Parameters.AddWithValue("@Nombre", TextBox8.Text.ToString)
                cmd.Parameters.AddWithValue("@Apellido", TextBox2.Text.ToString)
                cmd.Parameters.AddWithValue("@Edad", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Direccion", TextBox4.Text.ToString)
                cmd.Parameters.AddWithValue("@Cedula", TextBox5.Text.ToString)
                cmd.Parameters.AddWithValue("@Contraseña", TextBox6.Text.ToString)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()
                TextBox8.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                MostrarEmpleado()
                Panel2.Visible = False
                Panel1.Visible = True
                PanelData.Visible = True







            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Ningún campo puede estar vacío")
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox7.Clear()
        Panel3.Visible = False
        PanelData.Visible = True
        Panel1.Visible = True
    End Sub

    Private Sub PanelData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PanelData.CellContentClick
        ' Verificar si la columna es la columna "Eliminar"


        If PanelData.Columns(e.ColumnIndex).Name = "Eliminar" And PanelData.Visible Then
            PanelData.Visible = False

            ' Verificar si la entrada es igual a "1234567"

            ' Realizar la eliminación solo si el usuario hace clic en OK y la entrada es correcta

            Dim cmd As New SqlCommand
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Eliminar_Empleado", conexion)
                cmd.CommandType = 4

                ' Obtener el índice de la fila seleccionada
                Dim indiceFila As Integer = e.RowIndex

                ' Verificar si el índice de fila es válido y la celda no está vacía
                If indiceFila >= 0 AndAlso indiceFila < PanelData.Rows.Count AndAlso Not String.IsNullOrEmpty(PanelData.Rows(indiceFila).Cells("ID").Value.ToString()) Then
                    ' Obtener la fila correspondiente al índice
                    Dim filaSeleccionada As DataGridViewRow = PanelData.Rows(indiceFila)

                    ' Acceder a las celdas por nombre de columna
                    Dim valorCelda As Object = filaSeleccionada.Cells("ID").Value
                    verificar = valorCelda
                    Panel4.Parent = Me
                    Panel4.Visible = True
                    Panel1.Visible = False

                    Cerrar_Conexion()

                Else
                    MessageBox.Show("La fila seleccionada está vacía o el índice de fila está fuera de rango.")
                    PanelData.Visible = True
                End If


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            ' Mostrar alerta si la entrada no es correcta
            MessageBox.Show("La entrada no es válida. Operación cancelada.")
        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox7.Text.ToString = "1234567" Then
            Panel2.Visible = True
            Panel3.Visible = False
            TextBox7.Clear()
        Else
            MessageBox.Show("Clave Inválida")
            TextBox7.Clear()
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox9.Text.ToString = "1234567" Then
            Panel2.Visible = False
            Panel3.Visible = False
            MostrarEmpleado()
            PanelData.Visible = True
            Try
                Abrir_Conexion()
                Dim cmd = New SqlCommand("Eliminar_Empleado", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@ID", verificar)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()
                MostrarEmpleado()
                Panel1.Visible = True
                TextBox9.Clear()
                Panel4.Visible = False


            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Clave inválida")
            TextBox9.Clear()
            TextBox1.Clear()
            Panel4.Visible = False
            PanelData.Visible = True
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel4.Visible = False
        PanelData.Visible = True
        TextBox9.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = True
        Panel2.Visible = False
        PanelData.Visible = True
        TextBox8.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub
End Class