<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listar_Empleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Listar_Empleados))
        PanelData = New DataGridView()
        Eliminar = New DataGridViewImageColumn()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        TextBox7 = New TextBox()
        Label8 = New Label()
        Panel4 = New Panel()
        TextBox9 = New TextBox()
        Button5 = New Button()
        Button4 = New Button()
        Label9 = New Label()
        Panel2 = New Panel()
        Button6 = New Button()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox8 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(PanelData, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelData
        ' 
        PanelData.AllowUserToAddRows = False
        PanelData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PanelData.Columns.AddRange(New DataGridViewColumn() {Eliminar})
        PanelData.Location = New Point(46, 100)
        PanelData.Name = "PanelData"
        PanelData.Size = New Size(709, 217)
        PanelData.TabIndex = 0
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = ""
        Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), Image)
        Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom
        Eliminar.Name = "Eliminar"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(46, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(709, 49)
        Panel1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(106, 14)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(581, 23)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(9, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(143, 92)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(374, 197)
        Panel3.TabIndex = 16
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(36, 159)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 3
        Button3.Text = "Cancelar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(290, 159)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Aceptar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(115, 74)
        TextBox7.Name = "TextBox7"
        TextBox7.PasswordChar = "*"c
        TextBox7.Size = New Size(144, 23)
        TextBox7.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(42, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(310, 15)
        Label8.TabIndex = 0
        Label8.Text = "Ingrese clave de de registro de usuario para editar registro"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TextBox9)
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(152, 92)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(374, 197)
        Panel4.TabIndex = 4
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(140, 79)
        TextBox9.Name = "TextBox9"
        TextBox9.PasswordChar = "*"c
        TextBox9.Size = New Size(122, 23)
        TextBox9.TabIndex = 3
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(18, 157)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 2
        Button5.Text = "Cancelar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(290, 159)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 1
        Button4.Text = "Guadar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(51, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(283, 15)
        Label9.TabIndex = 0
        Label9.Text = "Ingrese clave de administrador para eliminar registro"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ScrollBar
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(216, 67)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(404, 317)
        Panel2.TabIndex = 3
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(48, 279)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 16
        Button6.Text = "Cancelar"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(289, 279)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 15
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(277, 217)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(277, 182)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(277, 153)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(277, 124)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(277, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(277, 61)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(48, 225)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 15)
        Label7.TabIndex = 6
        Label7.Text = "Cree una contraseña"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(48, 187)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 15)
        Label6.TabIndex = 5
        Label6.Text = "Número de Cédula"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 4
        Label5.Text = "Dirección"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 3
        Label4.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(48, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 19)
        Label1.TabIndex = 0
        Label1.Text = "Formulario de actualización de datos del usuario"
        ' 
        ' Listar_Empleados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(798, 450)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PanelData)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Listar_Empleados"
        Text = "Listar_Empleados"
        CType(PanelData, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button6 As Button
End Class
