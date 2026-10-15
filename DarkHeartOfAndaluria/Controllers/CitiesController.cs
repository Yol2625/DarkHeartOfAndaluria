using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DarkHeartOfAndaluria.Data;

namespace DarkHeartOfAndaluria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly CampaignDbContext _context;
        
        public CitiesController(CampaignDbContext context)
        {
            _context = context;
        }
    }

}
