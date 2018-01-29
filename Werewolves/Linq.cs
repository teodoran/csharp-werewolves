using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Werewolwes.Examples
{
    class Linq
    {
        /*
         Her bør vi sikkert vise frem litt hvordan denne datastrukturen skal se ut
             */


        private static string ToString1(List<string> items)
        {
            var result = new StringBuilder();

            foreach (var item in items)
            {
                if(item != null && item.Contains("CX"))
                {
                    result.Append(item);
                }
            }

            return result.ToString();
        }

        private static string ToString2(List<string> items)
        {
            var result = items
                .Where(item => item != null)
                .Where(item => item.Contains("CX"))
                .Aggregate(new StringBuilder(), (builder, item) => builder.Append(item));

            return result.ToString();
        }
    }
}
