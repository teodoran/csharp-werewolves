using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Werewolves.Dilemmas
{
    class Linq1
    {
        private readonly List<string> _items;

        public Linq1(List<string> items)
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

    class Linq2
    {
        private readonly List<string> _items;

        public Linq2(List<string> items){
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
