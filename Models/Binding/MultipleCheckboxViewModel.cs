﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Snacks.Models.Binding
{
    public class MultipleCheckboxViewModel
    {
        public class Checkbox
        {
            public bool Selected { get; set; }
            public string ID { get; set; }
            public string Text { get; set; }
        }

        public List<Checkbox> Checkboxen { get; set; } = new List<Checkbox>();
    }
}
