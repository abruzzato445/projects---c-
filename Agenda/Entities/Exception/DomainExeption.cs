using System;
using System.Windows.Forms;

namespace Agenda.Entities.Exeption
{
    class DomainExeption : ApplicationException
    {
        public DomainExeption(string message) : base(message)
        {
            MessageBox.Show("An error occurred" + message);
        }
    }
}
