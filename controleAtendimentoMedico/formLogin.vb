Public Class formLogin

    ' ao clicar em 'Entrar'
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        ' usuarios e senhas salvas no sistema
        Dim arrUsuarios As Object = ({"a", "admin", "usuar01", "usuar02"})
        Dim arrSenhas As Object = ({"a", "abc123", "abc456", "abc678"})

        ' verifica login e senha
        Dim logado As Boolean = False

        For i = 0 To 2
            ' se login der certo, abrir form de cadastro e fechar form de login
            If (txtUsuario.Text = arrUsuarios(i) And txtSenha.Text = arrSenhas(i)) Then
                logado = True
                i = i - 1
                formControleAtendimentos.Show()     ' abrir cadastros
                Me.Close()                          ' fechar login
                Exit Sub
            End If
        Next

        ' se login der errado, informar usuario
        MsgBox("Usuário ou senha incorretos. ", MsgBoxStyle.Critical, "Atenção!")
    End Sub

    ' ao clicar em 'Sair', fechar o form
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class
