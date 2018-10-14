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
        public async Task<ActionResult> GetAllRetailersWithCategory()
        {
            try
            {
                var output = await (from r in _context.Retailers
                                    join rc in _context.RetailerCategories on r.Id equals rc.RetailerId
                                    join c in _context.Categories on rc.CategoryId equals c.Id
                                    where r.Id == r.Id
                                    select new { r.Name, r.Location, r.Website, r.Details, r.Photo, c.CategoryName }).ToListAsync();

                return Ok(output);                
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
