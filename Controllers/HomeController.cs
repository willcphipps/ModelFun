using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelFun.Models;

namespace ModelFun.Controllers {
    public class HomeController : Controller {

        public IActionResult Index () {
            User NewUser = new User () {
                FirstName = "Donnie",
                LastName = "Darko"
            };
            return View (NewUser);
        }

        [HttpGet ("Names")]
        public IActionResult Names () {
            string[] names = new string[] {
                "Sally",
                "Billy",
                "Joey",
                "Moose"
            };
            return View (names);
        }

        [HttpGet ("String")]
        public IActionResult String () {
            string mystring = "Naught of myself I do. Thus will he think, he who holds the truth of truths... Always assured: This is the sense world plays with senses.";
            return View ("String", mystring);
        }

        [HttpGet ("Nums")]
        public IActionResult Nums () {
            int[] numbers = new int[] {
                1,
                2,
                3,
                4,
                5,
            };
            return View (numbers);
        }

        [HttpGet ("Users")]
        public IActionResult Users () {

            User One = new User () {
                FirstName = "Ralph Waldo",
                LastName = "Emerson"
            };
            User Two = new User () {
                FirstName = "Terrance",
                LastName = "Mckenna"
            };
            User Three = new User () {
                FirstName = "Michael",
                LastName = "Polland"
            };

            List<User> newUsers = new List<User> () {
                One,
                Two,
                Three
            };
            return View (newUsers);
        }
    }
}