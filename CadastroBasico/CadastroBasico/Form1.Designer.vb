<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fnCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fnCadastro))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtSobrenome = New System.Windows.Forms.TextBox()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtMae = New System.Windows.Forms.TextBox()
        Me.txtPai = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.lblMae = New System.Windows.Forms.Label()
        Me.lblPai = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.rdbFeminino = New System.Windows.Forms.RadioButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.lblObservacoes = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(51, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(382, 31)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Sistema de Cadastro Básico"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(78, 73)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(131, 20)
        Me.txtNome.TabIndex = 0
        '
        'txtSobrenome
        '
        Me.txtSobrenome.Location = New System.Drawing.Point(78, 99)
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.Size = New System.Drawing.Size(131, 20)
        Me.txtSobrenome.TabIndex = 1
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(78, 125)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(87, 20)
        Me.txtCEP.TabIndex = 2
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(78, 151)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(131, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'txtMae
        '
        Me.txtMae.Location = New System.Drawing.Point(78, 255)
        Me.txtMae.Name = "txtMae"
        Me.txtMae.Size = New System.Drawing.Size(131, 20)
        Me.txtMae.TabIndex = 7
        '
        'txtPai
        '
        Me.txtPai.Location = New System.Drawing.Point(78, 229)
        Me.txtPai.Name = "txtPai"
        Me.txtPai.Size = New System.Drawing.Size(131, 20)
        Me.txtPai.TabIndex = 6
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(78, 203)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(131, 20)
        Me.txtCPF.TabIndex = 5
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(78, 177)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(131, 20)
        Me.txtRG.TabIndex = 4
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(33, 76)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(41, 13)
        Me.lblNome.TabIndex = 9
        Me.lblNome.Text = "Nome: "
        '
        'lblSobrenome
        '
        Me.lblSobrenome.AutoSize = True
        Me.lblSobrenome.Location = New System.Drawing.Point(8, 102)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(64, 13)
        Me.lblSobrenome.TabIndex = 10
        Me.lblSobrenome.Text = "Sobrenome:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(18, 154)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 12
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(43, 128)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 11
        Me.lblCEP.Text = "CEP:"
        '
        'lblMae
        '
        Me.lblMae.AutoSize = True
        Me.lblMae.Location = New System.Drawing.Point(41, 258)
        Me.lblMae.Name = "lblMae"
        Me.lblMae.Size = New System.Drawing.Size(31, 13)
        Me.lblMae.TabIndex = 16
        Me.lblMae.Text = "Mãe:"
        '
        'lblPai
        '
        Me.lblPai.AutoSize = True
        Me.lblPai.Location = New System.Drawing.Point(47, 232)
        Me.lblPai.Name = "lblPai"
        Me.lblPai.Size = New System.Drawing.Size(25, 13)
        Me.lblPai.TabIndex = 15
        Me.lblPai.Text = "Pai:"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(42, 206)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 14
        Me.lblCPF.Text = "CPF:"
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.Location = New System.Drawing.Point(46, 180)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(26, 13)
        Me.lblRG.TabIndex = 13
        Me.lblRG.Text = "RG:"
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(80, 289)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdbMasculino.TabIndex = 8
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'rdbFeminino
        '
        Me.rdbFeminino.AutoSize = True
        Me.rdbFeminino.Location = New System.Drawing.Point(159, 289)
        Me.rdbFeminino.Name = "rdbFeminino"
        Me.rdbFeminino.Size = New System.Drawing.Size(67, 17)
        Me.rdbFeminino.TabIndex = 9
        Me.rdbFeminino.TabStop = True
        Me.rdbFeminino.Text = "Feminino"
        Me.rdbFeminino.UseVisualStyleBackColor = True
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(38, 291)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 20
        Me.lblSexo.Text = "Sexo:"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.Location = New System.Drawing.Point(22, 332)
        Me.txtObservacoes.Multiline = True
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(384, 130)
        Me.txtObservacoes.TabIndex = 10
        '
        'lblObservacoes
        '
        Me.lblObservacoes.AutoSize = True
        Me.lblObservacoes.Location = New System.Drawing.Point(19, 316)
        Me.lblObservacoes.Name = "lblObservacoes"
        Me.lblObservacoes.Size = New System.Drawing.Size(73, 13)
        Me.lblObservacoes.TabIndex = 22
        Me.lblObservacoes.Text = "Observações:"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(412, 332)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 130)
        Me.btnLimpar.TabIndex = 11
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'fnCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 472)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.lblObservacoes)
        Me.Controls.Add(Me.txtObservacoes)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.rdbFeminino)
        Me.Controls.Add(Me.rdbMasculino)
        Me.Controls.Add(Me.lblMae)
        Me.Controls.Add(Me.lblPai)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.lblRG)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblCEP)
        Me.Controls.Add(Me.lblSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtMae)
        Me.Controls.Add(Me.txtPai)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.txtSobrenome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fnCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Básico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtMae As TextBox
    Friend WithEvents txtPai As TextBox
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents txtRG As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblCEP As Label
    Friend WithEvents lblMae As Label
    Friend WithEvents lblPai As Label
    Friend WithEvents lblCPF As Label
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents rdbFeminino As RadioButton
    Friend WithEvents lblSexo As Label
    Friend WithEvents txtObservacoes As TextBox
    Friend WithEvents lblObservacoes As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents lblRG As Label
End Class
