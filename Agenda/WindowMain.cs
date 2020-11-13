using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class wMain : Form
    {
        private string connextion = @"Port=5433;Host=localhost;Database=main_db;Username=postgres;Password=Mbc74586";

        public wMain()
        {
            InitializeComponent();
        }

        //save
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Clients client in ListClient.Items)
            {
                client.InsertNewClient(connextion);
            }
            ListClient.Items.Clear();
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Clients client = new Clients(txtbox_name.Text, Convert.ToInt64(txtbox_telefone.Text), txtbox_observacao.Text);
            ListClient.Items.Add(client);
            clearCamps();
        }

        private void clearCamps()
        {
            txtbox_name.Clear();
            txtbox_observacao.Clear();
            txtbox_telefone.Clear();
        }

        //remove
        private void button2_Click(object sender, EventArgs e)
        {
            ListClient.Items.Remove(ListClient.SelectedItem);
        }

        private void wMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dbDataSet.clientes);
        }

        private void tBoxFilterClient_KeyUp(object sender, KeyEventArgs e)
        {
            filterClient();
        }
        
        private void filterClient()
        {
            Clients clients = new Clients();
            clients.FilterClient(connextion, tBoxFilterClient.Text, dgv_Clientes);
        }

        private void tBoxFilterClient_TextChanged(object sender, EventArgs e)
        {
        }

        private void bttn_Refresh_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.SelectClient(connextion, dgv_Clientes);
        }
    }
}
