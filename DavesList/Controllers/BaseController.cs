using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DavesList.Data;

namespace DavesList.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly DataContext _context;

        public BaseController(DataContext context)
        {
            _context = context;
        }

        protected void LogException(Exception exception)
        {
            // will eventually do something
        }
    }
}
