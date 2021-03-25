using Npgsql;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Atendimento : Form
    {
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
    }
}
