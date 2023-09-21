using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year;
    string firstName, lastName;
    decimal salary;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Employee salaryEmployee = new SalaryEmployee()
    {
        Id = 100,
        FirstName = "Patricia",
        LastName = "Álvarez",
        BirthDate = new Date(year, month, day),
        HiringDate = new Date(year, month, day),
        IsActive = true,
        Salary = 1160000
    };

    //Console.WriteLine(salaryEmployee);
    Console.WriteLine("");

    Employee commissionEmployee = new CommissionEmployee()
    {
        Id = 200,
        FirstName = "Julio",
        LastName = "Pérez",
        BirthDate = new Date(year, month, day),
        HiringDate = new Date(year, month, day),
        IsActive = false,
        CommissionPercentage = 5,
        Sales = 20000000
    };

    //Console.WriteLine(commissionEmployee);
    Console.WriteLine("");

    Console.Write("Please type the ID: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    Console.Write("Please type the First Name: ");
    string firstName = Console.ReadLine();
    Console.WriteLine("");

    Console.Write("Please type the Last Name: ");
    string lastName = Console.ReadLine();
    Console.WriteLine("");

    Console.Write("Please type the if is Active: ");
    bool isActive = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine("");

    Console.Write("Please type the number of hours: ");
    float hours = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("");

    Console.Write("Please type value per hour: ");
    decimal hourValue = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("");

    Employee hourlyEmployee = new HourlyEmployee()
    {
        Id = id,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = new Date(year, month, day),
        HiringDate = new Date(year, month, day),
        IsActive = isActive,
        Hours = hours,
        HourValue = hourValue
    };

    //Console.WriteLine(hourlyEmployee);
    Console.WriteLine("");

    Employee baseCommissionEmployee = new BaseCommissionEmployee()
    {
        Id = 400,
        FirstName = "Armando",
        LastName = "Tirado",
        BirthDate = new Date(year, month, day),
        HiringDate = new Date(year, month, day),
        IsActive = true,
        CommissionPercentage = 10,
        Sales = 30000000,
        Base = 5000000
    };

    //Console.WriteLine(baseCommissionEmployee);
    Console.WriteLine(" ");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




