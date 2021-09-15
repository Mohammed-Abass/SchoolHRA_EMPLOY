namespace IEmployee_LP
{
    public interface IEmployee
    {
        int Id { get; set; }

        string Name { get; set; }

        string Type { get; set; }

        decimal Salary { get; set; }

    }
}