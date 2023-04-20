<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPeliculas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.cbogenero = New System.Windows.Forms.ComboBox()
        Me.cboclasificacion = New System.Windows.Forms.ComboBox()
        Me.cboformato = New System.Windows.Forms.ComboBox()
        Me.picimagen = New System.Windows.Forms.PictureBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnretornar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        Me.txtDuracion = New System.Windows.Forms.MaskedTextBox()
        Me.gbportada = New System.Windows.Forms.GroupBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        CType(Me.picimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdatos.SuspendLayout()
        Me.gbportada.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Titulo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Duración:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Genero:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Clasificación:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Formato:"
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(80, 26)
        Me.txttitulo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(131, 26)
        Me.txttitulo.TabIndex = 1
        '
        'cbogenero
        '
        Me.cbogenero.FormattingEnabled = True
        Me.cbogenero.Items.AddRange(New Object() {"Acción", "Aventura", "Ciencia Ficción", "Comedia", "Documental", "Romantico", "Terror"})
        Me.cbogenero.Location = New System.Drawing.Point(80, 112)
        Me.cbogenero.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbogenero.Name = "cbogenero"
        Me.cbogenero.Size = New System.Drawing.Size(131, 28)
        Me.cbogenero.TabIndex = 2
        '
        'cboclasificacion
        '
        Me.cboclasificacion.FormattingEnabled = True
        Me.cboclasificacion.Items.AddRange(New Object() {"APT", "14 PG", "18 +"})
        Me.cboclasificacion.Location = New System.Drawing.Point(80, 156)
        Me.cboclasificacion.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboclasificacion.Name = "cboclasificacion"
        Me.cboclasificacion.Size = New System.Drawing.Size(131, 28)
        Me.cboclasificacion.TabIndex = 2
        '
        'cboformato
        '
        Me.cboformato.FormattingEnabled = True
        Me.cboformato.Items.AddRange(New Object() {"Normal (2D)", "Especial (3D)"})
        Me.cboformato.Location = New System.Drawing.Point(80, 199)
        Me.cboformato.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboformato.Name = "cboformato"
        Me.cboformato.Size = New System.Drawing.Size(131, 28)
        Me.cboformato.TabIndex = 2
        '
        'picimagen
        '
        Me.picimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picimagen.Location = New System.Drawing.Point(5, 22)
        Me.picimagen.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picimagen.Name = "picimagen"
        Me.picimagen.Size = New System.Drawing.Size(236, 243)
        Me.picimagen.TabIndex = 3
        Me.picimagen.TabStop = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(8, 282)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(100, 27)
        Me.btnnuevo.TabIndex = 4
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnretornar
        '
        Me.btnretornar.Location = New System.Drawing.Point(142, 282)
        Me.btnretornar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnretornar.Name = "btnretornar"
        Me.btnretornar.Size = New System.Drawing.Size(100, 27)
        Me.btnretornar.TabIndex = 4
        Me.btnretornar.Text = "Retornar"
        Me.btnretornar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(8, 282)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(100, 27)
        Me.btnguardar.TabIndex = 4
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(142, 282)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(100, 27)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.txtDuracion)
        Me.gbdatos.Controls.Add(Me.cboformato)
        Me.gbdatos.Controls.Add(Me.cboclasificacion)
        Me.gbdatos.Controls.Add(Me.cbogenero)
        Me.gbdatos.Controls.Add(Me.txttitulo)
        Me.gbdatos.Controls.Add(Me.Label6)
        Me.gbdatos.Controls.Add(Me.Label3)
        Me.gbdatos.Controls.Add(Me.Label5)
        Me.gbdatos.Controls.Add(Me.Label2)
        Me.gbdatos.Controls.Add(Me.Label4)
        Me.gbdatos.Location = New System.Drawing.Point(4, 12)
        Me.gbdatos.Margin = New System.Windows.Forms.Padding(2)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Padding = New System.Windows.Forms.Padding(2)
        Me.gbdatos.Size = New System.Drawing.Size(227, 247)
        Me.gbdatos.TabIndex = 5
        Me.gbdatos.TabStop = False
        Me.gbdatos.Text = "Datos"
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(80, 70)
        Me.txtDuracion.Mask = "0:00"
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(33, 26)
        Me.txtDuracion.TabIndex = 3
        '
        'gbportada
        '
        Me.gbportada.Controls.Add(Me.btnExaminar)
        Me.gbportada.Controls.Add(Me.picimagen)
        Me.gbportada.Location = New System.Drawing.Point(265, 12)
        Me.gbportada.Margin = New System.Windows.Forms.Padding(2)
        Me.gbportada.Name = "gbportada"
        Me.gbportada.Padding = New System.Windows.Forms.Padding(2)
        Me.gbportada.Size = New System.Drawing.Size(246, 302)
        Me.gbportada.TabIndex = 6
        Me.gbportada.TabStop = False
        Me.gbportada.Text = "Portada"
        '
        'btnExaminar
        '
        Me.btnExaminar.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.Location = New System.Drawing.Point(181, 271)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(60, 26)
        Me.btnExaminar.TabIndex = 4
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'AgregarPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(528, 328)
        Me.Controls.Add(Me.gbportada)
        Me.Controls.Add(Me.gbdatos)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnretornar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "AgregarPeliculas"
        Me.Text = "AgregarPeliculas"
        CType(Me.picimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.gbportada.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttitulo As System.Windows.Forms.TextBox
    Friend WithEvents cbogenero As System.Windows.Forms.ComboBox
    Friend WithEvents cboclasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents cboformato As System.Windows.Forms.ComboBox
    Friend WithEvents picimagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnretornar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents gbdatos As System.Windows.Forms.GroupBox
    Friend WithEvents gbportada As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents txtDuracion As System.Windows.Forms.MaskedTextBox
End Class
