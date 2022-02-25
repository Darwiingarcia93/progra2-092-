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
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.BTCALCULAR = New System.Windows.Forms.Button()
        Me.BTLIMPIAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcarnet = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Not2 = New System.Windows.Forms.TextBox()
        Me.Not1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Not3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Not4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Not5 = New System.Windows.Forms.TextBox()
        Me.not6 = New System.Windows.Forms.TextBox()
        Me.not7 = New System.Windows.Forms.TextBox()
        Me.not8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.not9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.not10 = New System.Windows.Forms.TextBox()
        Me.Equivalencia1 = New System.Windows.Forms.CheckBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.txtCondicion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTSALIR
        '
        Me.BTSALIR.Location = New System.Drawing.Point(256, 252)
        Me.BTSALIR.Name = "BTSALIR"
        Me.BTSALIR.Size = New System.Drawing.Size(110, 34)
        Me.BTSALIR.TabIndex = 0
        Me.BTSALIR.Text = "Salir"
        Me.BTSALIR.UseVisualStyleBackColor = True
        '
        'BTCALCULAR
        '
        Me.BTCALCULAR.Location = New System.Drawing.Point(24, 252)
        Me.BTCALCULAR.Name = "BTCALCULAR"
        Me.BTCALCULAR.Size = New System.Drawing.Size(110, 34)
        Me.BTCALCULAR.TabIndex = 1
        Me.BTCALCULAR.Text = "Calcular"
        Me.BTCALCULAR.UseVisualStyleBackColor = True
        '
        'BTLIMPIAR
        '
        Me.BTLIMPIAR.Location = New System.Drawing.Point(140, 252)
        Me.BTLIMPIAR.Name = "BTLIMPIAR"
        Me.BTLIMPIAR.Size = New System.Drawing.Size(110, 34)
        Me.BTLIMPIAR.TabIndex = 2
        Me.BTLIMPIAR.Text = "Limpiar"
        Me.BTLIMPIAR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtcarnet)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 110)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Estudiante"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Carnet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre Estudiante"
        '
        'txtcarnet
        '
        Me.txtcarnet.Location = New System.Drawing.Point(87, 27)
        Me.txtcarnet.Name = "txtcarnet"
        Me.txtcarnet.Size = New System.Drawing.Size(100, 20)
        Me.txtcarnet.TabIndex = 4
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(122, 65)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(210, 20)
        Me.txtnombre.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Controls.Add(Me.CheckBox7)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Equivalencia1)
        Me.GroupBox2.Controls.Add(Me.not10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.not9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.not8)
        Me.GroupBox2.Controls.Add(Me.not7)
        Me.GroupBox2.Controls.Add(Me.not6)
        Me.GroupBox2.Controls.Add(Me.Not5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Not4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Not3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Not2)
        Me.GroupBox2.Controls.Add(Me.Not1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 340)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingreso Notas"
        '
        'Not2
        '
        Me.Not2.Location = New System.Drawing.Point(158, 55)
        Me.Not2.Name = "Not2"
        Me.Not2.Size = New System.Drawing.Size(47, 20)
        Me.Not2.TabIndex = 5
        '
        'Not1
        '
        Me.Not1.Location = New System.Drawing.Point(158, 24)
        Me.Not1.Name = "Not1"
        Me.Not1.Size = New System.Drawing.Size(47, 20)
        Me.Not1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quimica"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Matematica"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fisica"
        '
        'Not3
        '
        Me.Not3.Location = New System.Drawing.Point(158, 90)
        Me.Not3.Name = "Not3"
        Me.Not3.Size = New System.Drawing.Size(47, 20)
        Me.Not3.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Legislación"
        '
        'Not4
        '
        Me.Not4.Location = New System.Drawing.Point(158, 126)
        Me.Not4.Name = "Not4"
        Me.Not4.Size = New System.Drawing.Size(47, 20)
        Me.Not4.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Progra 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Administración de personal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Mecanica Analitica"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "IO2"
        '
        'Not5
        '
        Me.Not5.Location = New System.Drawing.Point(158, 157)
        Me.Not5.Name = "Not5"
        Me.Not5.Size = New System.Drawing.Size(47, 20)
        Me.Not5.TabIndex = 14
        '
        'not6
        '
        Me.not6.Location = New System.Drawing.Point(158, 189)
        Me.not6.Name = "not6"
        Me.not6.Size = New System.Drawing.Size(47, 20)
        Me.not6.TabIndex = 15
        '
        'not7
        '
        Me.not7.Location = New System.Drawing.Point(158, 225)
        Me.not7.Name = "not7"
        Me.not7.Size = New System.Drawing.Size(47, 20)
        Me.not7.TabIndex = 16
        '
        'not8
        '
        Me.not8.Location = New System.Drawing.Point(158, 254)
        Me.not8.Name = "not8"
        Me.not8.Size = New System.Drawing.Size(47, 20)
        Me.not8.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Estadistica 1"
        '
        'not9
        '
        Me.not9.Location = New System.Drawing.Point(158, 284)
        Me.not9.Name = "not9"
        Me.not9.Size = New System.Drawing.Size(47, 20)
        Me.not9.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Mercadotecnia"
        '
        'not10
        '
        Me.not10.Location = New System.Drawing.Point(158, 310)
        Me.not10.Name = "not10"
        Me.not10.Size = New System.Drawing.Size(47, 20)
        Me.not10.TabIndex = 21
        '
        'Equivalencia1
        '
        Me.Equivalencia1.AutoSize = True
        Me.Equivalencia1.Location = New System.Drawing.Point(224, 26)
        Me.Equivalencia1.Name = "Equivalencia1"
        Me.Equivalencia1.Size = New System.Drawing.Size(93, 17)
        Me.Equivalencia1.TabIndex = 22
        Me.Equivalencia1.Text = "Equivalencia?"
        Me.Equivalencia1.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.Resultado.Location = New System.Drawing.Point(117, 162)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(94, 20)
        Me.Resultado.TabIndex = 25
        '
        'txtCondicion
        '
        Me.txtCondicion.Location = New System.Drawing.Point(117, 201)
        Me.txtCondicion.Name = "txtCondicion"
        Me.txtCondicion.Size = New System.Drawing.Size(179, 20)
        Me.txtCondicion.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Su promedio es:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Comentario"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(224, 61)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Equivalencia?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(224, 94)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox2.TabIndex = 24
        Me.CheckBox2.Text = "Equivalencia?"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(224, 129)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox3.TabIndex = 25
        Me.CheckBox3.Text = "Equivalencia?"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(224, 160)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox4.TabIndex = 26
        Me.CheckBox4.Text = "Equivalencia?"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(224, 192)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox5.TabIndex = 27
        Me.CheckBox5.Text = "Equivalencia?"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(224, 227)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox6.TabIndex = 28
        Me.CheckBox6.Text = "Equivalencia?"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(224, 258)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox7.TabIndex = 29
        Me.CheckBox7.Text = "Equivalencia?"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(224, 286)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox8.TabIndex = 30
        Me.CheckBox8.Text = "Equivalencia?"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(224, 312)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox9.TabIndex = 31
        Me.CheckBox9.Text = "Equivalencia?"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCondicion)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTLIMPIAR)
        Me.Controls.Add(Me.BTCALCULAR)
        Me.Controls.Add(Me.BTSALIR)
        Me.Name = "Form1"
        Me.Text = "PROMEDIO NOTAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTSALIR As Button
    Friend WithEvents BTCALCULAR As Button
    Friend WithEvents BTLIMPIAR As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcarnet As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents not7 As TextBox
    Friend WithEvents not6 As TextBox
    Friend WithEvents Not5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Not4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Not3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Not2 As TextBox
    Friend WithEvents Not1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Equivalencia1 As CheckBox
    Friend WithEvents not10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents not9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents not8 As TextBox
    Friend WithEvents Resultado As TextBox
    Friend WithEvents txtCondicion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
