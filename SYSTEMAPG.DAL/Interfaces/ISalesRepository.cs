using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEMAPGEntity;

namespace SYSTEMAPG.DAL.Interfaces
{
    public interface ISalesRepository : IGenericRepository<Sale>
    {
        Task<Sale> Register(Sale entity);
        Task<List<SaleDetail>> Report(DateTime startDate, DateTime endingDate);
    }
}
