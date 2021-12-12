﻿using Microsoft.AspNetCore.Mvc;
using Pelika.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelika.Web.ViewComponents
{
    public class LatesCourseViewComponent:ViewComponent
    {
        private ICourseService _courseService;

        public LatesCourseViewComponent(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("LatesCourse", _courseService.GetCourse().Item1));
        }
    }
}
