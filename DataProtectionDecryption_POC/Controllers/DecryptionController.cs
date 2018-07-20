using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataProtectionDecryption_POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecryptionController : ControllerBase
    {
        private readonly IDecryptionHandler _decryptionHandler;
        public DecryptionController(IDecryptionHandler decryptionHandler)
        {
            _decryptionHandler = decryptionHandler;
        }

        /// <summary>
        /// Decrypts the given string
        /// </summary>
        /// <response code="200">Returns the decryption of the string</response>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [Route("{encryptedString}")]
        public string GetDecryption(string encryptedString)
        {
            var res = _decryptionHandler.GetDecryption(encryptedString);
            return res;
        }
    }
}