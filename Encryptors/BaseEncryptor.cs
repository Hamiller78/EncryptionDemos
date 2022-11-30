using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlgorithms.Encryptors
{
    public class BaseEncryptor
    {
        public long TimeInMsForLastRun
        {
          get { return _timeForLastRun; }
        }
        private long _timeForLastRun;

        protected virtual string Encrypt(string inputText, string key)
            => throw new NotImplementedException("Encrypt method in base class should not be called.");

        public string RunEncryption(string inputText, string key)
        {
            Stopwatch stopwatch = new ();
            stopwatch.Start();

            string outputText = Encrypt(inputText, key);

            stopwatch.Stop();
            _timeForLastRun = stopwatch.ElapsedMilliseconds;

            return outputText;
        }

    }
}
