using System;
using System.Windows.Forms;
using Agenda.Entities.Exeption;
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
            if (Name == null || Observacao == null && Telefone.ToString().Length < 11)

                throw new DomainExeption("Register Error: Incomplete Data Filling. ");

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteClient(string conextion)
        {

        }
        public void UpdateListClient(string conextion)
        {

        }
        public void SelectClient(string conextion)
        {

        }
    }
}
