using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Werewolves.Dilemmas
{
    class MethodExtraction1
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

    class MethodExtraction2
    {
        public static long TotalFileSizeInDirectories(List<string> directories)
        {
            long totalSize = 0;

            foreach(var directory in directories)
            {
                TotalFileSizeInFiles(Directory.GetFiles(directory), ref totalSize);
            }
            
            return totalSize;
        }

        private static void TotalFileSizeInFiles(string[] files, ref long totalSize)
        {
            foreach(var file in files)
            {
                totalSize += new FileInfo(file).Length;
            }
        }
    }
}
