using DrinkndGo.Data.Interfaces;
using DrinkndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkndGo.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
       public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
                         new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                     };
            }
        }
    }
}
