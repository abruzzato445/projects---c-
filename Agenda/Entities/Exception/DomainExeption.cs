using System;

namespace Agenda.Entities.Exeption
{
    class DomainExeption : ApplicationException
    {
        public DomainExeption(string message) : base(message)
        {
        }
    }
}
