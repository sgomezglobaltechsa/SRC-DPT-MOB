﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmModuloProduccion
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmbClientes = New System.Windows.Forms.ComboBox
        Me.btnComenzar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.lblOperacion = New System.Windows.Forms.Label
        Me.lblProducto = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblPalletContenedora = New System.Windows.Forms.Label
        Me.txtPalletContenedora = New System.Windows.Forms.TextBox
        Me.lblUbicacionOrigen = New System.Windows.Forms.Label
        Me.txtUbicacionOrigen = New System.Windows.Forms.TextBox
        Me.txtZonaPreparacion = New System.Windows.Forms.TextBox
        Me.lblZonaPreparacion = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitulo.Location = New System.Drawing.Point(0, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(240, 19)
        Me.lblTitulo.Text = "Seleccione Cliente:"
        '
        'cmbClientes
        '
        Me.cmbClientes.Location = New System.Drawing.Point(0, 23)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(240, 22)
        Me.cmbClientes.TabIndex = 1
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(0, 249)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(120, 20)
        Me.btnComenzar.TabIndex = 2
        Me.btnComenzar.Text = "F1) Comenzar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(126, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 20)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "F2) Cancelar"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(0, 271)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 20)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "F3) Salir"
        '
        'lblOperacion
        '
        Me.lblOperacion.BackColor = System.Drawing.SystemColors.Control
        Me.lblOperacion.Location = New System.Drawing.Point(0, 47)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(240, 20)
        Me.lblOperacion.Text = "Operación: "
        '
        'lblProducto
        '
        Me.lblProducto.Location = New System.Drawing.Point(0, 69)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(94, 21)
        Me.lblProducto.Text = "Cod. Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.Location = New System.Drawing.Point(88, 69)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(152, 21)
        Me.txtProducto.TabIndex = 8
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescripcion.Location = New System.Drawing.Point(0, 92)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(240, 21)
        Me.lblDescripcion.Text = "Descripcion del Producto"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPalletContenedora
        '
        Me.lblPalletContenedora.Location = New System.Drawing.Point(0, 114)
        Me.lblPalletContenedora.Name = "lblPalletContenedora"
        Me.lblPalletContenedora.Size = New System.Drawing.Size(120, 20)
        Me.lblPalletContenedora.Text = "Pallet/Contenedora:"
        '
        'txtPalletContenedora
        '
        Me.txtPalletContenedora.Location = New System.Drawing.Point(116, 114)
        Me.txtPalletContenedora.Name = "txtPalletContenedora"
        Me.txtPalletContenedora.Size = New System.Drawing.Size(124, 21)
        Me.txtPalletContenedora.TabIndex = 11
        '
        'lblUbicacionOrigen
        '
        Me.lblUbicacionOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblUbicacionOrigen.Location = New System.Drawing.Point(0, 137)
        Me.lblUbicacionOrigen.Name = "lblUbicacionOrigen"
        Me.lblUbicacionOrigen.Size = New System.Drawing.Size(240, 20)
        Me.lblUbicacionOrigen.Text = "Ubicacion: DP1-1-1-50"
        '
        'txtUbicacionOrigen
        '
        Me.txtUbicacionOrigen.Location = New System.Drawing.Point(0, 159)
        Me.txtUbicacionOrigen.Name = "txtUbicacionOrigen"
        Me.txtUbicacionOrigen.Size = New System.Drawing.Size(240, 21)
        Me.txtUbicacionOrigen.TabIndex = 13
        '
        'txtZonaPreparacion
        '
        Me.txtZonaPreparacion.Location = New System.Drawing.Point(0, 211)
        Me.txtZonaPreparacion.Name = "txtZonaPreparacion"
        Me.txtZonaPreparacion.Size = New System.Drawing.Size(240, 21)
        Me.txtZonaPreparacion.TabIndex = 15
        '
        'lblZonaPreparacion
        '
        Me.lblZonaPreparacion.BackColor = System.Drawing.SystemColors.Control
        Me.lblZonaPreparacion.Location = New System.Drawing.Point(0, 189)
        Me.lblZonaPreparacion.Name = "lblZonaPreparacion"
        Me.lblZonaPreparacion.Size = New System.Drawing.Size(240, 20)
        Me.lblZonaPreparacion.Text = "Zona de Preparación: AFG"
        '
        'frmModuloProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtZonaPreparacion)
        Me.Controls.Add(Me.lblZonaPreparacion)
        Me.Controls.Add(Me.txtUbicacionOrigen)
        Me.Controls.Add(Me.lblUbicacionOrigen)
        Me.Controls.Add(Me.txtPalletContenedora)
        Me.Controls.Add(Me.lblPalletContenedora)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmbClientes)
        Me.KeyPreview = True
        Me.Name = "frmModuloProduccion"
        Me.Text = "Mod. Ensablado"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblOperacion As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblPalletContenedora As System.Windows.Forms.Label
    Friend WithEvents txtPalletContenedora As System.Windows.Forms.TextBox
    Friend WithEvents lblUbicacionOrigen As System.Windows.Forms.Label
    Friend WithEvents txtUbicacionOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtZonaPreparacion As System.Windows.Forms.TextBox
    Friend WithEvents lblZonaPreparacion As System.Windows.Forms.Label
End Class
