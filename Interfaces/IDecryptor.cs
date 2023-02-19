﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlgorithms.Interfaces
{
    public interface IDecryptor
    {
        string FindEncryptionKey(string encryptedText, string expectedText);
    }
}
