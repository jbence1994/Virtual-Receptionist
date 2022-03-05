using System;

namespace VirtualReceptionist.Desktop.Repositories.MySQLConnection
{
    public sealed class InvalidConnectionTypeException : Exception
    {
        public InvalidConnectionTypeException()
            : base("Érvénytelen adatbázis kapcsolódás típus!")
        {
        }
    }
}
