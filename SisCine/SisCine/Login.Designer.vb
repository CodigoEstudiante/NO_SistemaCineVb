<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña:"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(96, 71)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(164, 32)
        Me.txtusuario.TabIndex = 1
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(96, 119)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(164, 32)
        Me.txtcontraseña.TabIndex = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.login1
        Me.PictureBox5.Location = New System.Drawing.Point(290, 49)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(141, 119)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.WindowsApplication1.My.Resources.Resources.salir_black
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(331, 191)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(100, 40)
        Me.btnsalir.TabIndex = 2
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = Global.WindowsApplication1.My.Resources.Resources.inbox
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(161, 191)
        Me.btnaceptar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnaceptar.TabIndex = 2
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(92, 67)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(172, 41)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(92, 114)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 41)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(156, 186)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(110, 50)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(326, 186)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(110, 50)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(443, 253)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
