namespace RingoMediaTask.Models
{
    public class Reminder
    {
        private Reminder()
        {
            Title = string.Empty;
        }
        public int Id { get; private set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }

        public static Reminder Create(int? id, string title, DateTime dateTime)
        {
            return new()
            {
                Id = id ?? 0,
                Title = title,
                DateTime = dateTime
            };
        }

        public void Validate()
        {
            if (Title.Length < 2 || Title.Length > 256)
            {
                throw new ArgumentException("Title length must be between 2 and 256 characters");
            }
            if (DateTime.Date <= DateTime.Now.Date)
            {
                throw new ArgumentException("DateTime must be in the future");
            }
        }
    }
}
