using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Werewolves.Dilemmas
{
    class ExceptionHandling1 
    {
        public void CopyFile(string fromFile, string toFile) {
            try {
                using(Stream fromStream = File.OpenRead(fromFile))
                using(Stream toStream = File.OpenWrite(toFile))
                {
                    fromStream.CopyTo(toStream);
                }
            }
            catch(IOException ex) {
                var message = $"IO error while copying from {fromFile} to {toFile}.";
                throw new IOException(message, ex);
            }
            catch(Exception ex) {
                var message = $"General error while copying from {fromFile} to {toFile}.";
                throw new IOException(message, ex);
            }
        }
    }

    class ExceptionHandling2 
    {
        public dynamic Log {get; set;}

        public void CopyFile(string fromFile, string toFile) {
            try {
                using(Stream fromStream = File.OpenRead(fromFile))
                using(Stream toStream = File.OpenWrite(toFile))
                {
                    fromStream.CopyTo(toStream);
                }
            }
            catch(IOException ex) {
                var message = $"IO error while copying from {fromFile} to {toFile}.";
                Log.Debug(message);
                throw new IOException(message, ex);
            }
            catch(Exception ex) {
                var message = $"General error while copying from {fromFile} to {toFile}.";
                Log.Debug(message);
                throw new IOException(message, ex);
            }
        }
    }
}
