using Microsoft.EntityFrameworkCore;
using SampleBlazorCURD.Server.Interfaces;
using SampleBlazorCURD.Server.Models;
using SampleBlazorCURD.Shared;

namespace SampleBlazorCURD.Server.Services
{
    public class Manufacture : IManufacture
    {
        readonly DatabaseContext _dbContext = new();

        public Manufacture(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddManufacture(ManufacturingCompany manufacturing)
        {
            try
            {
                _dbContext.Companies.Add(manufacturing);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteManufacture(int id)
        {
            try
            {
                ManufacturingCompany? manufacturing = _dbContext.Companies.Find(id);
                if (manufacturing != null)
                {
                    _dbContext.Companies.Remove(manufacturing);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<ManufacturingCompany> GetDetails()
        {
            try
            {
                return _dbContext.Companies.OrderByDescending(x=>x.Id).ToList();
            }
            catch
            {
                throw;
            }
        }

        public ManufacturingCompany GetmanufactureData(int id)
        {
            try
            {
                ManufacturingCompany? manufacturing = _dbContext.Companies.Find(id);
                if (manufacturing != null)
                {
                    return manufacturing;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateManufactureDetails(ManufacturingCompany manufacturing)
        {
            try
            {
                _dbContext.Entry(manufacturing).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
