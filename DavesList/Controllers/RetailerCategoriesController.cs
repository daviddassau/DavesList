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
            var retailerCategories = await _context.RetailerCategories.ToListAsync();

            return Ok(retailerCategories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var retailerCategory = await _context.RetailerCategories.FirstOrDefaultAsync();

            return Ok(retailerCategory);
        }

        public RetailerCategoriesController(DataContext context) : base(context)
        {
        }
    }
}
