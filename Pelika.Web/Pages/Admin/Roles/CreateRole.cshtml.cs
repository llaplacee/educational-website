using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pelika.Core.Security;
using Pelika.Core.Services.Interfaces;
using Pelika.DataLayer.Entities.User;

namespace Pelika.Web.Pages.Admin.Roles
{
    [PermissionChecker(7)]

    public class CreateRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public CreateRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty] 
        public Role Role { get; set; }

        public void OnGet()
        {
            ViewData["Permissions"] = _permissionService.GetAllPermission();
        }
        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();

            Role.IsDelete = false;
            int roleId= _permissionService.AddRole(Role);

            _permissionService.AddPermissionsToRole(roleId,SelectedPermission);

            return RedirectToPage("Index");

        }
    }
}