using System;
using System.Collections.Generic;
using System.Text;

namespace Werewolves.Dilemmas
{
    public class Var1
    {
        private readonly Dictionary<Guid, List<string>> _bookIdTagsMap;

        public Var1(Dictionary<Guid, List<string>> bookIdTagsMap)
        {
            _bookIdTagsMap = bookIdTagsMap;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach(var tags in _bookIdTagsMap)
            {
                result.Append(string.Join(", ", tags.Value));
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }

    public class Var2
    {
        private readonly Dictionary<Guid, List<string>> _bookIdTagsMap;

        public Var2(Dictionary<Guid, List<string>> bookIdTagsMap)
        {
            _bookIdTagsMap = bookIdTagsMap;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (KeyValuePair<Guid, List<string>> tags in _bookIdTagsMap)
            {
                result.Append(string.Join(", ", tags.Value));
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
