<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        img_Usuario = New PictureBox()
        img_passw = New PictureBox()
        txt_user = New TextBox()
        txt_pass = New TextBox()
        Label1 = New Label()
        btn_inicio = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(img_Usuario, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_passw, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' img_Usuario
        ' 
        img_Usuario.Image = CType(resources.GetObject("img_Usuario.Image"), Image)
        img_Usuario.Location = New Point(199, 226)
        img_Usuario.Name = "img_Usuario"
        img_Usuario.Size = New Size(50, 50)
        img_Usuario.SizeMode = PictureBoxSizeMode.StretchImage
        img_Usuario.TabIndex = 0
        img_Usuario.TabStop = False
        ' 
        ' img_passw
        ' 
        img_passw.Image = My.Resources.Resources.passw
        img_passw.Location = New Point(199, 306)
        img_passw.Name = "img_passw"
        img_passw.Size = New Size(50, 50)
        img_passw.SizeMode = PictureBoxSizeMode.StretchImage
        img_passw.TabIndex = 1
        img_passw.TabStop = False
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(260, 237)
        txt_user.Name = "txt_user"
        txt_user.PlaceholderText = "Usuario"
        txt_user.Size = New Size(200, 27)
        txt_user.TabIndex = 2
        txt_user.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_pass
        ' 
        txt_pass.Location = New Point(260, 320)
        txt_pass.Name = "txt_pass"
        txt_pass.PlaceholderText = "Contraseña"
        txt_pass.Size = New Size(200, 27)
        txt_pass.TabIndex = 3
        txt_pass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(200, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 59)
        Label1.TabIndex = 4
        Label1.Text = "Inicia  Sesion"
        ' 
        ' btn_inicio
        ' 
        btn_inicio.BackColor = Color.RoyalBlue
        btn_inicio.Cursor = Cursors.Hand
        btn_inicio.FlatStyle = FlatStyle.Flat
        btn_inicio.Font = New Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_inicio.ForeColor = Color.Transparent
        btn_inicio.Location = New Point(200, 428)
        btn_inicio.Name = "btn_inicio"
        btn_inicio.Size = New Size(294, 65)
        btn_inicio.TabIndex = 5
        btn_inicio.Text = "Entrar"
        btn_inicio.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 62)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.engranes
        PictureBox2.Location = New Point(0, 488)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(666, 375)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(655, 853)
        Controls.Add(btn_inicio)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(txt_pass)
        Controls.Add(txt_user)
        Controls.Add(img_passw)
        Controls.Add(img_Usuario)
        DoubleBuffered = True
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        Opacity = 0.85R
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestor de Negocio"
        CType(img_Usuario, ComponentModel.ISupportInitialize).EndInit()
        CType(img_passw, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents img_Usuario As PictureBox
    Friend WithEvents img_passw As PictureBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_inicio As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
