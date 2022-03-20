<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListaDePacks = New System.Windows.Forms.ComboBox()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Pack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Limpiar_Lista = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CantP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalV = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaDePacks
        '
        Me.ListaDePacks.FormattingEnabled = True
        Me.ListaDePacks.Location = New System.Drawing.Point(71, 99)
        Me.ListaDePacks.Name = "ListaDePacks"
        Me.ListaDePacks.Size = New System.Drawing.Size(309, 24)
        Me.ListaDePacks.TabIndex = 0
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(632, 92)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(143, 37)
        Me.Agregar.TabIndex = 1
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pack, Me.Precio, Me.Cantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(40, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(491, 477)
        Me.DataGridView1.TabIndex = 2
        '
        'Pack
        '
        Me.Pack.HeaderText = "Pack"
        Me.Pack.Name = "Pack"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cargar Listado de Packs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(40, 662)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(143, 37)
        Me.Aceptar.TabIndex = 4
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Limpiar_Lista
        '
        Me.Limpiar_Lista.Location = New System.Drawing.Point(213, 662)
        Me.Limpiar_Lista.Name = "Limpiar_Lista"
        Me.Limpiar_Lista.Size = New System.Drawing.Size(143, 37)
        Me.Limpiar_Lista.TabIndex = 5
        Me.Limpiar_Lista.Text = "Limpiar lista"
        Me.Limpiar_Lista.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(388, 662)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(143, 37)
        Me.Limpiar.TabIndex = 6
        Me.Limpiar.Text = "Limpiar Vectores"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(690, 662)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(143, 37)
        Me.Salir.TabIndex = 7
        Me.Salir.Text = "salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SELECCIONAR PACK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "INGRESE CANTIDAD"
        '
        'CantP
        '
        Me.CantP.Location = New System.Drawing.Point(433, 101)
        Me.CantP.Name = "CantP"
        Me.CantP.Size = New System.Drawing.Size(139, 22)
        Me.CantP.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(687, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TOTAL DE VENTA"
        '
        'TotalV
        '
        Me.TotalV.AutoSize = True
        Me.TotalV.Location = New System.Drawing.Point(732, 202)
        Me.TotalV.Name = "TotalV"
        Me.TotalV.Size = New System.Drawing.Size(36, 17)
        Me.TotalV.TabIndex = 12
        Me.TotalV.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(603, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(650, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PACKS RESTANTES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(695, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(684, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "SOBRANTES"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(630, 509)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(218, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "GANACIA ESPERADA DE PACKS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(592, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Jugos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(695, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Frituras"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(788, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Galletas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(884, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Baterias"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(704, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 17)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(802, 328)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 17)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(908, 328)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 17)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(895, 457)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 17)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(789, 457)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 17)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(691, 457)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 17)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(871, 416)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 17)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Baterias"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(775, 416)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 17)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Galletas"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(682, 416)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 17)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Frituras"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(579, 416)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 17)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Jugos"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(590, 457)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 17)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(888, 589)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(782, 589)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 17)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "0.00"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(684, 589)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(36, 17)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "0.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(864, 548)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 17)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "Baterias"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(768, 548)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 17)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "Galletas"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(675, 548)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 17)
        Me.Label29.TabIndex = 36
        Me.Label29.Text = "Frituras"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(572, 548)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 17)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "Jugos"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(583, 589)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 17)
        Me.Label31.TabIndex = 34
        Me.Label31.Text = "0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 711)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotalV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CantP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Limpiar_Lista)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.ListaDePacks)
        Me.Name = "Form1"
        Me.Text = "v"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaDePacks As ComboBox
    Friend WithEvents Agregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Aceptar As Button
    Friend WithEvents Limpiar_Lista As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Pack As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CantP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalV As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
End Class
