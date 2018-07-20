using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;

namespace DataProtection_POC
{
    public class EncryptionClass
    {
        private readonly IDataProtector _protector;

        public EncryptionClass(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Jitendra.EncryptionString.v1");
        }
        public string RunSample(string dataString)
        {
            return _protector.Protect(dataString);
        }
    }
}
