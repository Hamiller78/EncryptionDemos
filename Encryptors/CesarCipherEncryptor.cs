using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlgorithms.Encryptors
{
    public class CesarCipherEncryptor : BaseEncryptor
    {
        const string _charset = "abcdefghijklmnopqrstuvwxyzäöüßABCDEFGHIJKLMNOPQRSTUVWXYZÄÖÜ";
        protected override string Encrypt(string inputText, string key)
        {
            int shiftNumber = KeyStringToShiftNumber(key);
            string outputText = string.Empty;
            for (int i=0; i<inputText.Length; i++)
            {
                int charIndex = _charset.IndexOf(inputText[i]);
                int newIndex = (charIndex + shiftNumber) % _charset.Length;
                outputText += _charset[newIndex];
            }
            return outputText;
        }

        private int KeyStringToShiftNumber(string keyString)
        {
            return int.Parse(keyString);
        }
    }
}
