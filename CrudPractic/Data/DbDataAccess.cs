using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPractic.Data
{
    public abstract class DbDataAccess<T> : IDisposable
    {
        protected readonly DbProductDish dish;
        protected readonly DbConnection connection;
        protected readonly DbTransaction transaction;

        public object DbProductDishes { get; }
        public object ConfigurationService { get; }

        public DbDataAccess()
        {
            //dish = DbProductDishes.GetDish("DataProduct");
            connection = dish.CreateConnection();
            //connection.ConnectionString = ConfigurationService.Configuration["dataAccessConnectionString"];
        }
        public void Dispose()
        {
            connection.Close();
        }
        public abstract ICollection<T> Select();
        public abstract void Insert(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(Guid index);
    }
}
