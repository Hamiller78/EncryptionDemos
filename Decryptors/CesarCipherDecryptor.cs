using CryptoAlgorithms.Encryptors;
using CryptoAlgorithms.Interfaces;

namespace CryptoAlgorithms.Decryptors
{
    public class CesarCipherBruteForceDecryptor : BaseDecryptor
    {
        protected override string Decrypt(string encryptedText, string expectedText)
        {
            CesarCipherEncryptor encryptor = new();
            int keySpaceSize = encryptor.KeySpaceSize;
            for (int i = 0; i < keySpaceSize; i++)
            {
                string key = (keySpaceSize - i).ToString().Trim();
                string decryptedText = encryptor.RunEncryption(encryptedText, key);
                if (decryptedText == expectedText)
                {
                    return i.ToString().Trim();
                }
            }

            throw new KeyNotFoundException("CesarCipherDecryptor tried all possible keys without success.");
        }
    }
}
