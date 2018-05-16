using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTavern.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}