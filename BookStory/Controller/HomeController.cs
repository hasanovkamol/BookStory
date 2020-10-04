using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStory.Controllers
{
    public class HomeControllers:Controller
    {
        public string Index()
        {
            return "Men Contoller class dan kelyabman";
        }
        
    }
}
