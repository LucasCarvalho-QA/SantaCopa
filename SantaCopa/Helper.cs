using System;
using System.Collections.Generic;
using System.Text;

namespace SantaCopa
{
    public static class Helper
    {
        public static string ListItems(List<string> list)
        {
            string items = string.Empty;

            foreach (var item in list)
                items += $"\n {item}";
            
            return items;
        }
    }
}
