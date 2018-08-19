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
            try
            {
                var retailers = await _context.Retailers.ToListAsync();

                return Ok(retailers);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var retailer = await _context.Retailers.FirstOrDefaultAsync();

                return Ok(retailer);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(int id, Retailer retailer)
        {
            try
            {
                _context.Retailers.Add(retailer);
                await _context.SaveChangesAsync();

                return Ok(retailer);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        public RetailersController(DataContext context) : base(context)
        {
        }
    }
}
