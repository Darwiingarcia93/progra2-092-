<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTB_YARDAS = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_CUERINA = New System.Windows.Forms.RadioButton()
        Me.RB_CUERO = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RB_DOBLE = New System.Windows.Forms.RadioButton()
        Me.RB_INDI = New System.Windows.Forms.RadioButton()
        Me.RB_SOFA = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENTAS = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTB_VENTAS = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VENTAS.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTB_YARDAS)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(321, 147)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CANTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NUMERO DE YARDAS"

        Me.TXTB_YARDAS.Location = New System.Drawing.Point(202, 33)
        Me.TXTB_YARDAS.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTB_YARDAS.Name = "TXTB_YARDAS"
        Me.TXTB_YARDAS.Size = New System.Drawing.Size(154, 26)
        Me.TXTB_YARDAS.TabIndex = 2

        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RB_CUERINA)
        Me.GroupBox2.Controls.Add(Me.RB_CUERO)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 24)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(186, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TELA"

        Me.RB_CUERINA.AutoSize = True
        Me.RB_CUERINA.BackColor = System.Drawing.Color.Transparent
        Me.RB_CUERINA.Location = New System.Drawing.Point(51, 57)
        Me.RB_CUERINA.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_CUERINA.Name = "RB_CUERINA"
        Me.RB_CUERINA.Size = New System.Drawing.Size(101, 21)
        Me.RB_CUERINA.TabIndex = 1
        Me.RB_CUERINA.TabStop = True
        Me.RB_CUERINA.Text = "CUERINA"
        Me.RB_CUERINA.UseVisualStyleBackColor = False

        Me.RB_CUERO.AutoSize = True
        Me.RB_CUERO.Location = New System.Drawing.Point(51, 27)
        Me.RB_CUERO.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_CUERO.Name = "RB_CUERO"
        Me.RB_CUERO.Size = New System.Drawing.Size(86, 21)
        Me.RB_CUERO.TabIndex = 0
        Me.RB_CUERO.TabStop = True
        Me.RB_CUERO.Text = "CUERO"
        Me.RB_CUERO.UseVisualStyleBackColor = True

        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RB_DOBLE)
        Me.GroupBox3.Controls.Add(Me.RB_INDI)
        Me.GroupBox3.Controls.Add(Me.RB_SOFA)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 113)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(249, 149)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TAMAÑO"

        Me.RB_DOBLE.AutoSize = True
        Me.RB_DOBLE.Location = New System.Drawing.Point(46, 124)
        Me.RB_DOBLE.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_DOBLE.Name = "RB_DOBLE"
        Me.RB_DOBLE.Size = New System.Drawing.Size(84, 21)
        Me.RB_DOBLE.TabIndex = 2
        Me.RB_DOBLE.TabStop = True
        Me.RB_DOBLE.Text = "DOBLE"
        Me.RB_DOBLE.UseVisualStyleBackColor = True

        Me.RB_INDI.AutoSize = True
        Me.RB_INDI.Location = New System.Drawing.Point(46, 77)
        Me.RB_INDI.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_INDI.Name = "RB_INDI"
        Me.RB_INDI.Size = New System.Drawing.Size(119, 21)
        Me.RB_INDI.TabIndex = 1
        Me.RB_INDI.TabStop = True
        Me.RB_INDI.Text = "INDIVIDUAL"
        Me.RB_INDI.UseVisualStyleBackColor = True

        Me.RB_SOFA.AutoSize = True
        Me.RB_SOFA.Location = New System.Drawing.Point(44, 32)
        Me.RB_SOFA.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_SOFA.Name = "RB_SOFA"
        Me.RB_SOFA.Size = New System.Drawing.Size(70, 21)
        Me.RB_SOFA.TabIndex = 0
        Me.RB_SOFA.TabStop = True
        Me.RB_SOFA.Text = "SOFA"
        Me.RB_SOFA.UseVisualStyleBackColor = True

        Me.MenuStrip1.BackColor = System.Drawing.Color.Lime
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(853, 25)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"

        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(61, 19)
        Me.CALCULARToolStripMenuItem.Text = "Guardar"

        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(93, 19)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "Limpiar Menu"

        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(106, 19)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "Limpiar Historial"

        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(103, 19)
        Me.SALIRToolStripMenuItem.Text = "Salir del sistema"

        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lime
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 330)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(798, 330)
        Me.DataGridView1.TabIndex = 6

        Me.Column1.HeaderText = "NUMERO VENTAS"
        Me.Column1.Name = "Column1"

        Me.Column2.HeaderText = "TAMAÑO"
        Me.Column2.Name = "Column2"

        Me.Column3.HeaderText = "TIPO TELA"
        Me.Column3.Name = "Column3"

        Me.Column4.HeaderText = "YARDAS"
        Me.Column4.Name = "Column4"

        Me.Column5.HeaderText = "COSTOS"
        Me.Column5.Name = "Column5"

        Me.Column6.HeaderText = "TOTAL VENTAS"
        Me.Column6.Name = "Column6"

        Me.VENTAS.BackColor = System.Drawing.Color.Transparent
        Me.VENTAS.Controls.Add(Me.Label1)
        Me.VENTAS.Controls.Add(Me.TXTB_VENTAS)
        Me.VENTAS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.VENTAS.Location = New System.Drawing.Point(321, 59)
        Me.VENTAS.Margin = New System.Windows.Forms.Padding(4)
        Me.VENTAS.Name = "VENTAS"
        Me.VENTAS.Padding = New System.Windows.Forms.Padding(4)
        Me.VENTAS.Size = New System.Drawing.Size(341, 81)
        Me.VENTAS.TabIndex = 7
        Me.VENTAS.TabStop = False
        Me.VENTAS.Text = "Venta"

        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TOTAL VENTAS"

        Me.TXTB_VENTAS.Location = New System.Drawing.Point(147, 28)
        Me.TXTB_VENTAS.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTB_VENTAS.Name = "TXTB_VENTAS"
        Me.TXTB_VENTAS.Size = New System.Drawing.Size(177, 26)
        Me.TXTB_VENTAS.TabIndex = 0

        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(302, 269)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo"

        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 662)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.VENTAS)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "201700655"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VENTAS.ResumeLayout(False)
        Me.VENTAS.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTB_YARDAS As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RB_CUERINA As RadioButton
    Friend WithEvents RB_CUERO As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RB_DOBLE As RadioButton
    Friend WithEvents RB_INDI As RadioButton
    Friend WithEvents RB_SOFA As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VENTAS As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTB_VENTAS As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
End Class
