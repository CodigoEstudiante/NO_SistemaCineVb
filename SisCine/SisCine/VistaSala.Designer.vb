<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaSala
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbPreferencial = New System.Windows.Forms.GroupBox()
        Me.gbTradicional = New System.Windows.Forms.GroupBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnVaciarSala = New System.Windows.Forms.Button()
        Me.cboPeliculas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.cine
        Me.PictureBox1.Location = New System.Drawing.Point(28, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Asientos Preferenciales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Asientos Tradicionales"
        '
        'gbPreferencial
        '
        Me.gbPreferencial.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPreferencial.Location = New System.Drawing.Point(28, 319)
        Me.gbPreferencial.Name = "gbPreferencial"
        Me.gbPreferencial.Size = New System.Drawing.Size(320, 150)
        Me.gbPreferencial.TabIndex = 8
        Me.gbPreferencial.TabStop = False
        '
        'gbTradicional
        '
        Me.gbTradicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTradicional.Location = New System.Drawing.Point(28, 148)
        Me.gbTradicional.Name = "gbTradicional"
        Me.gbTradicional.Size = New System.Drawing.Size(320, 150)
        Me.gbTradicional.TabIndex = 9
        Me.gbTradicional.TabStop = False
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(255, 12)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 12
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnVaciarSala
        '
        Me.btnVaciarSala.Location = New System.Drawing.Point(50, 60)
        Me.btnVaciarSala.Name = "btnVaciarSala"
        Me.btnVaciarSala.Size = New System.Drawing.Size(280, 24)
        Me.btnVaciarSala.TabIndex = 13
        Me.btnVaciarSala.Text = "Eliminar Esta Cartelera"
        Me.btnVaciarSala.UseVisualStyleBackColor = True
        '
        'cboPeliculas
        '
        Me.cboPeliculas.FormattingEnabled = True
        Me.cboPeliculas.Location = New System.Drawing.Point(88, 14)
        Me.cboPeliculas.Name = "cboPeliculas"
        Me.cboPeliculas.Size = New System.Drawing.Size(161, 21)
        Me.cboPeliculas.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Pelicula:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Hora de Inicio:"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(181, 41)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(49, 13)
        Me.lblHora.TabIndex = 17
        Me.lblHora.Text = "00:00:00"
        '
        'VistaSala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 476)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPeliculas)
        Me.Controls.Add(Me.btnVaciarSala)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbPreferencial)
        Me.Controls.Add(Me.gbTradicional)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "VistaSala"
        Me.Text = "VistaSala"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbPreferencial As System.Windows.Forms.GroupBox
    Friend WithEvents gbTradicional As System.Windows.Forms.GroupBox
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnVaciarSala As System.Windows.Forms.Button
    Friend WithEvents cboPeliculas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
End Class
