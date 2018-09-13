using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DavesList.Data;
using DavesList.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DavesList.Controllers
{
    [Authorize]
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : BaseController
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            try
            {
                var categories = await _context.Categories.ToListAsync();

                return Ok(categories);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleCategoryAsync(int id)
        {
            try
            {
                var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

                return Ok(category);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        public CategoriesController(DataContext context) : base(context)
        {
        }
    }
}