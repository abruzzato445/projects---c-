using System;
using System.Collections.Generic;
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
    }
}
