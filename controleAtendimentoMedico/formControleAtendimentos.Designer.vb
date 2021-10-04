<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formControleAtendimentos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtNascimento = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxPlanoC = New System.Windows.Forms.CheckBox()
        Me.cbxPlanoB = New System.Windows.Forms.CheckBox()
        Me.cbxPlanoA = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbtUrgente = New System.Windows.Forms.RadioButton()
        Me.rbtNormal = New System.Windows.Forms.RadioButton()
        Me.cbxMedico = New System.Windows.Forms.ComboBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lsvUrgentes = New System.Windows.Forms.ListView()
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CPF = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Idade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Plano = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Médico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblFilaUrgentes = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblFilaNormais = New System.Windows.Forms.Label()
        Me.lsvNormais = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Médico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Idade:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nascimento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CPF:"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(76, 28)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(167, 22)
        Me.txtNome.TabIndex = 6
        Me.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCpf
        '
        Me.txtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(76, 69)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(167, 22)
        Me.txtCpf.TabIndex = 7
        Me.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtIdade
        '
        Me.txtIdade.Enabled = False
        Me.txtIdade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdade.Location = New System.Drawing.Point(76, 157)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(167, 22)
        Me.txtIdade.TabIndex = 8
        Me.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNascimento
        '
        Me.txtNascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtNascimento.Location = New System.Drawing.Point(116, 114)
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(127, 22)
        Me.txtNascimento.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbxPlanoC)
        Me.GroupBox1.Controls.Add(Me.cbxPlanoB)
        Me.GroupBox1.Controls.Add(Me.cbxPlanoA)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(111, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 105)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Plano de saúde"
        '
        'cbxPlanoC
        '
        Me.cbxPlanoC.AutoSize = True
        Me.cbxPlanoC.Location = New System.Drawing.Point(21, 73)
        Me.cbxPlanoC.Name = "cbxPlanoC"
        Me.cbxPlanoC.Size = New System.Drawing.Size(74, 20)
        Me.cbxPlanoC.TabIndex = 2
        Me.cbxPlanoC.Text = "Plano C"
        Me.cbxPlanoC.UseVisualStyleBackColor = True
        '
        'cbxPlanoB
        '
        Me.cbxPlanoB.AutoSize = True
        Me.cbxPlanoB.Location = New System.Drawing.Point(21, 47)
        Me.cbxPlanoB.Name = "cbxPlanoB"
        Me.cbxPlanoB.Size = New System.Drawing.Size(74, 20)
        Me.cbxPlanoB.TabIndex = 1
        Me.cbxPlanoB.Text = "Plano B"
        Me.cbxPlanoB.UseVisualStyleBackColor = True
        '
        'cbxPlanoA
        '
        Me.cbxPlanoA.AutoSize = True
        Me.cbxPlanoA.Location = New System.Drawing.Point(21, 21)
        Me.cbxPlanoA.Name = "cbxPlanoA"
        Me.cbxPlanoA.Size = New System.Drawing.Size(74, 20)
        Me.cbxPlanoA.TabIndex = 0
        Me.cbxPlanoA.Text = "Plano A"
        Me.cbxPlanoA.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.rbtUrgente)
        Me.GroupBox2.Controls.Add(Me.rbtNormal)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 105)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Situação:"
        '
        'rbtUrgente
        '
        Me.rbtUrgente.AutoSize = True
        Me.rbtUrgente.Location = New System.Drawing.Point(13, 61)
        Me.rbtUrgente.Name = "rbtUrgente"
        Me.rbtUrgente.Size = New System.Drawing.Size(74, 20)
        Me.rbtUrgente.TabIndex = 1
        Me.rbtUrgente.Text = "Urgente"
        Me.rbtUrgente.UseVisualStyleBackColor = True
        '
        'rbtNormal
        '
        Me.rbtNormal.AutoSize = True
        Me.rbtNormal.Checked = True
        Me.rbtNormal.Location = New System.Drawing.Point(13, 35)
        Me.rbtNormal.Name = "rbtNormal"
        Me.rbtNormal.Size = New System.Drawing.Size(70, 20)
        Me.rbtNormal.TabIndex = 0
        Me.rbtNormal.TabStop = True
        Me.rbtNormal.Text = "Normal"
        Me.rbtNormal.UseVisualStyleBackColor = True
        '
        'cbxMedico
        '
        Me.cbxMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMedico.FormattingEnabled = True
        Me.cbxMedico.Location = New System.Drawing.Point(76, 314)
        Me.cbxMedico.Name = "cbxMedico"
        Me.cbxMedico.Size = New System.Drawing.Size(167, 24)
        Me.cbxMedico.TabIndex = 12
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCadastrar.Location = New System.Drawing.Point(12, 353)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(110, 33)
        Me.btnCadastrar.TabIndex = 13
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Location = New System.Drawing.Point(133, 353)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 33)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lsvUrgentes
        '
        Me.lsvUrgentes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nome, Me.CPF, Me.Idade, Me.Plano, Me.Médico})
        Me.lsvUrgentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvUrgentes.GridLines = True
        Me.lsvUrgentes.Location = New System.Drawing.Point(17, 21)
        Me.lsvUrgentes.Name = "lsvUrgentes"
        Me.lsvUrgentes.Size = New System.Drawing.Size(486, 146)
        Me.lsvUrgentes.TabIndex = 15
        Me.lsvUrgentes.UseCompatibleStateImageBehavior = False
        Me.lsvUrgentes.View = System.Windows.Forms.View.Details
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 100
        '
        'CPF
        '
        Me.CPF.Text = "CPF"
        Me.CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CPF.Width = 100
        '
        'Idade
        '
        Me.Idade.Text = "Idade"
        Me.Idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Idade.Width = 50
        '
        'Plano
        '
        Me.Plano.Text = "Plano"
        Me.Plano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Plano.Width = 100
        '
        'Médico
        '
        Me.Médico.Text = "Médico"
        Me.Médico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Médico.Width = 140
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lsvUrgentes)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(271, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(518, 173)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Atendimentos urgentes:"
        '
        'lblFilaUrgentes
        '
        Me.lblFilaUrgentes.AutoSize = True
        Me.lblFilaUrgentes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFilaUrgentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilaUrgentes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFilaUrgentes.Location = New System.Drawing.Point(519, 26)
        Me.lblFilaUrgentes.Name = "lblFilaUrgentes"
        Me.lblFilaUrgentes.Size = New System.Drawing.Size(149, 15)
        Me.lblFilaUrgentes.TabIndex = 17
        Me.lblFilaUrgentes.Text = "Total de pessoas na fila: 0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblFilaNormais)
        Me.GroupBox4.Controls.Add(Me.lsvNormais)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(271, 214)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(518, 173)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Atendimentos normais:"
        '
        'lblFilaNormais
        '
        Me.lblFilaNormais.AutoSize = True
        Me.lblFilaNormais.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFilaNormais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilaNormais.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFilaNormais.Location = New System.Drawing.Point(248, 0)
        Me.lblFilaNormais.Name = "lblFilaNormais"
        Me.lblFilaNormais.Size = New System.Drawing.Size(149, 15)
        Me.lblFilaNormais.TabIndex = 17
        Me.lblFilaNormais.Text = "Total de pessoas na fila: 0"
        '
        'lsvNormais
        '
        Me.lsvNormais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvNormais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvNormais.GridLines = True
        Me.lsvNormais.Location = New System.Drawing.Point(17, 21)
        Me.lsvNormais.Name = "lsvNormais"
        Me.lsvNormais.Size = New System.Drawing.Size(486, 146)
        Me.lsvNormais.TabIndex = 15
        Me.lsvNormais.UseCompatibleStateImageBehavior = False
        Me.lsvNormais.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CPF"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Idade"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Plano"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Médico"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 140
        '
        'formControleAtendimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 411)
        Me.Controls.Add(Me.lblFilaUrgentes)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.cbxMedico)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNascimento)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formControleAtendimentos"
        Me.Text = "Controle de Atendimentos Médicos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtIdade As System.Windows.Forms.TextBox
    Friend WithEvents txtNascimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPlanoC As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPlanoB As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPlanoA As System.Windows.Forms.CheckBox
    Friend WithEvents rbtUrgente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNormal As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxMedico As System.Windows.Forms.ComboBox
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lsvUrgentes As System.Windows.Forms.ListView
    Friend WithEvents Nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents CPF As System.Windows.Forms.ColumnHeader
    Friend WithEvents Idade As System.Windows.Forms.ColumnHeader
    Friend WithEvents Plano As System.Windows.Forms.ColumnHeader
    Friend WithEvents Médico As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFilaUrgentes As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFilaNormais As System.Windows.Forms.Label
    Friend WithEvents lsvNormais As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
