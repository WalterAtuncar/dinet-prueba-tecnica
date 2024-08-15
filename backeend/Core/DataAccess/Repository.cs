using Dapper.Contrib.Extensions;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionString;

        public Repository(string _connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"[{type.Name}]"; };
            this._connectionString = _connectionString;
        }
        public IEnumerable<T> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);

            }
        }
    }
}
