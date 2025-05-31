namespace SMSApp.CommandQueries
{
    public class DepartmentCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Short_name { get; set; }
        public string Code { get; set; }
    }
    public class DepartmentQuery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Short_name { get; set; }
        public string Code { get; set; }

    }
}
