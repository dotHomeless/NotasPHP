Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click

        ' Configure os detalhes da conexão
        Dim server As String = "seu_servidor"
        Dim database As String = "nome_do_banco"
        Dim uid As String = "seu_usuario"
        Dim password As String = "sua_senha"
        Dim connectionString As String = $"server={server};database={database};uid={uid};password={password};"

        ' Cria a conexão
        Dim conn As New MySqlConnection(connectionString)

        Try
            ' Abre a conexão
            conn.Open()

            ' Executa a consulta
            Dim query As String = "SELECT * FROM minha_tabela"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Adiciona as colunas do ListView
            ListView1.Columns.Add("ID", 50)
            ListView1.Columns.Add("Nome", 150)
            ListView1.Columns.Add("Sobrenome", 150)

            ' Preenche o ListView com os dados retornados pela consulta
            While reader.Read()
                Dim item As New ListViewItem(reader("id").ToString())
                item.SubItems.Add(reader("nome").ToString())
                item.SubItems.Add(reader("sobrenome").ToString())
                ListView1.Items.Add(item)
            End While

            ' Fecha o leitor e a conexão
            reader.Close()
            conn.Close()
        Catch ex As MySqlException
            ' Trate as exceções aqui
        End Try
    End Sub
End Class
