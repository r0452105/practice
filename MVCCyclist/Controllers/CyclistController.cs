using Microsoft.AspNetCore.Mvc;
using CyclingAPILib;
using MVCCyclist.Repos;

namespace MVCCyclist.Controllers
{
    public class CyclistController : Controller
    {
        private readonly RepoMVC repo;

        public CyclistController(RepoMVC repo)
        {
            this.repo = repo;
        }

        // GET: EmployeeController
        public async Task<ActionResult> Index()
        {
            List<Cyclist> cyclists = (List<Cyclist>)await repo.GetAll();
            return View(cyclists);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Cyclist cyclist)
        {
            try
            {
                var existingEmp = await repo.GetById(cyclist.Id);
                var newEmployee = await repo.Create(cyclist);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var employee = (Cyclist)await repo.GetById(id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Cyclist cyclist)
        {
                var result = await repo.Update(cyclist);
                return RedirectToAction(nameof(Index));
        }
    }
}
