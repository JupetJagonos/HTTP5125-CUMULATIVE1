using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly SchoolDbContext _context;

        public TeacherController()
        {
            _context = new SchoolDbContext();
        }

        public IActionResult Index()
        {
            var teachers = _context.GetAllTeachers();
            return View("List", teachers);
        }

        public IActionResult Show(int id)
        {
            var teacher = _context.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.AddTeacher(teacher);
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        public IActionResult Edit(int id)
        {
            var teacher = _context.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Teacher teacher)
        {
            if (id != teacher.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.UpdateTeacher(teacher);
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        public IActionResult Delete(int id)
        {
            var teacher = _context.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _context.DeleteTeacher(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
