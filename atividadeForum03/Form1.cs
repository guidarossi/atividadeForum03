using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atividadeForum03
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Crio a estrutura da conexão com o banco de dados e passo os parametros
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadoraveiculos_";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";

            //Realizo a conexão com o banco de dados
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();//Abre a conexão com o banco de dados
                

                MySqlCommand comandomySQL = realizaConexaoBD.CreateCommand();
                comandomySQL.CommandText = "INSERT INTO carro (Marca,idDataLocacao,idEspecificacoes) " +
                    "VALUES('" + txtFabricante.Text + "', '" + txtData.Text + "', '" + txtEspecificacoes.Text + "')";
                comandomySQL.ExecuteNonQuery();

                realizaConexaoBD.Close();//Fecho a conexão com o banco de dados
                MessageBox.Show("Inserido com sucesso");//Exibo mensagem de aviso
                atualizarGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel acessar o banco de dados.");
                Console.WriteLine(ex.Message);         
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            //Crio a estrutura da conexão com o banco de dados e passo os parametros
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadoraveiculos_";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            txtData.Text = "";
            txtEspecificacoes.Text = "";
            txtFabricante.Text = "";

            //Realizo a conexão com o banco de dados
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();
                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * from carro";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridView1.Rows.Clear();//FAZ LIMPEZA DA TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//Fabricante
                    row.Cells[2].Value = reader.GetString(2);//DataLocação
                    row.Cells[3].Value = reader.GetString(3);//Especificações
                    dataGridView1.Rows.Add(row);//ADICIONA UMA LINHA NA TABELA
                }
                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem conexão");
            }

                
        }
    }
}

