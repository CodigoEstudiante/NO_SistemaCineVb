<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V3SeleccionAsiento
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbTradicional = New System.Windows.Forms.GroupBox()
        Me.gbPreferencial = New System.Windows.Forms.GroupBox()
        Me.btnRetornar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNompelicula = New System.Windows.Forms.Label()
        Me.lblAsiTradiNum = New System.Windows.Forms.Label()
        Me.lblAsiPrefeNum = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegistrar.Location = New System.Drawing.Point(272, 437)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.cine
        Me.PictureBox1.Location = New System.Drawing.Point(27, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'gbTradicional
        '
        Me.gbTradicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTradicional.Location = New System.Drawing.Point(27, 98)
        Me.gbTradicional.Name = "gbTradicional"
        Me.gbTradicional.Size = New System.Drawing.Size(320, 150)
        Me.gbTradicional.TabIndex = 2
        Me.gbTradicional.TabStop = False
        '
        'gbPreferencial
        '
        Me.gbPreferencial.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPreferencial.Location = New System.Drawing.Point(27, 269)
        Me.gbPreferencial.Name = "gbPreferencial"
        Me.gbPreferencial.Size = New System.Drawing.Size(320, 150)
        Me.gbPreferencial.TabIndex = 2
        Me.gbPreferencial.TabStop = False
        '
        'btnRetornar
        '
        Me.btnRetornar.Location = New System.Drawing.Point(161, 437)
        Me.btnRetornar.Name = "btnRetornar"
        Me.btnRetornar.Size = New System.Drawing.Size(75, 23)
        Me.btnRetornar.TabIndex = 3
        Me.btnRetornar.Text = "Retornar"
        Me.btnRetornar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Asientos Tradicionales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Asientos Preferenciales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pelicula:"
        '
        'lblNompelicula
        '
        Me.lblNompelicula.AutoSize = True
        Me.lblNompelicula.BackColor = System.Drawing.Color.Black
        Me.lblNompelicula.ForeColor = System.Drawing.Color.White
        Me.lblNompelicula.Location = New System.Drawing.Point(81, 9)
        Me.lblNompelicula.Name = "lblNompelicula"
        Me.lblNompelicula.Size = New System.Drawing.Size(65, 13)
        Me.lblNompelicula.TabIndex = 6
        Me.lblNompelicula.Text = "Nompelicula"
        '
        'lblAsiTradiNum
        '
        Me.lblAsiTradiNum.AutoSize = True
        Me.lblAsiTradiNum.Location = New System.Drawing.Point(141, 85)
        Me.lblAsiTradiNum.Name = "lblAsiTradiNum"
        Me.lblAsiTradiNum.Size = New System.Drawing.Size(13, 13)
        Me.lblAsiTradiNum.TabIndex = 7
        Me.lblAsiTradiNum.Text = "0"
        '
        'lblAsiPrefeNum
        '
        Me.lblAsiPrefeNum.AutoSize = True
        Me.lblAsiPrefeNum.Location = New System.Drawing.Point(146, 254)
        Me.lblAsiPrefeNum.Name = "lblAsiPrefeNum"
        Me.lblAsiPrefeNum.Size = New System.Drawing.Size(13, 13)
        Me.lblAsiPrefeNum.TabIndex = 7
        Me.lblAsiPrefeNum.Text = "0"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(269, 434)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label4"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(158, 434)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(371, 32)
        Me.Label4.TabIndex = 9
        '
        'V3SeleccionAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(371, 470)
        Me.Controls.Add(Me.lblAsiPrefeNum)
        Me.Controls.Add(Me.lblAsiTradiNum)
        Me.Controls.Add(Me.lblNompelicula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRetornar)
        Me.Controls.Add(Me.gbPreferencial)
        Me.Controls.Add(Me.gbTradicional)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.Name = "V3SeleccionAsiento"
        Me.Text = "V3SeleccionAsiento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbTradicional As System.Windows.Forms.GroupBox
    Friend WithEvents gbPreferencial As System.Windows.Forms.GroupBox
    Friend WithEvents btnRetornar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNompelicula As System.Windows.Forms.Label
    Friend WithEvents lblAsiTradiNum As System.Windows.Forms.Label
    Friend WithEvents lblAsiPrefeNum As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
