using System;
using System.Collections.Generic;
using System.Text;

namespace Werewolwes.Examples
{
    class Var
    {
        //private readonly Dictionary<Guid, List<string>> bookIdCategoriesMap = new Di

        /*
         BookId = ølasdf234ølkjasdflh3
         Cateogies = List<string> {"Roman", "Spenning", "Pre-teen", "Amazone reccomended"}
          
             */


        private static string ToString1(Dictionary<Guid,List<string>> inputs)
        {
            var result = new StringBuilder();

            foreach(var input in inputs)
            {
                result.Append(string.Join(",", input.Value));
            }

            return result.ToString();
        }

        private static string ToString2(Dictionary<Guid, List<string>> inputs)
        {
            StringBuilder result = new StringBuilder();

            foreach (KeyValuePair<Guid, List<string>> input in inputs)
            {
                result.Append(string.Join(",", input.Value));
            }

            return result.ToString();
        }
    }
}
