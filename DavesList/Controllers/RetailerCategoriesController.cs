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
        public async Task<IActionResult> GetAllRetailerCategoriesAsync()
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
        public async Task<IActionResult> GetSingleRetailerCategoryAsync(int id)
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

        public RetailerCategoriesController(DataContext context) : base(context)
        {
        }
    }
}
