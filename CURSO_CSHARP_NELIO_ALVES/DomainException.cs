using System;

namespace CURSO_CSHARP_NELIO_ALVES
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}