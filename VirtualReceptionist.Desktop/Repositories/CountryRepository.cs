using System.Collections.Generic;
using System.Data;
using VirtualReceptionist.Desktop.Models;
using VirtualReceptionist.Desktop.Repositories.MySQLConnection;

namespace VirtualReceptionist.Desktop.Repositories
{
    public class CountryRepository
    {
        private readonly Database database;
        private readonly List<Country> countries;

        public CountryRepository()
        {
            database = Database.GetInstance();
            countries = new List<Country>();
        }

        private void UploadCountriesList()
        {
            const string sql = "SELECT * FROM country";
            var dataTable = database.Dql(sql);

            foreach (DataRow row in dataTable.Rows)
            {
                var country = new Country
                {
                    Name = row["CountryName"].ToString()
                };

                countries.Add(country);
            }
        }

        public IEnumerable<Country> GetCountries()
        {
            if (countries.Count == 0)
            {
                UploadCountriesList();
            }

            return countries;
        }
    }
}
