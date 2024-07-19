using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RingoMediaTask.Models;
using RingoMediaTask.ViewModels;

namespace RingoMediaTask.Controllers
{
    public class RemindersController(AppDbContext dbcontext) : Controller
    {
        private readonly AppDbContext _dbContext = dbcontext;

        public async Task<IActionResult> Index()
        {
            var reminderViewModel = new ReminderViewModel();
            reminderViewModel.Reminders = await _dbContext.Reminders.ToListAsync();
            return View(reminderViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReminderViewModel reminderViewModel)
        {
            reminderViewModel.NewReminder.Validate();
            await _dbContext.Reminders.AddAsync(reminderViewModel.NewReminder);
            bool created = await _dbContext.SaveChangesAsync() > 0;
            return RedirectToAction(nameof(Index));
        }
    }
}
