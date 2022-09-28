using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using System.Xml.Schema;

namespace HTTP5111_Assignment1_MichelleParlevliet.Controllers
{
    
    public class AssignmentController : ApiController
 
    {
        /// <summary>
        /// Question 1: Return input plus 10
        /// </summary>
        /// <param name="Input">User input</param>
        /// <returns>The sum of the input plus 10</returns>
        /// <example>
        /// GET localhost/api/assignment/addten/21 -> 31
        /// GET localhost/api/assignment/addten/0 -> 10
        /// GET localhost/api/assignment/addten/-9 -> 1
        /// </example>
        
        [HttpGet]
        [Route("api/assignment/addten/{input}")]
        public int AddTen(int Input)
        {
            int Total = Input + 10;
            return Total;
        }

        /// <summary>
        /// Question 2: Returns the input squared
        /// </summary>
        /// <param name="Input">User input</param>
        /// <returns>The sum of the input squared</returns>
        /// <example>
        /// GET localhost/api/assignment/square/2 -> 4
        /// GET localhost/api/assignment/square/-2 -> 4
        /// GET localhost/api/assignment/square/10 -> 100
        /// </example>

        [HttpGet]
        [Route("api/assignment/square/{input}")]

        public int Square(int Input)
        {
            int Total = Input * Input;
            return Total;
        }

        /// <summary>
        /// Question 3: Returns a greeting
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST localhost/api/greeting -> "Hello World!"
        /// </example>
        
        [HttpPost]
        [Route("api/assignment/greeting")]

        public string Greeting()
        {
            return "Hello World!";
        }


        /// <summary>
        /// Question 4: Returns a greeting to a specified number of people
        /// </summary>
        /// <param name="Input"></param>
        /// <returns>"Greetings to {Input number} of people!"</returns>
        /// <example>
        /// GET localhost/api/assignment/greeting/3 -> "Greetings to 3 people!"
        /// GET localhost/api/assignment/greeting/6 -> "Greetings to 6 people!"
        /// GET localhost/api/assignment/greeting/0 -> "Greetings to 0 people!"
        /// </example>

        [HttpGet]
        [Route("api/assignment/greeting/{input}")]

        public string Greeting(string Input)
        {
            string Message = "Greetings to " + Input + " people!";
            return Message;
        }

        /// <summary>
        /// Question 5: Applies 4 mathematical operations to an input
        /// </summary>
        /// <param name="Input">User input</param>
        /// <returns>The sum of the input divided by 2, added to 20, multiplied by 2, and subtracted 4</returns>
        /// <example>
        /// GET localhost/api/assignment/numbermachine/10 -> 46
        /// GET localhost/api/assignment/numbermachine/-5 -> 32
        /// GET localhost/api/assignment/numbermachine/30 -> 66
        /// </example>
        [HttpGet]
        [Route("api/assignment/numbermachine/{input}")]

        public int NumberMachine(int Input)
        {
            int Total = ((Input/2) + 20) * 2 - 4;
            return Total;
        }

        /// <summary>
        /// Question 6: Returns string stating the breakdown of hosting cost
        /// </summary>
        /// <param name="Days">Number of days since the beginning of the hosting</param>
        /// <returns>
        /// "# of fortnights at $5.50/FN = $#"
        /// "HST 13% = $# CAD"
        /// "Total = $# CAD"
        /// </returns>
        /// <example>
        /// GET localhost/api/assignment/hostingcost/0 -> 
        ///     "1 of fortnights at $5.50/FN = $5.50"
        ///     "HST 13% = $0.72 CAD"
        ///     "Total = $6.22 CAD"
        /// </example>

        [HttpGet]
        [Route("api/assignment/hostingcost/{days}")]

        public IEnumerable<string> HostingCost(int Days)
        {
            int Fortnights = (Days / 14) + 1;
            double Subtotal = Fortnights * 5.50;
            double Tax = Subtotal * 0.13;
            double Total = Subtotal + Tax;

            return new string[]
            {
                Fortnights + " fortnights at $5.50/FN = $" + Subtotal + " CAD",
                "HST 13% = $" + Tax + " CAD",
                "Total = $" + Total + " CAD"
            };
        }


    }
}
