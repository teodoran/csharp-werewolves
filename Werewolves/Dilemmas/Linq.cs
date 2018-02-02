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
            var result = _items
                .Where(item => item != null)
                .Where(item => item.Contains("CX"))
                .Aggregate(new StringBuilder(), (builder, item) => builder.Append(item));

            return result.ToString();
        }
    }
}
