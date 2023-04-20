using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Segundo
{
    public partial class Form1 : Form
    {
        // Lista para armazenar os dados de conexão para cada banco MySQL
        List<MySQL_Connection> mysqlConnections = new List<MySQL_Connection>();
        List<MySQL_Connection> mysqlConnections1 = new List<MySQL_Connection>();

        public Form1()
        {
            InitializeComponent();

            // Adicionando dados de conexão para cada banco MySQL
            mysqlConnections.Add(new MySQL_Connection("192.168.100.230", "concentrador", "leitura", "leitura123") { IPName = "MATRIZ" });
            mysqlConnections.Add(new MySQL_Connection("192.168.20.253", "concentrador", "econect", "123456") { IPName = "0 - PAV 10" });
            mysqlConnections.Add(new MySQL_Connection("192.168.20.243", "concentrador", "econect", "123456") { IPName = "2 -  PAV 05" });
            mysqlConnections.Add(new MySQL_Connection("192.168.1.243", "concentrador", "econect", "123456") { IPName = "4 - DULCE" });
            mysqlConnections.Add(new MySQL_Connection("192.168.7.243", "concentrador", "econect", "123456") { IPName = "9 - COF" });
            mysqlConnections.Add(new MySQL_Connection("192.168.4.243", "concentrador", "econect", "123456") { IPName = "10 - TITO" });
            mysqlConnections.Add(new MySQL_Connection("192.168.5.243", "concentrador", "econect", "123456") { IPName = "11 - JF" });
            mysqlConnections.Add(new MySQL_Connection("192.168.6.243", "concentrador", "econect", "123456") { IPName = "12 - CEANORTE" });
            mysqlConnections.Add(new MySQL_Connection("192.168.8.243", "concentrador", "econect", "123456") { IPName = "14 - VAZ" });
            mysqlConnections.Add(new MySQL_Connection("192.168.27.243", "concentrador", "econect", "123456") { IPName = "15 - SION" });
            mysqlConnections.Add(new MySQL_Connection("192.168.9.243", "concentrador", "econect", "123456") { IPName = "18 - BRIGADEIRO" });
            mysqlConnections.Add(new MySQL_Connection("192.168.11.243", "concentrador", "econect", "123456") { IPName = "19 - DIV" });
            mysqlConnections.Add(new MySQL_Connection("192.168.10.243", "concentrador", "econect", "123456") { IPName = "20 - JUST" });
            mysqlConnections.Add(new MySQL_Connection("192.168.12.243", "concentrador", "econect", "123456") { IPName = "21 - PII" });
            mysqlConnections.Add(new MySQL_Connection("192.168.13.243", "concentrador", "econect", "123456") { IPName = "22 - JJ" });
            mysqlConnections.Add(new MySQL_Connection("192.168.14.243", "concentrador", "econect", "123456") { IPName = "23 - TROPICAL" });
            mysqlConnections.Add(new MySQL_Connection("192.168.15.243", "concentrador", "econect", "123456") { IPName = "24 - JARAGUA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.18.243", "concentrador", "econect", "123456") { IPName = "26 - SERRANO" });
            mysqlConnections.Add(new MySQL_Connection("192.168.16.243", "concentrador", "econect", "123456") { IPName = "27 - HM" });
            mysqlConnections.Add(new MySQL_Connection("192.168.17.243", "concentrador", "econect", "123456") { IPName = "28 - BR040" });
            mysqlConnections.Add(new MySQL_Connection("192.168.4.253", "concentrador", "econect", "123456") { IPName = "29 - DC TITO" });
            mysqlConnections.Add(new MySQL_Connection("192.168.12.253", "concentrador", "econect", "123456") { IPName = "31 - DESTINO PII" });
            mysqlConnections.Add(new MySQL_Connection("192.168.9.253", "concentrador", "econect", "123456") { IPName = "32 - BRIGADEIRO" });
            mysqlConnections.Add(new MySQL_Connection("192.168.1.242", "concentrador", "econect", "123456") { IPName = "33 - DC DULCE" });
            mysqlConnections.Add(new MySQL_Connection("192.168.19.243", "concentrador", "econect", "123456") { IPName = "34 - ST LUZIA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.24.243", "concentrador", "econect", "123456") { IPName = "35 - MANGABEIRA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.23.243", "concentrador", "econect", "123456") { IPName = "36 - ITABIRA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.28.243", "concentrador", "econect", "123456") { IPName = "37 - AMV" });
            mysqlConnections.Add(new MySQL_Connection("192.168.22.243", "concentrador", "econect", "123456") { IPName = "38 - JATAI" });
            mysqlConnections.Add(new MySQL_Connection("192.168.25.243", "concentrador", "econect", "123456") { IPName = "39 - IPATINGA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.30.243", "concentrador", "econect", "123456") { IPName = "40 - SABARA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.26.243", "concentrador", "econect", "123456") { IPName = "41 - BETANIA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.29.243", "concentrador", "econect", "123456") { IPName = "42 - UBERABA" });
            mysqlConnections.Add(new MySQL_Connection("192.168.44.243", "concentrador", "econect", "123456") { IPName = "44 - JACUI" });
            mysqlConnections.Add(new MySQL_Connection("192.168.12.242", "concentrador", "econect", "123456") { IPName = "98 - BEBIDAS P2" });
            mysqlConnections1.Add(new MySQL_Connection("192.168.28.1", "pdv", "econect", "123456") { IPName = "LOJA 28 - PDV 01" });
            mysqlConnections1.Add(new MySQL_Connection("192.168.28.2", "pdv", "econect", "123456") { IPName = "LOJA 28 - PDV 02" });
            
            // Configurando o DataGrid
            DataGridView1.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Data futura não permitida");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private ToolStripProgressBar progressBar;
        private void button1_Click(object sender, EventArgs e)
        {

            // Criando uma tabela para armazenar os resultados
            DataTable results = new DataTable();
            results.Columns.Add("IP_ADRESS", typeof(string));
            results.Columns.Add("COUNT(*)_", typeof(int));
            results.Columns.Add("Status", typeof(string));
            results.Columns.Add("IP_NAME", typeof(string)).SetOrdinal(0);

            // Configurar a ProgressBar
            toolStripProgressBar1.Maximum = mysqlConnections.Count;
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Value = 0;

            // Definindo a quantidade de conexões a serem realizadas
            int totalConnections = mysqlConnections.Count;
            
            // Executando a consulta em cada banco MySQL e adicionando os resultados à tabela
            foreach (MySQL_Connection mysql in mysqlConnections)
            {
                using (MySqlConnection connection = new MySqlConnection(mysql.ConnectionString))
                {
                    try
                    {

                        connection.Open();

                        string data_movimento = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                        string query = "SELECT COUNT(*) FROM exp_imp_movimento WHERE data_movimento= @data_movimento AND numero_cupom <>0 AND codigo_operador<>0 AND situacao_movimento=1;";
                        toolStripProgressBar1.Value++;

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {

                            cmd.Parameters.AddWithValue("@data_movimento", data_movimento);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    DataRow row = results.NewRow();
                                    row["IP_ADRESS"] = mysql.Server;
                                    row["COUNT(*)_"] = reader.GetInt32(0);
                                    row["status"] = "Conexao bem sucedida";
                                    row["IP_NAME"] = mysql.IPName;
                                    results.Rows.Add(row);

                                }
                                connection.Close();
                            }
                            connection.Close();
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        DataRow row = results.NewRow();
                        row["IP_ADRESS"] = mysql.Server;
                        row["Status"] = "Falha na conexao" + ex.Message;
                        results.Rows.Add(row);
                    }
                }

                // Exibindo os resultados no DataGrid
                DataGridView1.DataSource = results;


            }

        }

        // Classe para armazenar os dados de conexão para cada banco MySQL
        public class MySQL_Connection
        {
            public string Server { get; set; }
            public string IP { get; set; }
            public string Database { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string IPName { get; set; }

            public MySQL_Connection(string server, string database, string username, string password)
            {
                Server = server;
                IP = IP;
                Database = database;
                Username = username;
                Password = password;
            }

            public string ConnectionString
            {
                get
                {
                    return "Server=" + Server + ";Database=" + Database + ";Uid=" + Username + ";Pwd=" + Password + ";";
                }
            }
        }

        DataTable results1 = new DataTable();


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("LOJA 02");
            checkedListBox1.Items.Add("LOJA 04");
            checkedListBox1.Items.Add("LOJA 07");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Criando uma tabela para armazenar os resultados
            DataTable results1 = new DataTable();
            results1.Columns.Add("IP_ADRESS", typeof(string));
            results1.Columns.Add("COUNT(*)_", typeof(int));
            results1.Columns.Add("Status", typeof(string));
            results1.Columns.Add("IP_NAME", typeof(string)).SetOrdinal(0);

            // Configurar a ProgressBar
            toolStripProgressBar1.Maximum = mysqlConnections1.Count;
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Value = 0;

            // Definindo a quantidade de conexões a serem realizadas
            int totalConnections = mysqlConnections1.Count;

            // Executando a consulta em cada banco MySQL e adicionando os resultados à tabela
            foreach (MySQL_Connection mysql in mysqlConnections1)
            {
                using (MySqlConnection connection = new MySqlConnection(mysql.ConnectionString))
                {
                    try
                    {

                        connection.Open();

                        string data_movimento = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                        string query = "SELECT COUNT(*) FROM exp_imp_movimento WHERE data_movimento= @data_movimento AND numero_cupom <>0 AND codigo_operador<>0 AND situacao_movimento=1;";
                        toolStripProgressBar1.Value++;

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {

                            cmd.Parameters.AddWithValue("@data_movimento", data_movimento);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    DataRow row = results1.NewRow();
                                    row["IP_ADRESS"] = mysql.Server;
                                    row["COUNT(*)_"] = reader.GetInt32(0);
                                    row["status"] = "Conexao bem sucedida";
                                    row["IP_NAME"] = mysql.IPName;
                                    results1.Rows.Add(row);

                                }
                                connection.Close();
                            }
                            connection.Close();
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        DataRow row = results1.NewRow();
                        row["IP_ADRESS"] = mysql.Server;
                        row["Status"] = "Falha na conexao" + ex.Message;
                        results1.Rows.Add(row);
                    }
                }

                // Exibindo os resultados no DataGrid
                dataGridView2.DataSource = results1;


            }

        }

        
    }
}