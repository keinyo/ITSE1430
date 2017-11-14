using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    /// <summary>Provides an implementation of <see cref="IProductDatabase"/> using SQL Server
    /// 
    /// </summary>
    public class SqlProductDatabase : ProductDatabase
    {


        public SqlProductDatabase( string connectionString )
        {
            _connectionString = connectionString;
        }
        protected override Product AddCore( Product product )
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            using (var connection = OpenDatabase())
            {
                //connection.CreateCommand();
                var cmd = new SqlCommand("GetAllProducts", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                var products = new List<Product>();
                using (var reader = cmd.ExecuteReader())
                {
                    //reader.GetName(0);
                    //reader.GetFieldType(1);
                    //Convert.ToInt32(reader["Id"]);

                    while(reader.Read())
                    {
                        var product = new Product() {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Name = reader.GetFieldValue<string>(1),
                            Description = reader.GetString(3),
                            Price = reader.GetDecimal(2),
                            IsDiscontinued = reader.GetBoolean(4),
                        };
                    }
                };

                    return products;
            };
        }

        protected override Product GetCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override Product UpdateCore( Product existing, Product newItem )
        {
            throw new NotImplementedException();
        }

        private SqlConnection OpenDatabase ()
        {

            var connection = new SqlConnection(_connectionString);
                connection.Open();
            return connection;
        }

        private string _connectionString;
    }
}
