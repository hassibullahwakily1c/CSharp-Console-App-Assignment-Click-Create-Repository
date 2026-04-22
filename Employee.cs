// Allows the program to use basic system functionality like Console.WriteLine.
using System;

// Defines the namespace for this project.
namespace EmployeeInterfaceAssignment
{
    // Creates the Employee class.
    // This class implements the IQuittable interface, so it must include Quit().
    public class Employee : IQuittable
    {
        // Creates a property to store the employee's ID number.
        public int Id { get; set; }

        // Creates a property to store the employee's first name.
        public string FirstName { get; set; }

        // Creates a property to store the employee's last name.
        public string LastName { get; set; }

        // Implements the Quit() method required by the IQuittable interface.
        // This method displays a message showing that the employee has quit.
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }
}