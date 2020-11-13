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
                MessageBox.Show("Saved");
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

        public void UpdateListClient(string conextion)
        {
            Query = "UPDATE public.clientes  SET nome =?, observacao =?, telefone =? WHERE<condition>; ";

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
            catch(NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
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
            catch(NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public override string ToString()
        {
            return "Nome: " + Name + " | " + Telefone + " | " + Observacao;
        }
    }
}
