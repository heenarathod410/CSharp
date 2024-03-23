public class Employee
{
    public uint EmpId;
    public string EmpName;
    public double SalaryPerHour;
    public double NoOfWorkingHours;
    public double NetSalary;
    public static string OrganizationName;
    public const string TypeOfEmployee = "Contract Based";
    public readonly string DepartmentName;

    public Employee()
    {
        DepartmentName = "Finance Department";
    }
}