using System.Runtime.CompilerServices;

namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; } //123
        public string? FirstName { get; set; } // Maria
        public string? LastName { get; set; } //Perez
        public Date? BirthDate { get; set; } // 15/05/2000
        public Date? HiringDate { get; set; } // 14/09/2023
        public bool? IsActive { get; set; } // true
        #endregion

        #region Methods

        public Employee()
        {
            
        }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"----EMPLOYEE----\n\t" +
                $"ID.............{Id}\n\t" +
                $"First Name.....{FirstName}\n\t" +
                $"Last Name......{LastName}\n\t" +
                $"Birth Date.....{BirthDate}\n\t" +
                $"HiringDate.....{HiringDate}\n\t" +
                $"Is Active?.....{IsActive}";
        }

        #endregion
    }
}
