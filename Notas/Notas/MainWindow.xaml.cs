using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Notas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=192.168.28.44;Port=3306;Database=concentrador;Uid=econect;Pwd=123456;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM exp_imp_movimento WHERE data_movimento='20230121' AND numero_cupom <>0 AND codigo_operador<>0 AND situacao_movimento=1;", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
        }
    }
}