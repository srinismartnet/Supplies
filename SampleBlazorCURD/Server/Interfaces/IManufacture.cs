using SampleBlazorCURD.Shared;

namespace SampleBlazorCURD.Server.Interfaces
{
    public interface IManufacture
    {
        public List<ManufacturingCompany> GetDetails();
        public void AddManufacture(ManufacturingCompany manufacturing);
        public void UpdateManufactureDetails(ManufacturingCompany manufacturing);
        public ManufacturingCompany GetmanufactureData(int id);
        public void DeleteManufacture(int id);
    }
}
