using Agenda.Entities.Exeption;
using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Agenda
{
    class Clients
    {
        private string Query;
        protected internal string connextion = @"Port=5433;Host=localhost;Database=main_db;Username=postgres;Password=Mbc74586";
        public string Name { get; private set; }
        public long Telefone { get; private set; }
        public string Observacao { get; private set; }

        public Clients()
        {
        }

        public Clients(string name, long telefone, string observacao)
        {
            Name = name;
            Telefone = telefone;
            Observacao = observacao;
        }

        public void InsertNewClient(string connextion)
        {
            Query = $@"INSERT INTO PUBLIC.clientes(nome, observacao, telefone) VALUES ('{Name}', '{Observacao}', {Telefone});";
            NpgsqlConnection conn = new NpgsqlConnection(connextion);
            NpgsqlCommand command = new NpgsqlCommand(Query, conn);
            NpgsqlDataReader dbreader;
            try
            {
                conn.Open();
                dbreader = command.ExecuteReader();
                MessageBox.Show("Cliente salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void FilterClient(string connextion, string nameClient, DataGridView datagridview)
        {
            Query = $@"SELECT * FROM public.clientes WHERE nome = '{nameClient}';";
            NpgsqlConnection conn = new NpgsqlConnection(connextion);
            NpgsqlCommand command = new NpgsqlCommand(Query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                NpgsqlDataAdapter ndta = new NpgsqlDataAdapter(command);
                ndta.Fill(dt);
                datagridview.DataSource = dt;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (nameClient.Length <= 0)
                {
                    SelectClient(connextion, datagridview);
                }
                conn.Close();
            }
        }

        public void SelectClient(string connextion, DataGridView dataGridView)
        {
            Query = @"SELECT * FROM public.clientes;";
            NpgsqlConnection conn = new NpgsqlConnection(connextion);
            NpgsqlCommand command = new NpgsqlCommand(Query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                NpgsqlDataAdapter ndta = new NpgsqlDataAdapter(command);
                ndta.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteClient(string connextion, DataGridView dataGridView)
        {
            DataGridViewRow dgvr;
            dgvr = dataGridView.CurrentRow;
            Query = $@"DELETE FROM public.clientes WHERE (nome, telefone) = ('{dataGridView.Rows[dgvr.Index].Cells[1].Value}', {dataGridView.Rows[dgvr.Index].Cells[2].Value})";
            NpgsqlConnection conn = new NpgsqlConnection(connextion);
            NpgsqlCommand command = new NpgsqlCommand(Query, conn);
            try
            {
                if (MessageBox.Show("Deseja excluir " + dataGridView.SelectedCells[0].Value.ToString()
                    + " ?", "System Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    NpgsqlDataAdapter ndta = new NpgsqlDataAdapter(command);
                    ndta.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Não excluído", "System Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Data Error Delete: " + e.Message);
            }
            finally
            {

                SelectClient(connextion, dataGridView);
                conn.Close();
            }
        }

        public override string ToString()
        {
            return "Nome: " + Name + " | Telefone: " + Telefone + " | Obs: " + Observacao;
        }
    }
}
