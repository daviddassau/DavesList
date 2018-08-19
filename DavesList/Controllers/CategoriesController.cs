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
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
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
        public async Task<IActionResult> Get(int id)
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

        [HttpPost]
        public async Task<IActionResult> Post(int id, Category category)
        {
            try
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();

                return Ok(category);
            }
            catch (Exception e)
            {
                LogException(e);
                return BadRequest($"{e}");
            }
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Category category)
        //{
        //    try
        //    {
        //        var currentCategory = await _context.Categories.FirstOrDefaultAsync();

        //        _context.Entry(currentCategory).CurrentValues.SetValues(category);
        //        await _context.SaveChangesAsync();

        //        return Ok(category);
        //    }
        //    catch (Exception e)
        //    {
        //        LogException(e);
        //        return BadRequest($"{e}");
        //    }
        //}

        //[HttpDelete]
        //public async Task<IActionResult> Delete()
        //{

        //}

        public CategoriesController(DataContext context) : base(context)
        {
        }
    }
}