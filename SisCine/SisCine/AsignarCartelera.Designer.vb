<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarCartelera
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
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        Me.txtminuto = New System.Windows.Forms.TextBox()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.txtHoraFin = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSala = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPelicula = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picPortada = New System.Windows.Forms.PictureBox()
        Me.dgvListaCartelera = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbdatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaCartelera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbdatos)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 284)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignar un Cartelera"
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.txtminuto)
        Me.gbdatos.Controls.Add(Me.txthora)
        Me.gbdatos.Controls.Add(Me.txtHoraFin)
        Me.gbdatos.Controls.Add(Me.txtDuracion)
        Me.gbdatos.Controls.Add(Me.Label5)
        Me.gbdatos.Controls.Add(Me.btnValidar)
        Me.gbdatos.Controls.Add(Me.Label4)
        Me.gbdatos.Controls.Add(Me.Label3)
        Me.gbdatos.Controls.Add(Me.cboSala)
        Me.gbdatos.Controls.Add(Me.Label2)
        Me.gbdatos.Controls.Add(Me.Label1)
        Me.gbdatos.Controls.Add(Me.cboPelicula)
        Me.gbdatos.Controls.Add(Me.Label6)
        Me.gbdatos.Location = New System.Drawing.Point(7, 14)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(267, 193)
        Me.gbdatos.TabIndex = 15
        Me.gbdatos.TabStop = False
        '
        'txtminuto
        '
        Me.txtminuto.Location = New System.Drawing.Point(92, 130)
        Me.txtminuto.Name = "txtminuto"
        Me.txtminuto.Size = New System.Drawing.Size(20, 20)
        Me.txtminuto.TabIndex = 13
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(69, 130)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(20, 20)
        Me.txthora.TabIndex = 13
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Location = New System.Drawing.Point(69, 163)
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(34, 20)
        Me.txtHoraFin.TabIndex = 12
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(69, 91)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.ReadOnly = True
        Me.txtDuracion.Size = New System.Drawing.Size(48, 20)
        Me.txtDuracion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Duración:"
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(148, 133)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(51, 50)
        Me.btnValidar.TabIndex = 9
        Me.btnValidar.Text = "Validar Hora"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hora Fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hora Inicio:"
        '
        'cboSala
        '
        Me.cboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSala.FormattingEnabled = True
        Me.cboSala.Location = New System.Drawing.Point(69, 22)
        Me.cboSala.Name = "cboSala"
        Me.cboSala.Size = New System.Drawing.Size(103, 21)
        Me.cboSala.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sala:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pelicula:"
        '
        'cboPelicula
        '
        Me.cboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPelicula.FormattingEnabled = True
        Me.cboPelicula.Location = New System.Drawing.Point(69, 58)
        Me.cboPelicula.Name = "cboPelicula"
        Me.cboPelicula.Size = New System.Drawing.Size(152, 21)
        Me.cboPelicula.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = ":"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(137, 214)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 59)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(34, 214)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 59)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(34, 214)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 59)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picPortada)
        Me.GroupBox2.Location = New System.Drawing.Point(304, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 234)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Portada"
        '
        'picPortada
        '
        Me.picPortada.Location = New System.Drawing.Point(7, 15)
        Me.picPortada.Name = "picPortada"
        Me.picPortada.Size = New System.Drawing.Size(167, 212)
        Me.picPortada.TabIndex = 0
        Me.picPortada.TabStop = False
        '
        'dgvListaCartelera
        '
        Me.dgvListaCartelera.AllowUserToAddRows = False
        Me.dgvListaCartelera.AllowUserToDeleteRows = False
        Me.dgvListaCartelera.AllowUserToResizeColumns = False
        Me.dgvListaCartelera.AllowUserToResizeRows = False
        Me.dgvListaCartelera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCartelera.Location = New System.Drawing.Point(11, 302)
        Me.dgvListaCartelera.MultiSelect = False
        Me.dgvListaCartelera.Name = "dgvListaCartelera"
        Me.dgvListaCartelera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaCartelera.Size = New System.Drawing.Size(509, 188)
        Me.dgvListaCartelera.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.txtCod)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 507)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 50)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Eliminar Cartelera"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(184, 18)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(134, 26)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar Cartelera"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(115, 22)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(49, 20)
        Me.txtCod.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Código Cartelera:"
        '
        'AsignarCartelera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(543, 566)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvListaCartelera)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "AsignarCartelera"
        Me.Text = "AsignarCartelera"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picPortada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaCartelera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnValidar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSala As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPelicula As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents picPortada As System.Windows.Forms.PictureBox
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHoraFin As System.Windows.Forms.TextBox
    Friend WithEvents txtminuto As System.Windows.Forms.TextBox
    Friend WithEvents txthora As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbdatos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListaCartelera As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
