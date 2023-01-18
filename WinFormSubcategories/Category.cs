using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSubcategories
{
    class Category
    {
        public string Name { get; set; }
        public List<Subcategory> Subcategories { get; set; }

        public Category() { }
       
       
    }
}
