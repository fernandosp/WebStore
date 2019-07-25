using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain;
using WebStore.Repository.Interface;
using Dapper;
using System.Data.SqlClient;
using WebStore.Repository.Utilities;

namespace WebStore.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SqlConnection _connection;
        public Repository() 
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public List<TEntity> Entities { get; set; }

        public void Add(TEntity obj)
        {
            var parameters = (object)Mapping(obj);
            Entities.Add(obj);
        }

        public List<TEntity> GetAll()
        {
            return _connection.Query<TEntity>($@"Select * from {nameof(TEntity)}").AsList();
        }

        internal virtual dynamic Mapping(TEntity item)
        {
            return item;
        }

        
    }
}
