using TpEmploye;

employee Employee1 = new employee(55, "Sylvain", "Torrenti", new DateOnly(1990, 07, 20), new DateOnly(2020, 10, 05), 15000);

Console.WriteLine(Employee1.Age());
Console.WriteLine(Employee1.Retirement());