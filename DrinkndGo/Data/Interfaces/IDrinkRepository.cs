using DrinkndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkndGo.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PreferredDrinks { get; set; }
        Drink GetDrinkById(int id);
    }
}
