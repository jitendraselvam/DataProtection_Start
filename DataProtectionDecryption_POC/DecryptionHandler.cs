using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DataProtectionDecryption_POC
{
    public interface IDecryptionHandler
    {
        string GetDecryption(string encryptedString);
    }

    public class DecryptionHandler : IDecryptionHandler
    {
        public string GetDecryption(string encryptedString)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDataProtection();
            var services = serviceCollection.BuildServiceProvider();

            var instance = ActivatorUtilities.CreateInstance<DecryptionClass>(services);
            return instance.RunSample(encryptedString);
        }
    }
}
