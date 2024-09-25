using Heritage;

BonusManager manager = new BonusManager();

Employee carlos = new Employee();
carlos.Name = "Carlos";
carlos.CPF = "123.456.789-10";
carlos.Wage = 2000;

manager.Register(carlos);

Director roberta = new Director();
roberta.Name = "Roberta";
roberta.CPF = "111.222.333-44";
roberta.Wage = 5000;

manager.Register(roberta);

Console.Write(carlos.Name + ": ");
Console.WriteLine(carlos.GetBonus());

Console.Write(roberta.Name + ": ");
Console.WriteLine(roberta.GetBonus());

Console.WriteLine("Total of bonus: " + manager.GetTotalBonus());

Employee employeeDirector = roberta;
Console.WriteLine("Reference from a director to an employee, info employeeDirector: \n" +
    employeeDirector.Name + "\nWage: " + employeeDirector.Wage);

//I can't get the region property from the employeeDirector variable, as it is denoted as Employee

Console.ReadKey();