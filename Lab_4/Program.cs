// See https://aka.ms/new-console-template for more information

using Lab_4;

//Lab_4_1 addition = new Lab_4_1();

//Console.WriteLine("Sum of integers: " + addition.Add(5,10));

//Console.WriteLine("Sum of floats: " + addition.Add(5.0f,4.3f));

//Lab_4_2 area = new Lab_4_2();
//Console.WriteLine("Area of square: " + area.Area1(5));
//Console.WriteLine("Area of rectangle: " + area.Area1(5, 10));

//RBI rbi = new RBI();
//HDFC hdfc = new HDFC();
//SBI sbi = new SBI();
//ICIC icic = new ICIC();

//rbi.CalculateInterest();
//hdfc.CalculateInterest();
//sbi.CalculateInterest();
//icic.CalculateInterest();

//Hospital hospital = new Hospital();
//hospital.HospitalDetails();

//hospital = new Apollo();
//hospital.HospitalDetails();

//hospital = new Wockhardt();
//hospital.HospitalDetails();

//hospital = new Gokul_Superspeciality();
//hospital.HospitalDetails();

//Lab_4_5 areaCalculator = new Lab_4_5();

//Console.WriteLine("Area of circle is = " + areaCalculator.Area(5.0));
//Console.WriteLine("Area of square is = " + areaCalculator.Area(4));
//Console.WriteLine("Area of rectangle is = " + areaCalculator.Area(5.00, 10));

BankAccount bankAccount = new BankAccount("TIRTH", 10000.00);

bankAccount.Deposit(500.00);
bankAccount.Withdraw(200.00);

bankAccount.Deposit("CHK123", 300.00);
bankAccount.Withdraw("CHK456", 100.00);