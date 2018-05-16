using System;
using System.Collections.Generic;

namespace WebTavern.Models
{
    public class DrinkDetails
    {
        public Drink Drink { get; set; }
        public List<String> Ingredients { get; set; }
    }
}