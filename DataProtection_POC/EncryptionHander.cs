using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DataProtection_POC
{
    public interface IEncryptionHandler
    {
        string GetEncryption(string dataString);
    }

    public class EncryptionHander : IEncryptionHandler
    {
        public string GetEncryption(string dataString)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDataProtection();
            var services = serviceCollection.BuildServiceProvider();

            var instance = ActivatorUtilities.CreateInstance<EncryptionClass>(services);
            return instance.RunSample(dataString);
        }
    }
}
