using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_MVC_Snacks.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NET_MVC_Snacks.Controllers
{
    public class BindingController : Controller
    {
        [HttpGet]
        public IActionResult MultipleCheckbox()
        {
            MultipleCheckboxViewModel model = new MultipleCheckboxViewModel();
            foreach (var id in new string[] { "Donut", "Oreo", "Marshmallow", "Kitkat", "Nougat"})
            {
                model.Checkboxen.Add(new MultipleCheckboxViewModel.Checkbox()
                {
                    Selected = false,
                    ID = id,
                    Text = $"Snack {id}"
                });
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult MultipleCheckbox2(MultipleCheckboxViewModel model)
        {
            var aangvinkteIds = model.Checkboxen.Where(c => c.Selected).Select(c => c.ID).ToList();
            return Json($"Jij selecteerde de volgende snacks: {string.Join(',',aangvinkteIds)}.");
        }
    }
}