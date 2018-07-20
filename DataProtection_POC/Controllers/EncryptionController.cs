using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DataProtection_POC.Controllers
{
    public class EncryptionController : Controller
    {
        private readonly IEncryptionHandler _encryptionHandler;

        public EncryptionController(IEncryptionHandler encryptionHandler)
        {
            _encryptionHandler = encryptionHandler;
        }

        /// <summary>
        /// Encrypts the given string
        /// </summary>
        /// <response code="200">Returns the encryption of the string</response>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [Route("{dataString}")]
        public IActionResult GetEncryption(string dataString)
        {
            var res = _encryptionHandler.GetEncryption(dataString);
            return Json(res);
        }
    }
}