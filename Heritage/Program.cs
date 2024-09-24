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

Employee robertaTeste = roberta;

Console.WriteLine("Referral bonus director: " + roberta);
Console.WriteLine("Referral bonus employee: " + robertaTeste);
