<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarClientes
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ListarClientes))
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PanelData = New DataGridView()
        Eliminar = New DataGridViewImageColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PanelData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(54, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(709, 49)
        Panel1.TabIndex = 1
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
        ' Panel2
        ' 
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(95, 137)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(635, 234)
        Panel2.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(44, 195)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 14
        Button4.Text = "Cancelar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(508, 192)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 13
        Button3.Text = "Guardar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(571, 246)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 12
        Button2.Text = "Guardar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(58, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 11
        Button1.Text = "Cancelar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(498, 163)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(498, 134)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(498, 105)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(498, 76)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(498, 47)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(51, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 22)
        Label6.TabIndex = 5
        Label6.Text = "Cédula"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(51, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 22)
        Label5.TabIndex = 4
        Label5.Text = "Numero de Teléfono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(51, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 22)
        Label4.TabIndex = 3
        Label4.Text = "Dirección"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(51, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 22)
        Label3.TabIndex = 2
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(51, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 22)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(176, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 19)
        Label1.TabIndex = 0
        Label1.Text = "Formulario de Actualización de datos de cliente"
        ' 
        ' PanelData
        ' 
        PanelData.AllowUserToAddRows = False
        PanelData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PanelData.Columns.AddRange(New DataGridViewColumn() {Eliminar})
        PanelData.Location = New Point(54, 121)
        PanelData.Name = "PanelData"
        PanelData.ReadOnly = True
        PanelData.RowTemplate.Height = 25
        PanelData.Size = New Size(709, 269)
        PanelData.TabIndex = 3
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = ""
        Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), Image)
        Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom
        Eliminar.Name = "Eliminar"
        Eliminar.ReadOnly = True
        ' 
        ' ListarClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PanelData)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ListarClientes"
        Text = "ListarClientes"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PanelData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelData As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
