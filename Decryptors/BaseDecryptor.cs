using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlgorithms.Decryptors
{
    public class BaseDecryptor
    {
        public long TimeInMsForLastRun
        {
            get { return _timeForLastRun; }
        }
        private long _timeForLastRun;

        protected virtual string Decrypt(string inputText, string key)
            => throw new NotImplementedException("Decrypt method in base class should not be called.");

        public string RunDecryption(string encryptedText, string expectedText)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            string outputText = Decrypt(encryptedText, expectedText);

            stopwatch.Stop();
            _timeForLastRun = stopwatch.ElapsedMilliseconds;

            return outputText;
        }
    }
}
