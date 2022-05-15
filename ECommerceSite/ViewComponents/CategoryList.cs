using Microsoft.AspNetCore.Mvc;
using ECommerceSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSite.ViewComponents
{
    public class CategoryList:ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public CategoryList( ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var category = _db.Categories.ToList();
            return View(category);
        }
    }
}
