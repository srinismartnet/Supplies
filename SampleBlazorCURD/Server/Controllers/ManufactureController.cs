using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleBlazorCURD.Server.Interfaces;
using SampleBlazorCURD.Shared;

namespace SampleBlazorCURD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufactureController : ControllerBase
    {
        private readonly IManufacture _Manufacture;

        public ManufactureController(IManufacture manufacture)
        {
            _Manufacture = manufacture;
        }

        [HttpGet]
        public async Task<List<ManufacturingCompany>> Get()
        {
            return await Task.FromResult(_Manufacture.GetDetails());
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ManufacturingCompany manufacturing = _Manufacture.GetmanufactureData(id);
            if (manufacturing != null)
            {
                return Ok(manufacturing);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(ManufacturingCompany manufacturing)
        {
            _Manufacture.AddManufacture(manufacturing);
        }

        [HttpPut]
        public void Put(ManufacturingCompany manufacturing)
        {
            _Manufacture.UpdateManufactureDetails(manufacturing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _Manufacture.DeleteManufacture(id);
            return Ok();
        }
    }
}
