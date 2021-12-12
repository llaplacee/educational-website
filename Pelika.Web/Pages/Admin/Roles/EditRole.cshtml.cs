using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pelika.Core.Security;
using Pelika.Core.Services.Interfaces;
using Pelika.DataLayer.Entities.User;

namespace Pelika.Web.Pages.Admin.Roles
{
    [PermissionChecker(8)]

    public class EditRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public EditRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permissionService.GetRoleById(id);
            ViewData["Permissions"] = _permissionService.GetAllPermission();
            ViewData["SelectedPermissions"] = _permissionService.PermissionsRole(id);
        }
        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();
            _permissionService.UpdateRole(Role);
            _permissionService.UpdatePermissionsRole(Role.RoleId,SelectedPermission);

            return RedirectToPage("Index");

        }
    }
}