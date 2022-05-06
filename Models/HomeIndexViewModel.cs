using System;
using System.Collections.Generic;
using UWS.Shared;

namespace DbMVC.Models
{
    public class HomeIndexViewModel
    {
        public string Heading {get; set;}

        public IList<Shipper> Shippers {get; set;}
    }
}