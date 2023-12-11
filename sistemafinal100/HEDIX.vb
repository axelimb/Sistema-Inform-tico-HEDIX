Imports System.Data.SqlClient
Imports System.Threading

Public Class HEDIX
    Dim total As Integer
    Dim Usuario As String

    Sub Listado()
        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label24.Text = ""
        Label25.Text = ""
        Try
            ' Abrir la conexión
            Abrir_Conexion()

            ' Crear un nuevo comando SQL con el procedimiento almacenado
            Dim cmd As New SqlCommand("TotalRegistrosHelados", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ejecutar el comando y obtener los resultados
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Leer los resultados
            While reader.Read()
                Dim tipoHelado As String = reader.GetString(0)
                Dim total As Integer = reader.GetInt32(1)

                ' Mostrar los totales en los labels correspondientes
                Select Case tipoHelado
                    Case "PicoleAgua"
                        Label21.Text = total.ToString()
                    Case "Acai"
                        Label22.Text = total.ToString()
                    Case "Alfajor"
                        Label23.Text = total.ToString()
                    Case "PicoleLeche"
                        Label24.Text = total.ToString()
                    Case "HeladoNormal"
                        Label25.Text = total.ToString()
                End Select
            End While

            ' Cerrar el reader y la conexión
            reader.Close()
            Cerrar_Conexion()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Abrir_Conexion()
        Dim consulta As String = "SELECT * FROM Empleados WHERE CedulaParaguaya = '" & TextBox1.Text & "' and Contraseña = '" & TextBox2.Text & "'"
        Dim comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.HasRows Then
            TextBox2.Clear()
            Panel1.Visible = False
            Panel2.Visible = True
        Else
            MessageBox.Show("Nro de cédula o contraseña incorrecta")
        End If
        Cerrar_Conexion()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Parent = Me
        Label35.Text = ""
        Timer1.Start()
        Timer1.Interval = 1000

        Panel1.Visible = False
        Panel5.Parent = Me
        Panel5.Visible = True
        CargarCompradoresEnComboBox()
        Listado()
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Panel2.Visible = False
        Panel3.Visible = False
        Label33.Text = ""
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(30)
        Label35.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Panel5.Visible = False
            Panel1.Visible = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        registrouser.ShowDialog()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub MantenimientoDeHeladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeHeladosToolStripMenuItem.Click
        Panel4.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Visible = False
        Panel4.Visible = True
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()

    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Nombre As String
        Dim Apellido As String
        Try
            InsertarDatos("PicoleAgua", TextBox3.Text, Usuario)
            InsertarDatos("PicoleLeche", TextBox4.Text, Usuario)
            InsertarDatos("Alfajor", TextBox5.Text, Usuario)
            InsertarDatos("Acai", TextBox6.Text, Usuario)
            InsertarDatos("HeladoNormal", TextBox7.Text, empleado(TextBox1.Text))
            Panel3.Visible = False
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            Listado()
            Panel4.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListaDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEmpleadosToolStripMenuItem.Click
        Listar_Empleados.ShowDialog()
    End Sub

    Private Sub AñadirCompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirCompradoresToolStripMenuItem.Click
        FormComprador.ShowDialog()
    End Sub

    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        ListarClientes.ShowDialog()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    Sub sumar()
        Dim Cagua As Integer = If(String.IsNullOrEmpty(TextBox8.Text), 0, Integer.Parse(TextBox8.Text))
        Dim Cleche As Integer = If(String.IsNullOrEmpty(TextBox9.Text), 0, Integer.Parse(TextBox9.Text))
        Dim Calfajor As Integer = If(String.IsNullOrEmpty(TextBox10.Text), 0, Integer.Parse(TextBox10.Text))
        Dim Cacai As Integer = If(String.IsNullOrEmpty(TextBox11.Text), 0, Integer.Parse(TextBox11.Text))
        Dim Chelado As Integer = If(String.IsNullOrEmpty(TextBox12.Text), 0, Integer.Parse(TextBox12.Text))

        Dim Pagua As Integer = 2000
        Dim Pleche As Integer = 3000
        Dim Palfajor As Integer = 5000
        Dim Pacai As Integer = 10000
        Dim Phelado As Integer = 35000

        total = ((Pagua * Cagua) + (Cleche * Pleche) + (Calfajor * Palfajor) + (Cacai * Pacai) + (Chelado * Phelado))
        Label33.Text = total.ToString()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sumar()

        If ComboBox1.SelectedItem <> "" Then
            Try
                Dim picoleagua = If(TextBox8.Text <> "", TextBox8.Text, 0)
                Dim picoleleche = If(TextBox9.Text <> "", TextBox9.Text, 0)
                Dim alfajor = If(TextBox10.Text <> "", TextBox10.Text, 0)
                Dim acai = If(TextBox11.Text <> "", TextBox11.Text, 0)
                Dim heladonormal = If(TextBox12.Text <> "", TextBox12.Text, 0)
                Dim cliente = ComboBox1.SelectedItem.ToString
                Dim empleadocargo = empleado(TextBox1.Text)
                Dim mensaje As String = String.Format("El monto total a pagar es: {0}", total)

                Dim cmd As New SqlCommand

                cmd = New SqlCommand("InsertarVentaYActualizarTotales", conexion)
                cmd.CommandType = 4



                cmd.Parameters.AddWithValue("@Total", total)
                cmd.Parameters.AddWithValue("@PicoleAgua", picoleagua)
                cmd.Parameters.AddWithValue("@PicoleLeche", picoleleche)
                cmd.Parameters.AddWithValue("@Alfajor", alfajor)
                cmd.Parameters.AddWithValue("@Acai", acai)
                cmd.Parameters.AddWithValue("@HeladoNormal", heladonormal)
                cmd.Parameters.AddWithValue("@Cliente", cliente)
                cmd.Parameters.AddWithValue("@Personal", empleadocargo)
                If MessageBox.Show(mensaje, "ATENCION!!!", MessageBoxButtons.OKCancel) Then
                    Abrir_Conexion()
                    cmd.ExecuteNonQuery()
                    TextBox8.Clear()
                    TextBox9.Clear()
                    TextBox10.Clear()
                    TextBox11.Clear()
                    TextBox12.Clear()
                    Listado()
                    CargarCompradoresEnComboBox()
                    Cerrar_Conexion()
                End If
                Label33.Text = ""
                TextBox8.Clear()
                TextBox9.Clear()
                TextBox10.Clear()
                TextBox11.Clear()
                TextBox12.Clear()
                Listado()
                CargarCompradoresEnComboBox()
                Cerrar_Conexion()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("El campo cliente es obligatorio")
        End If
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label33.Text = ""
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
    End Sub
    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HerramientasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HerramientasToolStripMenuItem.Click

    End Sub


    Sub CargarCompradoresEnComboBox()
        Try
            ' Limpiar el ComboBox antes de cargar los datos
            ComboBox1.Items.Clear()

            ' Conectar a la base de datos
            Abrir_Conexion()

            ' Consulta SQL para obtener los nombres de los compradores
            Dim consulta As String = "SELECT Nombre, Apellido FROM Compradores"

            ' Crear un comando SQL
            Dim comando As New SqlCommand(consulta, conexion)

            ' Ejecutar la consulta y leer los resultados
            Dim lector As SqlDataReader = comando.ExecuteReader()
            While lector.Read()
                ' Agregar el nombre y apellido al ComboBox
                ComboBox1.Items.Add($"{lector("Nombre")} {lector("Apellido")}")
            End While

            ' Cerrar la conexión
            Cerrar_Conexion()

        Catch ex As Exception
            MessageBox.Show("Error al cargar los compradores: " & ex.Message)
        End Try
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub HistorialDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeVentasToolStripMenuItem.Click
        Historial.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RegistrarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEmpleadoToolStripMenuItem.Click
        registrouser.ShowDialog()
    End Sub
End Class
