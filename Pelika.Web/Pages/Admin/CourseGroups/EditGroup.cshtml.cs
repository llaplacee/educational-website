using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pelika.Core.Services.Interfaces;
using Pelika.DataLayer.Entities.Course;

namespace Pelika.Web.Pages.Admin.CourseGroups
{
    public class EditGroupModel : PageModel
    {
        private ICourseService _courseService;

        public EditGroupModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [BindProperty]
        public CourseGroup CourseGroups { get; set; }
        public void OnGet(int id)
        {
            CourseGroups = _courseService.GetGroupById(id);
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            _courseService.UpdateGroup(CourseGroups);
            return RedirectToPage("index");
        }
    }
}