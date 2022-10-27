// Andrew Nilsson
// 10/27/22
// Reverse It - Endpoint
// A webapi that takes an input and reverses it and returns the reversed string
// Peer Review by - Caroline Hana - The code works and runs well. Good job on ur revers i was't able to break it. :D


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_ReverseItEndpoint.Controllers
{
    [Route("[controller]")]
    public class ReverseItController : Controller
    {
        [HttpGet]
        [Route("Reverse/{input}")]
        public string Reverse(string input)
        {
            // Declares a char array and initializes it by converting the string input using ToCharArray method
            char[] nameArray = input.ToCharArray();
            // Reverse method for arrays
            Array.Reverse(nameArray);
            // Declares a string and initializes it with the reversed array
            string reverseString = new string(nameArray);

            return reverseString;
        }
    }
}