using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class ShelfRepository:GenericRepository<Shelf>
    {
        public ShelfRepository():base() { }
        public ShelfRepository(SupermarketContext context) : base(context) { }
        public override Task<Shelf> Add(Shelf entity)
        {
            return base.Add(entity);
        }
    }
}
