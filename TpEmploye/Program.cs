using TpEmploye;

#region Employee 1
employee Employee1 = new employee(55, "sylvain", "Torrenti", new DateOnly(1990, 07, 20), new DateOnly(2000, 10, 05), 15000);
#endregion
#region Method
Employee1.DisplayEmployee();
Console.WriteLine("Aprés augmentation du salaire");
Console.WriteLine();
Employee1.WageIncrease();
Employee1.DisplayEmployee(); 
#endregion
