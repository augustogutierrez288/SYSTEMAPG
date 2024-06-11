using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using SYSTEMAPG.DAL.DBContext;
using SYSTEMAPG.DAL.Interfaces;
using SYSTEMAPGEntity;

namespace SYSTEMAPG.DAL.Implementation
{
    public class SalesRepository : GenericRepository<Sale>, ISalesRepository
    {
        private readonly SYSTEMAPGContext _context;

        public SalesRepository(SYSTEMAPGContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Sale> Register(Sale entity)
        {
            Sale generatedSale = new Sale();

            using (var transation = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (SaleDetail sd in entity.SaleDetails)
                    {
                        Product productFound = _context.Products.Where(p => p.ProductId == sd.ProductId).First();
                        productFound.Stock = productFound.Stock - sd.Quantity;
                        _context.Products.Update(productFound);
                    }
                    await _context.SaveChangesAsync();

                    CorrelativeNumber correlative = _context.CorrelativeNumbers.Where(n => n.Management == "sales").First();
                    correlative.LastNumber = correlative.LastNumber + 1;
                    correlative.UpdateDate = DateTime.Now;

                    _context.CorrelativeNumbers.Update(correlative);
                    await _context.SaveChangesAsync();

                    string zeros = string.Concat(Enumerable.Repeat("0", correlative.DigitCount.Value));
                    string salesNumber = zeros + correlative.LastNumber.ToString();
                    entity.SaleNumber = salesNumber;

                    await _context.Sales.AddAsync(entity);

                    generatedSale = entity;

                    transation.Commit();
                }
                catch (Exception ex)
                {
                    transation.Rollback();
                    throw ex;
                }
            }

            return generatedSale;
        }

        public async Task<List<SaleDetail>> Report(DateTime startDate, DateTime endingDate)
        {
            List<SaleDetail> detail = await _context.SaleDetails
                .Include(s => s.Sale)
                .ThenInclude(u => u.UserId)
                .Include(s => s.Sale)
                .ThenInclude(tdv => tdv.DocumentTypeSaleId)
                .Where(sd => sd.Sale.RegistrationDate.Value.Date >= startDate.Date && 
                    sd.Sale.RegistrationDate.Value.Date <= endingDate.Date).ToListAsync();

            return detail;

        }
    }
}
