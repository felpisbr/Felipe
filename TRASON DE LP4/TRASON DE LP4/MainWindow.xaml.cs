using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TRASON_DE_LP4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void  Cadastrar()
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;DataBase=test;Uid=root;Pwd="),
                CommandText = "Insert INTO Estudante (Nome, Idade, Sexo, MF, Turma) VALUES (@Nome, @Idade, @Sexo, @MF, @Turma);"
            };

            cmd.Parameters.AddWithValue("@Nome" , txtNome.Text);
            cmd.Parameters.AddWithValue("@Idade" , txtIdade.Text);
            cmd.Parameters.AddWithValue("@Sexo" , txtSexo.Text);
            cmd.Parameters.AddWithValue("@MF" , txtMF.Text);
            cmd.Parameters.AddWithValue("@Turma" , txtTurma.Text);


            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close(); 

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar();
            MessageBox.Show("Cadastrado com sucesso!!!");
        }
    }
}
