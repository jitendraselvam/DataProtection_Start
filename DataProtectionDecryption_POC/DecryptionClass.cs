using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;

namespace DataProtectionDecryption_POC
{
    public class DecryptionClass
    {
        private readonly IDataProtector _protector;

        public DecryptionClass(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Jitendra.EncryptionString.v1");
        }
        public string RunSample(string encryptedString)
        {
            return _protector.Unprotect(encryptedString);
        }
    }
}
