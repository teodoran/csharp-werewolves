using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Werewolves.Dilemmas
{
    class MethodExtraction
    {
        public static long TotalFileSizeInDirectories(List<string> directories)
        {
            long totalSize = 0;

            foreach(var directory in directories)
            {
                foreach(var file in Directory.GetFiles(directory))
                {
                    totalSize += new FileInfo(file).Length;
                }
            }
            
            return totalSize;
        }
    }
}
