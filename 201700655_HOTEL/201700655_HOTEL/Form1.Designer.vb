<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ACEPTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDENARDESCENTNDETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDBJACUZZI = New System.Windows.Forms.RadioButton()
        Me.RDBAC = New System.Windows.Forms.RadioButton()
        Me.RDBESTANDAR = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTEXTRAS = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTCONSULTA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACEPTARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.BUSCARToolStripMenuItem, Me.ORDENARDESCENTNDETEToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(19, 6, 0, 6)
        Me.MenuStrip1.Size = New System.Drawing.Size(2264, 69)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACEPTARToolStripMenuItem
        '
        Me.ACEPTARToolStripMenuItem.Name = "ACEPTARToolStripMenuItem"
        Me.ACEPTARToolStripMenuItem.Size = New System.Drawing.Size(192, 57)
        Me.ACEPTARToolStripMenuItem.Text = "ACEPTAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(212, 57)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'BUSCARToolStripMenuItem
        '
        Me.BUSCARToolStripMenuItem.Name = "BUSCARToolStripMenuItem"
        Me.BUSCARToolStripMenuItem.Size = New System.Drawing.Size(180, 57)
        Me.BUSCARToolStripMenuItem.Text = "BUSCAR"
        '
        'ORDENARDESCENTNDETEToolStripMenuItem
        '
        Me.ORDENARDESCENTNDETEToolStripMenuItem.Name = "ORDENARDESCENTNDETEToolStripMenuItem"
        Me.ORDENARDESCENTNDETEToolStripMenuItem.Size = New System.Drawing.Size(212, 57)
        Me.ORDENARDESCENTNDETEToolStripMenuItem.Text = "ORDENAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MATRIZToolStripMenuItem, Me.VECTORESToolStripMenuItem, Me.DATAToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(182, 57)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'MATRIZToolStripMenuItem
        '
        Me.MATRIZToolStripMenuItem.Name = "MATRIZToolStripMenuItem"
        Me.MATRIZToolStripMenuItem.Size = New System.Drawing.Size(393, 66)
        Me.MATRIZToolStripMenuItem.Text = "MATRIZ"
        '
        'VECTORESToolStripMenuItem
        '
        Me.VECTORESToolStripMenuItem.Name = "VECTORESToolStripMenuItem"
        Me.VECTORESToolStripMenuItem.Size = New System.Drawing.Size(393, 66)
        Me.VECTORESToolStripMenuItem.Text = "ENTRADAS"
        '
        'DATAToolStripMenuItem
        '
        Me.DATAToolStripMenuItem.Name = "DATAToolStripMenuItem"
        Me.DATAToolStripMenuItem.Size = New System.Drawing.Size(393, 66)
        Me.DATAToolStripMenuItem.Text = "DATA"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(139, 57)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(92, 928)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 123
        Me.DataGridView1.Size = New System.Drawing.Size(2071, 336)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "# NIT"
        Me.Column1.MinimumWidth = 15
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE CLIENTE"
        Me.Column2.MinimumWidth = 15
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "PERSONAS "
        Me.Column3.MinimumWidth = 15
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "TIPO HABITACIO"
        Me.Column4.MinimumWidth = 15
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 300
        '
        'Column6
        '
        Me.Column6.HeaderText = "Pago extra"
        Me.Column6.MinimumWidth = 15
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL A PAGAR"
        Me.Column5.MinimumWidth = 15
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 300
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RDBJACUZZI)
        Me.GroupBox1.Controls.Add(Me.RDBAC)
        Me.GroupBox1.Controls.Add(Me.RDBESTANDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(1156, 148)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 390)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRECIOS POR 1-4 PERSONAS Y HABITACIONES"
        '
        'RDBJACUZZI
        '
        Me.RDBJACUZZI.AutoSize = True
        Me.RDBJACUZZI.Location = New System.Drawing.Point(51, 313)
        Me.RDBJACUZZI.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.RDBJACUZZI.Name = "RDBJACUZZI"
        Me.RDBJACUZZI.Size = New System.Drawing.Size(309, 41)
        Me.RDBJACUZZI.TabIndex = 2
        Me.RDBJACUZZI.TabStop = True
        Me.RDBJACUZZI.Text = "JACUZZI -  Q370"
        Me.RDBJACUZZI.UseVisualStyleBackColor = True
        '
        'RDBAC
        '
        Me.RDBAC.AutoSize = True
        Me.RDBAC.Location = New System.Drawing.Point(51, 208)
        Me.RDBAC.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.RDBAC.Name = "RDBAC"
        Me.RDBAC.Size = New System.Drawing.Size(222, 41)
        Me.RDBAC.TabIndex = 1
        Me.RDBAC.TabStop = True
        Me.RDBAC.Text = "A/C - Q290"
        Me.RDBAC.UseVisualStyleBackColor = True
        '
        'RDBESTANDAR
        '
        Me.RDBESTANDAR.AutoSize = True
        Me.RDBESTANDAR.Location = New System.Drawing.Point(51, 120)
        Me.RDBESTANDAR.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.RDBESTANDAR.Name = "RDBESTANDAR"
        Me.RDBESTANDAR.Size = New System.Drawing.Size(370, 41)
        Me.RDBESTANDAR.TabIndex = 0
        Me.RDBESTANDAR.TabStop = True
        Me.RDBESTANDAR.Text = "ESTANDAR - Q250.0"
        Me.RDBESTANDAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 250)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NUMERO DE NIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 347)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOMBRE DEL CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 467)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PERSONAS "
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(592, 242)
        Me.txtnit.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(308, 44)
        Me.txtnit.TabIndex = 6
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(592, 347)
        Me.TXTNOMBRE.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(308, 44)
        Me.TXTNOMBRE.TabIndex = 7
        '
        'TXTEXTRAS
        '
        Me.TXTEXTRAS.Location = New System.Drawing.Point(592, 447)
        Me.TXTEXTRAS.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.TXTEXTRAS.Name = "TXTEXTRAS"
        Me.TXTEXTRAS.Size = New System.Drawing.Size(308, 44)
        Me.TXTEXTRAS.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TXTCONSULTA)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(95, 620)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox2.Size = New System.Drawing.Size(985, 216)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nit a consultar"
        '
        'TXTCONSULTA
        '
        Me.TXTCONSULTA.Location = New System.Drawing.Point(497, 102)
        Me.TXTCONSULTA.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.TXTCONSULTA.Name = "TXTCONSULTA"
        Me.TXTCONSULTA.Size = New System.Drawing.Size(308, 44)
        Me.TXTCONSULTA.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 74)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "NUMERO DE NIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " A CONSULTAR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(2264, 1355)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TXTEXTRAS)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ACEPTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUSCARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDENARDESCENTNDETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDBJACUZZI As RadioButton
    Friend WithEvents RDBAC As RadioButton
    Friend WithEvents RDBESTANDAR As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnit As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents TXTEXTRAS As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXTCONSULTA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DATAToolStripMenuItem As ToolStripMenuItem
End Class
