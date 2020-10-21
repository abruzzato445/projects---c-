using System;
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
            Clients client = new Clients(txtbox_name.Text, Convert.ToInt64(txtbox_telefone.Text), txtbox_observacao.Text);
            client.InsertNewClient(connextion);
        }
    }
}
