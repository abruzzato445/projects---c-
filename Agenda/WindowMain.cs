using System;
using System.Windows.Forms;
using Agenda.Entities;
namespace Agenda
{
    public partial class wMain : Form
    {

        public wMain()
        {
            InitializeComponent();
        }
        //save
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Clients client in ListClient.Items)
            {
                client.InsertNewClient(client.connextion);
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
        //remove List
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
            clients.FilterClient(clients.connextion, tBoxFilterClient.Text, dgv_Clientes);
        }

        private void tBoxFilterClient_TextChanged(object sender, EventArgs e)
        {
            filterClient();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.SelectClient(clients.connextion, dgv_Clientes);
        }

        private void bttnDelet_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.DeleteClient(clients.connextion, dgv_Clientes);
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr;
            dgvr = dgv_Clientes.CurrentRow;
            int id = Convert.ToInt32(dgv_Clientes.Rows[dgvr.Index].Cells[0].Value);
            WindowEdit windowEdit = new WindowEdit();
            Clients clients = new Clients();
            windowEdit.SelectClient(clients.connextion, id);
            windowEdit.Show();
        }
    }
}
