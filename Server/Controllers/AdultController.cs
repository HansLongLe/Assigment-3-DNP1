using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Data.DataAccess;
using Server.Data.DataAccess.DatabaseAccess;
using Server.Data.Models;

namespace Server.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class AdultController : ControllerBase
    {
        private readonly IAdultDatabaseRepository _adultRepository;
        
        public AdultController(DataFactory dataFactory)
        {
            _adultRepository = dataFactory.AdultDatabaseRepository;
        }

        [HttpGet]
        public ActionResult GetAdults()
        {
            try
            {
                return Ok(_adultRepository.GetAdults());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        

        [HttpPost]
        public async Task<ActionResult<Adult>> CreateAdult(Adult adult)
        {
            try
            {
                if (adult == null)
                {
                    return BadRequest();
                }

                adult.Id = _adultRepository.GetAdults().Count;
                await _adultRepository.AddAdult(adult);
                return CreatedAtAction(nameof(GetAdults), new {adult.Id});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}