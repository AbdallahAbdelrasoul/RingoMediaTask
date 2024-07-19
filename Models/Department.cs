namespace RingoMediaTask.Models
{
    public class Department
    {
        private Department()
        {
            Name = string.Empty;
            Logo = string.Empty;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }
        public void SetName(string name) => Name = name;

        public string Logo { get; private set; }
        public void SetLogo(string logo) => Logo = logo;

        public int? ParentId { get; private set; }
        public Department? Parent { get; private set; }
        public void SetParent(Department parentDepartment) => Parent = parentDepartment;

        //public ICollection<Department> SubDepartments { get; private set; } = [];
        //public void AddSubDepratments(ICollection<Department> subDepartments) => SubDepartments.ToList().AddRange(subDepartments);
        //public void RemoveSubDepratments(Department department) => SubDepartments.ToList().Remove(department);

        public static Department Create(int? id, string name, string logo, Department? parent)
            => new()
            {
                Id = id ?? 0,
                Name = name,
                Logo = logo,
                ParentId = parent?.Id,
                Parent = parent,
            };


    }
}
