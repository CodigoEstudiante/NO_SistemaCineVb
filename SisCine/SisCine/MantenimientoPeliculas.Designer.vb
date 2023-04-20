<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenimientoPeliculas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbListaPeliculas = New System.Windows.Forms.ListBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PicPortada = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFormato = New System.Windows.Forms.ComboBox()
        Me.cboClasificacion = New System.Windows.Forms.ComboBox()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbListaPeliculas)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 375)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Peliculas"
        '
        'lbListaPeliculas
        '
        Me.lbListaPeliculas.FormattingEnabled = True
        Me.lbListaPeliculas.Location = New System.Drawing.Point(6, 17)
        Me.lbListaPeliculas.Name = "lbListaPeliculas"
        Me.lbListaPeliculas.Size = New System.Drawing.Size(195, 342)
        Me.lbListaPeliculas.TabIndex = 0
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(82, 31)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(144, 20)
        Me.txtTitulo.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.PicPortada)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboFormato)
        Me.GroupBox2.Controls.Add(Me.cboClasificacion)
        Me.GroupBox2.Controls.Add(Me.cboGenero)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDuracion)
        Me.GroupBox2.Controls.Add(Me.txtTitulo)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(489, 375)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Pelicula"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Portada:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(81, 196)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(122, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 249)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(93, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(122, 249)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(12, 249)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(93, 23)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'PicPortada
        '
        Me.PicPortada.Location = New System.Drawing.Point(232, 19)
        Me.PicPortada.Name = "PicPortada"
        Me.PicPortada.Size = New System.Drawing.Size(237, 329)
        Me.PicPortada.TabIndex = 7
        Me.PicPortada.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Formato:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Clasificación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Genero:"
        '
        'cboFormato
        '
        Me.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato.FormattingEnabled = True
        Me.cboFormato.Items.AddRange(New Object() {"Normal (2D)", "Especial (3D) "})
        Me.cboFormato.Location = New System.Drawing.Point(81, 164)
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.Size = New System.Drawing.Size(113, 21)
        Me.cboFormato.TabIndex = 5
        '
        'cboClasificacion
        '
        Me.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClasificacion.FormattingEnabled = True
        Me.cboClasificacion.Items.AddRange(New Object() {"APT", "14 PG", "18 +"})
        Me.cboClasificacion.Location = New System.Drawing.Point(82, 126)
        Me.cboClasificacion.Name = "cboClasificacion"
        Me.cboClasificacion.Size = New System.Drawing.Size(113, 21)
        Me.cboClasificacion.TabIndex = 5
        '
        'cboGenero
        '
        Me.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Acción", "Aventura", "Ciencia Ficción", "Comedia", "Documental", "Romantico", "Terror"})
        Me.cboGenero.Location = New System.Drawing.Point(81, 91)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(113, 21)
        Me.cboGenero.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Duracion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Titulo:"
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(82, 58)
        Me.txtDuracion.Mask = "0:00"
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(44, 20)
        Me.txtDuracion.TabIndex = 2
        '
        'MantenimientoPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(776, 408)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "MantenimientoPeliculas"
        Me.Text = "MantenimientoPeliculas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbListaPeliculas As System.Windows.Forms.ListBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents PicPortada As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFormato As System.Windows.Forms.ComboBox
    Friend WithEvents cboClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents cboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDuracion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
