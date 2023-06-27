using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class CustomerDALImpl : ICustomerDAL
    {
        private NorthwindContext _northwindContext;
        private UnidadDeTrabajo<Customer> unidad;

        public bool Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            IEnumerable<Customer> customers = null;
            using (unidad = new UnidadDeTrabajo<Customer>(new NorthwindContext()))
            {
                customers = unidad.genericDAL.GetAll();


            }

            return customers;
        }

        public bool Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public Customer SingleOrDefault(Expression<Func<Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
