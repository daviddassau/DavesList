using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DavesList.Data;
using DavesList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DavesList.Controllers
{
    [Route("api/retailers")]
    [ApiController]
    public class RetailersController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var retailers = await _context.Retailers.ToListAsync();

            return Ok(retailers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var retailer = await _context.Retailers.FirstOrDefaultAsync();

            return Ok(retailer);
        }

        public RetailersController(DataContext context) : base(context)
        {
        }
    }
}
