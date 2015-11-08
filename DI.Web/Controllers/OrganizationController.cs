using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DI.Web.Models;
using DI.Web.Services;

namespace DI.Web.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly IProjectService projectService;
        
        public OrganizationController(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            try {
                Organization org = projectService.GetOrganization();
                return View(org);
            }
            catch (Exception ex) {
                ViewData["Error"] = ex.Message;
            }

            return View(null);
        }
    }
}
