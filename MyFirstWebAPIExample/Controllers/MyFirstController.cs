using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPIExample.Entities;
using MyFirstWebAPIExample.Providers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstWebAPIExample.Controllers
{
    [Route("api/myFirstCon")]
    [ApiController]
    public class MyFirstController : ControllerBase
    {
        [Route("myFirstAction")]
        [HttpGet]

        public string Display()
        {
            return "Hi World";
        }
        [Route("AddCategory")]
        [HttpGet]
        public string AddCategory()
        {
            MenuCategoryDbContext menu = new MenuCategoryDbContext();
            MenuCategory category = new MenuCategory()
            {
                Category = "Veg",
                Categorydescription = "PureVegetarin"
            };
            menu.menuCategories.Add(category);
            menu.SaveChanges();
            return "AddTheCategories";

        }
        [Route("addNewCategory")]
        [HttpPost]
        public string AddNewCategory([FromBody]MenuCategory category)
        {
            MenuCategoryDbContext menu = new MenuCategoryDbContext();
            menu.menuCategories.Add(category);
            menu.SaveChanges();
            return "AddNewCategory";
        }
        [Route("update")]
        [HttpPut]
        public string UpdateCategory()
        {
            MenuCategoryDbContext dbContext = new MenuCategoryDbContext();
            MenuCategory category = new MenuCategory();
        var update= dbContext.menuCategories.Where(s => s.Id == 3).FirstOrDefault();
            category.Category = "Drinks";
            Console.WriteLine(update);

            dbContext.SaveChanges();
            return "updated";
        }



    }
}
