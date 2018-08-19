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
    [Route("api/retailerCategories")]
    [ApiController]
    public class RetailerCategoriesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var retailerCategories = await _context.RetailerCategories.ToListAsync();

                return Ok(retailerCategories);
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
                var retailerCategory = await _context.RetailerCategories.FirstOrDefaultAsync();

                return Ok(retailerCategory);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(int id, RetailerCategory retailerCategory)
        {
            try
            {
                _context.RetailerCategories.Add(retailerCategory);
                await _context.SaveChangesAsync();

                return Ok(retailerCategory);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        public RetailerCategoriesController(DataContext context) : base(context)
        {
        }
    }
}
