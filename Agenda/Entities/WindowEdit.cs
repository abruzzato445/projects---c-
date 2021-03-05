using System;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace Agenda.Entities
{
    public partial class WindowEdit : Form
    {
        private string query;
        private int id;
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string Observacao { get; set; }
        public string Idade { get; set; }
        public DateTime DataRegistro { get; set; }

        public WindowEdit()
        {
            InitializeComponent();
        }

        public void SelectClient(string connextion, int idClient)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connextion);
            query = $@"SELECT * FROM public.clientes WHERE id = {idClient};";
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dtr;
            try
            {
                conn.Open();
                dtr = comm.ExecuteReader();
                dtr.Read();
                Nome = dtr.GetString(0);
                Telefone = dtr.GetInt64(2);
                Observacao = dtr.GetString(1);
                tBoxName.Text = Nome;
                tBoxTel.Text = Telefone.ToString();
                tBoxObs.Text = Observacao;
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("An error occured in db: " + e.Message);
            }
            finally
            {
                id = idClient;
                conn.Close();
            }
        }

        public void UpdateClient()
        {
            Clients clients = new Clients();
            NpgsqlConnection conn = new NpgsqlConnection(clients.connextion);
            query = $@"UPDATE public.clientes SET nome = '{tBoxName.Text}', telefone = {Convert.ToInt64(tBoxTel.Text)}, observacao = '{tBoxObs.Text}' WHERE id = {id};";
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                NpgsqlDataAdapter ndta = new NpgsqlDataAdapter(comm);
                ndta.Fill(dt);
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("An Erro occurred in db update" + e.Message);
            }
            finally
            {
                MessageBox.Show("Cliente alterado com sucesso! Clique em ATUALIZAR ", "Info System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (tBoxName.Text != Nome || tBoxTel.Text != Telefone.ToString() || tBoxObs.Text != Observacao)
            {
                if(MessageBox.Show("Deseja manter as alterações feitas?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                UpdateClient();
                Close();
            }
            else
            {
                Close();
            }
        }
    }
}
