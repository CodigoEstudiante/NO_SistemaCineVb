<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V1SeleccionPelicula
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
        Me.cboPelicula = New System.Windows.Forms.ComboBox()
        Me.cboSala = New System.Windows.Forms.ComboBox()
        Me.cboHora = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblAP = New System.Windows.Forms.Label()
        Me.lblAT = New System.Windows.Forms.Label()
        Me.PicPortada = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.PicPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPelicula
        '
        Me.cboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPelicula.FormattingEnabled = True
        Me.cboPelicula.Location = New System.Drawing.Point(80, 50)
        Me.cboPelicula.Name = "cboPelicula"
        Me.cboPelicula.Size = New System.Drawing.Size(164, 21)
        Me.cboPelicula.TabIndex = 0
        '
        'cboSala
        '
        Me.cboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSala.FormattingEnabled = True
        Me.cboSala.Location = New System.Drawing.Point(318, 50)
        Me.cboSala.Name = "cboSala"
        Me.cboSala.Size = New System.Drawing.Size(121, 21)
        Me.cboSala.TabIndex = 1
        '
        'cboHora
        '
        Me.cboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHora.FormattingEnabled = True
        Me.cboHora.Location = New System.Drawing.Point(496, 50)
        Me.cboHora.Name = "cboHora"
        Me.cboHora.Size = New System.Drawing.Size(121, 21)
        Me.cboHora.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pelicula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nro Sala:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(457, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(234, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Duración:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(242, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Género:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(218, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Clasificación:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(239, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Formato:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.BackColor = System.Drawing.Color.Silver
        Me.lblDuracion.Location = New System.Drawing.Point(293, 158)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(34, 13)
        Me.lblDuracion.TabIndex = 10
        Me.lblDuracion.Text = "dato1"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.BackColor = System.Drawing.Color.Silver
        Me.lblGenero.Location = New System.Drawing.Point(293, 179)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(34, 13)
        Me.lblGenero.TabIndex = 10
        Me.lblGenero.Text = "dato2"
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.BackColor = System.Drawing.Color.Silver
        Me.lblClasificacion.Location = New System.Drawing.Point(293, 201)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(34, 13)
        Me.lblClasificacion.TabIndex = 10
        Me.lblClasificacion.Text = "dato3"
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.BackColor = System.Drawing.Color.Silver
        Me.lblFormato.Location = New System.Drawing.Point(293, 223)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(34, 13)
        Me.lblFormato.TabIndex = 10
        Me.lblFormato.Text = "dato4"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(352, 261)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 25)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(512, 261)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(103, 25)
        Me.btnSiguiente.TabIndex = 13
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(349, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 31)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Label8"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(509, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 31)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(77, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 27)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label8"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(315, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 27)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Label8"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(493, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 27)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Label8"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(27, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 206)
        Me.Label13.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(633, 35)
        Me.Label14.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(222, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(213, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "SISTEMA DE CINE: Seleccion de Peliculas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(438, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Nro Asientos Preferenciales:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(442, 180)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Nro Asientos Tradicionales:"
        '
        'lblAP
        '
        Me.lblAP.AutoSize = True
        Me.lblAP.BackColor = System.Drawing.Color.Silver
        Me.lblAP.Location = New System.Drawing.Point(584, 158)
        Me.lblAP.Name = "lblAP"
        Me.lblAP.Size = New System.Drawing.Size(13, 13)
        Me.lblAP.TabIndex = 20
        Me.lblAP.Text = "0"
        '
        'lblAT
        '
        Me.lblAT.AutoSize = True
        Me.lblAT.BackColor = System.Drawing.Color.Silver
        Me.lblAT.Location = New System.Drawing.Point(584, 180)
        Me.lblAT.Name = "lblAT"
        Me.lblAT.Size = New System.Drawing.Size(13, 13)
        Me.lblAT.TabIndex = 20
        Me.lblAT.Text = "0"
        '
        'PicPortada
        '
        Me.PicPortada.BackColor = System.Drawing.Color.White
        Me.PicPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicPortada.Location = New System.Drawing.Point(30, 92)
        Me.PicPortada.Name = "PicPortada"
        Me.PicPortada.Size = New System.Drawing.Size(171, 200)
        Me.PicPortada.TabIndex = 11
        Me.PicPortada.TabStop = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Silver
        Me.Label18.Location = New System.Drawing.Point(213, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(196, 98)
        Me.Label18.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Black
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(213, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(196, 22)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Descripción de la Pelicula"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Silver
        Me.Label20.Location = New System.Drawing.Point(438, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 98)
        Me.Label20.TabIndex = 23
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Black
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(438, 125)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(177, 23)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Detalle de Asientos"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'V1SeleccionPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(633, 307)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblAT)
        Me.Controls.Add(Me.lblAP)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PicPortada)
        Me.Controls.Add(Me.lblFormato)
        Me.Controls.Add(Me.lblClasificacion)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboHora)
        Me.Controls.Add(Me.cboSala)
        Me.Controls.Add(Me.cboPelicula)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.MaximizeBox = False
        Me.Name = "V1SeleccionPelicula"
        Me.Text = "V1SeleccionPelicula"
        CType(Me.PicPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPelicula As System.Windows.Forms.ComboBox
    Friend WithEvents cboSala As System.Windows.Forms.ComboBox
    Friend WithEvents cboHora As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblClasificacion As System.Windows.Forms.Label
    Friend WithEvents lblFormato As System.Windows.Forms.Label
    Friend WithEvents PicPortada As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblAP As System.Windows.Forms.Label
    Friend WithEvents lblAT As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
