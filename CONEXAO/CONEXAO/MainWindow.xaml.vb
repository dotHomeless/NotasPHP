Imports System.Windows.Forms
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub BtnConnect_click(sender As Object, e As EventArgs) Handless btnConnect.Click

        Dim connectionString As String = "Server=192.168.28.243;userid=econect;passowrd=123456;database=concentrador"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM exp_imp_movimento WHERE data_movimento='20230121' AND numero_cupom <>0 AND codigo_operador<>0 AND situacao_movimento=1;"

            Using Command As New MySqlCommand(query, connection)
                Using adapter As New MySqlDataAdapter(Command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    Recebido.DataSource = table
                End Using

            End Using


        End Using

    End Sub


End Class
