using TpEmploye;

employee Employee1 = new employee(55, "sylvain", "Torrenti", new DateOnly(1990, 07, 20), new DateOnly(2000, 10, 05), 15000);

//Console.WriteLine(Employee1.Age());
//Console.WriteLine(Employee1.Retirement());

Employee1.DisplayEmployee();
Console.WriteLine("Aprés augmentation du salaire");
Console.WriteLine();
Employee1.WageIncrease();
Employee1.DisplayEmployee();
