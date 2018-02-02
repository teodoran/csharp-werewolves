using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Werewolves.Dilemmas
{
    class Linq
    {
        private readonly List<string> _items;

        public Linq(List<string> items)
        {
            _items = items;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var item in _items)
            {
                if(item != null && item.Contains("CX"))
                {
                    result.Append(item);
                }
            }

            return result.ToString();
        }
    }
}
