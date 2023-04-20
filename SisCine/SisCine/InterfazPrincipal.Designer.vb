<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarCateleraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSala1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSala2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprarBoletoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalasToolStripMenuItem, Me.PeliculasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalasToolStripMenuItem
        '
        Me.SalasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarCateleraToolStripMenuItem, Me.VerSala1ToolStripMenuItem, Me.VerSala2ToolStripMenuItem})
        Me.SalasToolStripMenuItem.Name = "SalasToolStripMenuItem"
        Me.SalasToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.SalasToolStripMenuItem.Text = "Control Salas"
        '
        'AsignarCateleraToolStripMenuItem
        '
        Me.AsignarCateleraToolStripMenuItem.Name = "AsignarCateleraToolStripMenuItem"
        Me.AsignarCateleraToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AsignarCateleraToolStripMenuItem.Text = "Asignar Catelera"
        '
        'VerSala1ToolStripMenuItem
        '
        Me.VerSala1ToolStripMenuItem.Name = "VerSala1ToolStripMenuItem"
        Me.VerSala1ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.VerSala1ToolStripMenuItem.Text = "Ver Sala 1"
        '
        'VerSala2ToolStripMenuItem
        '
        Me.VerSala2ToolStripMenuItem.Name = "VerSala2ToolStripMenuItem"
        Me.VerSala2ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.VerSala2ToolStripMenuItem.Text = "Ver Sala2"
        '
        'PeliculasToolStripMenuItem
        '
        Me.PeliculasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPeliculaToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.VerTodasToolStripMenuItem})
        Me.PeliculasToolStripMenuItem.Name = "PeliculasToolStripMenuItem"
        Me.PeliculasToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PeliculasToolStripMenuItem.Text = "Peliculas"
        '
        'AgregarPeliculaToolStripMenuItem
        '
        Me.AgregarPeliculaToolStripMenuItem.Name = "AgregarPeliculaToolStripMenuItem"
        Me.AgregarPeliculaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AgregarPeliculaToolStripMenuItem.Text = "Agregar Pelicula"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'VerTodasToolStripMenuItem
        '
        Me.VerTodasToolStripMenuItem.Name = "VerTodasToolStripMenuItem"
        Me.VerTodasToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.VerTodasToolStripMenuItem.Text = "Ver Todas"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprarBoletoToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ComprarBoletoToolStripMenuItem
        '
        Me.ComprarBoletoToolStripMenuItem.Name = "ComprarBoletoToolStripMenuItem"
        Me.ComprarBoletoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ComprarBoletoToolStripMenuItem.Text = "Comprar Boleto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InterfazPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 591)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InterfazPrincipal"
        Me.Text = "titulo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeliculasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarPeliculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTodasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarCateleraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerSala1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerSala2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprarBoletoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
