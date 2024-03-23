using System;

public class Program
{
    static void Main()
    {
        Employee.OrganizationName = "Harsha Inc.";
        Console.WriteLine("*************************************" + Employee.OrganizationName + "*************************************");

        //loop that executes 10 times for 10 employees
        for (int i = 0; i < 10; i++)
        {
            //display employee number
            string employeeNumber;

            switch(i)
            {
                case 0: employeeNumber = "FIRST EMPLOYEE"; break;
                case 1: employeeNumber = "SECOND EMPLOYEE"; break;
                case 2: employeeNumber = "THIRD EMPLOYEE"; break;
                case 3: employeeNumber = "FORTH EMPLOYEE"; break;
                case 4: employeeNumber = "FIFTH EMPLOYEE"; break;
                case 5: employeeNumber = "SIXTH EMPLOYEE"; break;
                case 6: employeeNumber = "SEVENTH EMPLOYEE"; break;
                case 7: employeeNumber = "EIGHTH EMPLOYEE"; break;
                case 8: employeeNumber = "NINTH EMPLOYEE"; break;
                case 9: employeeNumber = "TENTH EMPLOYEE"; break;
                default: employeeNumber ="OTHER EMPLOYEE"; break;
            }
            Console.WriteLine(employeeNumber);

            //create emplooyee class
            Employee emp = new Employee();

            //read employeeid from keyboard
            Console.WriteLine("Employee ID: ");
            emp.EmpId = uint.Parse(Console.ReadLine());

            //read employee name from keyboard
            Console.WriteLine("Employee Name: ");
            emp.EmpName =  Console.ReadLine();

            //read salary perhour from keyboard
            Console.WriteLine("Salary per hour: ");
            emp.SalaryPerHour = uint.Parse(Console.ReadLine());

            //read no of working hour from keyboard
            Console.WriteLine("No. of working hour: ");
            emp.NoOfWorkingHours = uint.Parse(Console.ReadLine());

            //calculate netsalary
            emp.NetSalary = emp.NoOfWorkingHours * emp.SalaryPerHour;

            //display employee details
            Console.WriteLine("\nDETAILS OF "+employeeNumber);
            Console.WriteLine("Employee ID: "+emp.EmpId);
            Console.WriteLine("Employee Name: "+emp.EmpName);
            Console.WriteLine("Salary per hour: "+emp.SalaryPerHour);
            Console.WriteLine("No. of working hour: "+emp.NoOfWorkingHours);
            Console.WriteLine("Net salary: " + emp.NetSalary);
            Console.WriteLine("Type of employee: "+Employee.TypeOfEmployee);
            Console.WriteLine("Department Name: "+emp.DepartmentName);

            Console.WriteLine("Do you want to continue to next employee? Yes/No: ");
            string choice = Console.ReadLine();

            if(!(choice == "yes" || choice == "YES" || choice == "Yes" || choice == "y" || choice == "Y"))
            {
                break;
            }
            Console.WriteLine("-----------------------------------");//Separator Line
        }

        Console.WriteLine("\n Thank you.");
        Console.ReadKey();
    }
}