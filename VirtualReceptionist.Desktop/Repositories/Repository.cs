using VirtualReceptionist.Desktop.Repositories.MySQLConnection;

namespace VirtualReceptionist.Desktop.Repositories
{
    public class Repository
    {
        protected readonly Database Database;

        protected Repository()
        {
            Database = Database.GetInstance();
        }
    }
}
