Public Class formControleAtendimentos

    ' procedimento para limpar campos
    Public Sub limparCampos()
        txtNome.Text = Nothing
        txtCpf.Text = Nothing
        txtNascimento.Value = Date.Now
        txtIdade.Text = Nothing
        cbxPlanoA.Checked = False
        cbxPlanoB.Checked = False
        cbxPlanoC.Checked = False
        cbxMedico.Text = Nothing
    End Sub

    ' matrizes para pacientes
    Dim arrPacientesUrgentes As New ArrayList
    Dim arrPacientesNormais As New ArrayList

    ' array para médicos e planos
    Dim planosA As Object = ({"Dr. Paulo Manfred", "Dra. Juliana Serra", "Dra. Clara Jacobs"})
    Dim planosB As Object = ({"Dr. Luciano Zans", "Dr. Pedro Fonsceca", "Dra. Marília Biezus"})
    Dim planosC As Object = ({"Dra. Julieta Vasconscelos", "Dra. Beatriz Pereira", "Dr. Simão Faria"})

    ' opcoes selecionadas
    Public planoSelec As String

    ' ao clicar em 'Cadastrar'
    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        ' valida 'Nome'
        If (txtNome.Text = Nothing Or IsNumeric(txtNome.Text)) Then
            MsgBox("O campo 'Nome' está em branco ou não é um valor válido.", MsgBoxStyle.Critical, "ATENÇÃO!")
            Exit Sub
        End If

        ' valida 'CPF'
        If (txtCpf.Text = Nothing Or Not txtCpf.Text.Length = 11) Then
            MsgBox("O campo 'CPF' está em branco ou não é um valor válido.", MsgBoxStyle.Critical, "ATENÇÃO!")
            Exit Sub
        End If

        ' valida 'Plano de saúde'
        If (Not cbxPlanoA.Checked AndAlso Not cbxPlanoB.Checked AndAlso Not cbxPlanoC.Checked) Then
            MsgBox("O campo 'Plano de saúde' não foi preenchido. Por favor, selecione um plano para continuar.", MsgBoxStyle.Critical, "ATENÇÃO!")
            Exit Sub
        End If

        'valida 'Médico'
        If (cbxMedico.Text = Nothing) Then
            MsgBox("O campo 'Médico' não foi preenchido. Por favor, selecione um médico para continuar.", MsgBoxStyle.Critical, "ATENÇÃO!")
            Exit Sub
        End If

        ' se todos os campos estiverem preenchidos
        Dim nome As String = txtNome.Text
        Dim cpf As String = txtCpf.Text
        Dim nascimento, atual As Date
        nascimento = txtNascimento.Value
        atual = Now
        Dim idade As Single = (DateDiff(DateInterval.Day, nascimento, atual) / 365.25).ToString("00") ' (00) --> idade com 2 digitos
        txtIdade.Text = idade

        ' médico selecionado
        Dim medicoSelec As String = cbxMedico.GetItemText(cbxMedico.SelectedItem)

        ' se idade >= 55, salvar em arrPacientesUrgentes
        If (idade > 54) Then
            MsgBox("Dados cadastrados com sucesso.", MsgBoxStyle.OkCancel, "Confirmação de cadastro")
            arrPacientesUrgentes.Add({nome, cpf, idade, planoSelec, medicoSelec})
            limparCampos()   ' limpar campos
        Else
            ' se idade < 55 & situacao = normal, salvar em arrPacientesNormais
            If (rbtNormal.Checked) Then
                MsgBox("Dados cadastrados com sucesso.", MsgBoxStyle.OkCancel, "Confirmação de cadastro")
                arrPacientesNormais.Add({nome, cpf, idade, planoSelec, medicoSelec})
                limparCampos()   ' limpar campos
            Else
                ' se idade < 55 & situacao = urgente, salvar em arrPacientesUrgentes
                MsgBox("Dados cadastrados com sucesso.", MsgBoxStyle.OkCancel, "Confirmação de cadastro")
                arrPacientesUrgentes.Add({nome, cpf, idade, planoSelec, medicoSelec})
                limparCampos()   ' limpar campos
            End If
        End If

        ' atualiza dados na listView Pctes urgentes
        'limpar lsv
        lsvUrgentes.Clear()

        'recria colunas
        lsvUrgentes.Columns.Add("Nome")
        lsvUrgentes.Columns.Add("CPF")
        lsvUrgentes.Columns.Add("Idade")
        lsvUrgentes.Columns.Add("Plano")
        lsvUrgentes.Columns.Add("Médico")

        ' formata largura das colunas
        lsvUrgentes.Columns(0).Width = 100
        lsvUrgentes.Columns(1).Width = 100
        lsvUrgentes.Columns(2).Width = 50
        lsvUrgentes.Columns(3).Width = 100
        lsvUrgentes.Columns(4).Width = 140

        ' exibe dados na lsv
        For Each linha As Object In arrPacientesUrgentes
            Dim lsvItem As ListViewItem = lsvUrgentes.Items.Add(linha(0))
            lsvItem.SubItems.Add(linha(1))
            lsvItem.SubItems.Add(linha(2))
            lsvItem.SubItems.Add(linha(3))
            lsvItem.SubItems.Add(linha(4))
        Next
        ' atualiza fila Pctes Urgentes
        lblFilaUrgentes.Text = "Total de pessoas na fila: " & arrPacientesUrgentes.Count

        ' atualiza dados na listView Pctes Normais
        'limpar lsv
        lsvNormais.Clear()

        'recria colunas
        lsvNormais.Columns.Add("Nome")
        lsvNormais.Columns.Add("CPF")
        lsvNormais.Columns.Add("Idade")
        lsvNormais.Columns.Add("Plano")
        lsvNormais.Columns.Add("Médico")

        ' formata largura das colunas
        lsvNormais.Columns(0).Width = 100
        lsvNormais.Columns(1).Width = 100
        lsvNormais.Columns(2).Width = 50
        lsvNormais.Columns(3).Width = 100
        lsvNormais.Columns(4).Width = 140

        ' exibe dados na lsv
        For Each linha As Object In arrPacientesNormais
            Dim lsvItem As ListViewItem = lsvNormais.Items.Add(linha(0))
            lsvItem.SubItems.Add(linha(1))
            lsvItem.SubItems.Add(linha(2))
            lsvItem.SubItems.Add(linha(3))
            lsvItem.SubItems.Add(linha(4))
        Next
        ' atualiza fila Pctes Urgentes
        lblFilaNormais.Text = "Total de pessoas na fila: " & arrPacientesNormais.Count
    End Sub

    ' médicos disponíveis no planoA
    Private Sub cbxPlanoA_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPlanoA.CheckedChanged
        If (cbxPlanoA.Checked) Then
            planoSelec = "Plano A"
            cbxMedico.DataSource = planosA
        Else
            cbxMedico.DataSource = Nothing
        End If
    End Sub

    Private Sub cbxPlanoB_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPlanoB.CheckedChanged
        If (cbxPlanoB.Checked) Then
            planoSelec = "Plano B"
            cbxMedico.DataSource = planosB
        Else
            cbxMedico.DataSource = Nothing
        End If
    End Sub

    Private Sub cbxPlanoC_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPlanoC.CheckedChanged
        If (cbxPlanoC.Checked) Then
            planoSelec = "Plano C"
            cbxMedico.DataSource = planosC
        Else
            cbxMedico.DataSource = Nothing
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limparCampos()   ' limpar campos
    End Sub
End Class