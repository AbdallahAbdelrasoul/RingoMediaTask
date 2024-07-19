using RingoMediaTask.Models;

namespace RingoMediaTask.ViewModels
{
    public class ReminderViewModel
    {
        public IEnumerable<Reminder> Reminders { get; set; } = [];
        public Reminder NewReminder { get; set; } = Reminder.Create(null, "", DateTime.Now);
    }
}
