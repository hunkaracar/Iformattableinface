using ConsoleApp1;

namespace ConsoleApp1;


class Program
{
    public static void Main()
    {

        var list = new List<Employee>()
        {
            new Employee()
            {
                    Id = 1,
                    Title = "Prof.Dr",
                    FirstName = "Hunkar",
                    LastName = "Acar"

            },
            new Employee()
            {
                    Id = 2,
                    Title = "Doc.Dr",
                    FirstName = "Omer",
                    LastName = "Kasapoglu"

            },
            new Employee()
            {
                    Id = 3,
                    Title = "Dr.uye",
                    FirstName = "arda",
                    LastName = "yılmaz"

            },
            new Employee()
            {
                    Id = 4,
                    Title = "Prof.Dr",
                    FirstName = "Semih",
                    LastName = "Eseroglu"

            },
        };

        foreach (var emp in list)
        {
            Console.WriteLine(emp.ToString("I"));

        }



       


          


        
    }
}
