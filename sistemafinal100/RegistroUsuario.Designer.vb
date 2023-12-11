<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrouser
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(registrouser))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ScrollBar
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(216, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(404, 413)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(136, 41)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(154, 104)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(288, 365)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 15
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(275, 336)
        TextBox7.Name = "TextBox7"
        TextBox7.PasswordChar = "*"c
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(275, 303)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(275, 268)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(275, 239)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(275, 210)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(275, 180)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(275, 147)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(46, 344)
        Label8.Name = "Label8"
        Label8.Size = New Size(223, 18)
        Label8.TabIndex = 7
        Label8.Text = "Ingrese Clave de Registro de Usuario"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(46, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 18)
        Label7.TabIndex = 6
        Label7.Text = "Cree una contraseña"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(46, 273)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 18)
        Label6.TabIndex = 5
        Label6.Text = "Número de Cédula"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(46, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 18)
        Label5.TabIndex = 4
        Label5.Text = "Dirección"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(46, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 18)
        Label4.TabIndex = 3
        Label4.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(46, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 18)
        Label3.TabIndex = 2
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(46, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 18)
        Label2.TabIndex = 1
        Label2.Text = "Nombre "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(97, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 19)
        Label1.TabIndex = 0
        Label1.Text = "Formulario de Registro de Usuario"
        ' 
        ' registrouser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "registrouser"
        Text = "registrouser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
