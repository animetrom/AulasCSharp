Public Class fnCadastro
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        ' LIMPANDO CAMPOS PREENCHIDOS

        txtNome.Clear()
        txtSobrenome.Clear()
        txtCEP.Clear()
        txtEndereco.Clear()
        txtCPF.Clear()
        txtRG.Clear()
        txtPai.Clear()
        txtMae.Clear()
        rdbFeminino.Checked = False
        rdbMasculino.Checked = False
        txtObservacoes.Clear()
    End Sub
End Class
