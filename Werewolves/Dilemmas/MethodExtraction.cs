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
                totalSize += TotalFileSizeInFiles(Directory.GetFiles(directory));
            }
            
            return totalSize;
        }

        private static long TotalFileSizeInFiles(string[] files)
        {
            long totalSize = 0;

            foreach(var file in files)
            {
                totalSize += new FileInfo(file).Length;
            }

            return totalSize;
        }
    }
}
