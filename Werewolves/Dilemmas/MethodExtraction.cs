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

            foreach (var directory in directories)
            {
                TotalFileSizeInFiles(Directory.GetFiles(directory), ref totalSize);
            }

            return totalSize;
        }

        private static void TotalFileSizeInFiles(string[] files, ref long totalSize)
        {
            foreach (var file in files)
            {
                totalSize += new FileInfo(file).Length;
            }
        }
    }
}
