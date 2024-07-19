using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RingoMediaTask.Models;

namespace RingoMediaTask.Controllers
{
    public class DepartmentsController(AppDbContext dbcontext) : Controller
    {

        private readonly AppDbContext _dbcontext = dbcontext;

        public async Task<IActionResult> Index(int? departmentId)
        {
            if (_dbcontext.Departments.IsNullOrEmpty())
            {
                await SeedSomeData();
            }

            var subDepartments = await _dbcontext.Departments.Where(x => x.ParentId == departmentId).ToListAsync();

            var department = await _dbcontext.Departments.FindAsync(departmentId);

            ViewBag.DepartmentName = department?.Name;
            ViewBag.DepartmentLogo = department?.Logo;
            ViewBag.ParentDepartments = await GetParentDepartments(department);

            return View(subDepartments);
        }

        private async Task<int> SeedSomeData()
        {
            var Hr = Department.Create(null, "HR", "https://picsum.photos/60/40?random=1", null);
            var Finance = Department.Create(null, "Finance", "https://picsum.photos/60/40?random=2", null);
            var IT = Department.Create(null, "IT", "https://picsum.photos/60/40?random=3", null);

            _dbcontext.Departments.AddRange(
                Hr,
                Finance,
                IT,
                Department.Create(null, "Recruitment", "https://picsum.photos/60/40?random=4", Hr),
                Department.Create(null, "Payroll", "https://picsum.photos/60/40?random=5", Finance)
            );
            return await _dbcontext.SaveChangesAsync();
        }

        private async Task<List<Department>> GetParentDepartments(Department? department)
        {
            var parents = new List<Department>();

            while (department?.ParentId != null)
            {
                department = await _dbcontext.Departments.FindAsync(department?.ParentId);
                if (department is { }) parents.Add(department);
            }
            return parents;
        }
    }
}
