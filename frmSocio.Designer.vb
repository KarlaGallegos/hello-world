<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSocio
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
        Me.ttpNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttpConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttpAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttpModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttpEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttpSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpbSocio = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gpbSocio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Thistle
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttpNuevo, Me.ttpConsultar, Me.ttpAgregar, Me.ttpModificar, Me.ttpEliminar, Me.ttpSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(595, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ttpNuevo
        '
        Me.ttpNuevo.Name = "ttpNuevo"
        Me.ttpNuevo.Size = New System.Drawing.Size(74, 27)
        Me.ttpNuevo.Text = "Nuevo"
        '
        'ttpConsultar
        '
        Me.ttpConsultar.Name = "ttpConsultar"
        Me.ttpConsultar.Size = New System.Drawing.Size(97, 27)
        Me.ttpConsultar.Text = "Consultar"
        '
        'ttpAgregar
        '
        Me.ttpAgregar.Name = "ttpAgregar"
        Me.ttpAgregar.Size = New System.Drawing.Size(85, 27)
        Me.ttpAgregar.Text = "Agregar"
        '
        'ttpModificar
        '
        Me.ttpModificar.Name = "ttpModificar"
        Me.ttpModificar.Size = New System.Drawing.Size(95, 27)
        Me.ttpModificar.Text = "Modificar"
        '
        'ttpEliminar
        '
        Me.ttpEliminar.Name = "ttpEliminar"
        Me.ttpEliminar.Size = New System.Drawing.Size(85, 27)
        Me.ttpEliminar.Text = "Eliminar"
        '
        'ttpSalir
        '
        Me.ttpSalir.Name = "ttpSalir"
        Me.ttpSalir.Size = New System.Drawing.Size(56, 27)
        Me.ttpSalir.Text = "Salir"
        '
        'gpbSocio
        '
        Me.gpbSocio.Controls.Add(Me.txtTelefono)
        Me.gpbSocio.Controls.Add(Me.txtTitulo)
        Me.gpbSocio.Controls.Add(Me.txtDireccion)
        Me.gpbSocio.Controls.Add(Me.txtDirector)
        Me.gpbSocio.Controls.Add(Me.txtId)
        Me.gpbSocio.Controls.Add(Me.lblDuracion)
        Me.gpbSocio.Controls.Add(Me.lblAño)
        Me.gpbSocio.Controls.Add(Me.lblDirector)
        Me.gpbSocio.Controls.Add(Me.lblTitulo)
        Me.gpbSocio.Controls.Add(Me.lblId)
        Me.gpbSocio.Font = New System.Drawing.Font("Imprint MT Shadow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbSocio.Location = New System.Drawing.Point(51, 66)
        Me.gpbSocio.Name = "gpbSocio"
        Me.gpbSocio.Size = New System.Drawing.Size(439, 230)
        Me.gpbSocio.TabIndex = 1
        Me.gpbSocio.TabStop = False
        Me.gpbSocio.Text = "Peliculas"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(111, 186)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(301, 25)
        Me.txtTelefono.TabIndex = 13
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(111, 80)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(301, 25)
        Me.txtTitulo.TabIndex = 12
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(111, 149)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(301, 25)
        Me.txtDireccion.TabIndex = 11
        '
        'txtDirector
        '
        Me.txtDirector.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirector.Location = New System.Drawing.Point(111, 116)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(301, 25)
        Me.txtDirector.TabIndex = 9
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(111, 45)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(301, 25)
        Me.txtId.TabIndex = 8
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(6, 186)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(83, 23)
        Me.lblDuracion.TabIndex = 7
        Me.lblDuracion.Text = "Duración:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(6, 151)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(45, 23)
        Me.lblAño.TabIndex = 6
        Me.lblAño.Text = "Año:"
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(6, 116)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(75, 23)
        Me.lblDirector.TabIndex = 5
        Me.lblDirector.Text = "Director:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(6, 82)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(57, 23)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Título:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(6, 47)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(34, 23)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id: "
        '
        'frmSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(595, 358)
        Me.Controls.Add(Me.gpbSocio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSocio"
        Me.Text = "Socio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gpbSocio.ResumeLayout(False)
        Me.gpbSocio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ttpNuevo As ToolStripMenuItem
    Friend WithEvents ttpConsultar As ToolStripMenuItem
    Friend WithEvents ttpAgregar As ToolStripMenuItem
    Friend WithEvents ttpModificar As ToolStripMenuItem
    Friend WithEvents ttpEliminar As ToolStripMenuItem
    Friend WithEvents ttpSalir As ToolStripMenuItem
    Friend WithEvents gpbSocio As GroupBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblAño As Label
    Friend WithEvents lblDirector As Label
    Friend WithEvents lblTitulo As Label
End Class
