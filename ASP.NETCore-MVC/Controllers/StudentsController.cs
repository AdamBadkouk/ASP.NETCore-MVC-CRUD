using ASP.NETCore_MVC.Data;
using ASP.NETCore_MVC.Entities;
using ASP.NETCore_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ASP.NETCore_MVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Add([Bind("Id,Name,Email,Phone,City")] StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                Student obj = new Student();
                obj.Name = student.Name;
                obj.Email = student.Email;
                obj.Phone = student.Phone;
                obj.City = student.City;
                _context.Add(obj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();

            var model = new StudentViewModel();
            model.Id = student.Id;
            model.Name = student.Name ?? String.Empty;
            model.Email = student.Email ?? String.Empty;
            model.Phone = student.Phone ?? String.Empty;
            model.City = student.City ?? String.Empty;


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Phone,City")] StudentViewModel student)
        {
            if (id != student.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                var obj = new Student();
                {
                    obj.Id = student.Id;
                    obj.Name = student.Name;
                    obj.Email = student.Email;
                    obj.Phone = student.Phone;
                    obj.City = student.City;
                }
                ;
                _context.Update(obj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
