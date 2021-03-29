using Npgsql;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Atendimento : Form
    {
        private string connextion = @"Port=5433;Host=localhost;Database=main_db;Username=postgres;Persist Security Info=True;Password=Mbc74586";
        private string query;
        private int id;

        public Atendimento()
        {
            InitializeComponent();
        }

        public void SelectClientID(string connextion, int idClient)
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
                aName.Text = dtr.GetString(0);
                if(dtr.GetChar(4) == 'A')
                {
                    aIdade.Text = "ADULTO";
                }
                else
                {
                    aIdade.Text = "CRIANÇA";
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("An error occured in db: " + e.Message);
            }
            finally
            {
                id = idClient;
                conn.Close();
            }
        }
        public void InsertAtendiment()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connextion);
            query = $"INSERT INTO PUBLIC.atendimentos(id_cliente, id_service, lastservice) VALUES ({id}, {cbxServico.SelectedIndex + 1}, '{dtpDAT.Value.ToString("yyyy-MM-dd")}');";
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dtr;
            try
            {
                conn.Open();
                dtr = comm.ExecuteReader();
                MessageBox.Show("Atendimento registrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("An error occured in db: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bttnSave_Click(object sender, System.EventArgs e)
        {
            InsertAtendiment();
            Close();
        }
    }
}
