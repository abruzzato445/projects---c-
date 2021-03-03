using System;
using System.Windows.Forms;
using Agenda.Entities;
using Agenda.Entities.Exeption;

namespace Agenda
{
    public partial class wMain : Form
    {
        public wMain()
        {
            InitializeComponent();
            tBoxFilterClient.Visible = false;
            bttnRefresh.Visible = false;
        }
        //save
        private void button1_Click(object sender, EventArgs e)
        {
            if (ListClient.Items.Count == 0)
            {
                DomainExeption domainExeption = new DomainExeption("Não foi possível salvar. Nenhum valor a ser salvo.");
                MessageBox.Show(domainExeption.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Clients client in ListClient.Items)
                {
                    client.InsertNewClient(client.connextion);
                    client.SelectClient(client.connextion, dgv_Clientes);
                }
                ListClient.Items.Clear();
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            try
            { 
                if (txtbox_name.Text == "")
                {
                    throw new DomainExeption(" Não foi inserido o nome do cliente. Essa coluna é obrigatória!");
                }
                else if (txtbox_telefone.Text.Length == 0)
                {
                    long telefone = 0;
                    Clients client = new Clients(txtbox_name.Text, telefone, txtbox_observacao.Text);
                    ListClient.Items.Add(client);
                    clearCamps();
                }
                else
                {
                    Clients client = new Clients(txtbox_name.Text, Convert.ToInt64(txtbox_telefone.Text), txtbox_observacao.Text);
                    ListClient.Items.Add(client);
                    clearCamps();
                }
            }
            catch(DomainExeption s)
            {
                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void filterClient()
        {
            Clients clients = new Clients();
            if(cbxFilter.SelectedIndex == 1)
            {
                clients.FilterforTel(clients.connextion, Convert.ToInt64(tBoxFilterClient.Text), dgv_Clientes);
            }
            else
            {
                clients.FilterClient(clients.connextion, tBoxFilterClient.Text, dgv_Clientes);
            }
        }

        private void tBoxFilterClient_TextChanged(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            if (tBoxFilterClient.Text == "")
            {
                clients.SelectClient(clients.connextion, dgv_Clientes);
                bttnRefresh.Visible = true;
            }
            else
            {
                filterClient();
            }
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

        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Clientes.CurrentRow.Selected == true)
            {
                bttnEdit.Visible = true;
                bttnDelet.Visible = true;
            }
            else
            {
                bttnEdit.Visible = false;
                bttnDelet.Visible = false;
            }
        }

        private void cbxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            tBoxFilterClient.Visible = true;
            bttnRefresh.Visible = true;
        }

        private void tBoxFilterClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbxFilter.SelectedIndex == 1 && !char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
                DomainExeption TelExe = new DomainExeption("Não é possível filtrar por letras!");
                MessageBox.Show(TelExe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxFilterClient.Clear();
            }
        }
    }
}
