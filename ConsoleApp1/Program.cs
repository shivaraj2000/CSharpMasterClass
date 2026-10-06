using ConsoleApp1.Delegates;
using ConsoleApp1.Generics;
using ConsoleApp1.OOP.Abstraction;
using ConsoleApp1.OOP.Interface;
using ConsoleApp1.OOP.Polymorphism;
using ConsoleApp1.OOP.Static;
using static ConsoleApp1.Delegates.Delegate_Ex;
using static ConsoleApp1.Delegates.Events_EventHandler_PaytmentProcess;
using static ConsoleApp1.Delegates.Events_PaymentProcesseor;
using static ConsoleApp1.Delegates.Lamda_Opretator;
using static ConsoleApp1.Delegates.LamdaAsMethodArgument;
using static ConsoleApp1.Generics.Generaics_Basics;
using static ConsoleApp1.Generics.PaymentTest_BaseTest;
using static ConsoleApp1.Generics.LoginTest_BaseTest;
using static ConsoleApp1.Collections.List.List_Basics;
using ConsoleApp1.Collections.List;
using ConsoleApp1.Collections;
using ConsoleApp1.Generics.Collections;





//using static ConsoleApp1.Generics.GnereiceGetterSetter<int>;




MethodOverloading overloading = new MethodOverloading();
//overloading.Add(1,2);

//overloading.Add(1,2,3);
//overloading.Add(10.5, 9.25);
//overloading.Add("Shiva","Sac");

//Method_Overriding_Vehicle v = new Method_Overriding_Vehicle();
//v.Start();
//Method_Overriding_Car c = new Method_Overriding_Car();
//c.Start();
//Method_Overriding_Bike b = new Method_Overriding_Bike();
//b.Start();  

Runtime_Poly_Animal a = new Runtime_Poly_Animal();
Runtime_Poly_Animal a1 = new Runtime_Poly_Cat();
Runtime_Poly_Animal a2 = new Runtime_Poly_Dog();

//a1.Eat();
//a2.Eat();
//a.Eat();

//Runtime_Poly_Animal animal = new Runtime_Poly_Dog();

//Runtime_Poly_Dog d = (Runtime_Poly_Dog)animal;

//d.Bark();

//if(a2 is Runtime_Poly_Dog)
//{
//    Runtime_Poly_Dog rd = new Runtime_Poly_Dog();
//    rd.Bark();  
//}

//if(a1 is Runtime_Poly_Cat cat)
//{
//    cat.Meow();
//}

//Runtime_Poly_Dog dog = a2 as Runtime_Poly_Dog;
//if(dog!=null)
//{
//    Console.WriteLine("It is pointing to dog");
//}else
//{
//    Console.WriteLine("It is Null (Dog)");
//}
//Runtime_Poly_Cat catt = a2 as Runtime_Poly_Cat;
//if (catt!=null)
//{
//    Console.WriteLine("It is pointing to dog");
//}
//else
//{
//    Console.WriteLine("It is Null (Cat)");
//}

Payment payment = new CreditCardPayment();
Payment payment1 = new PremiumCreditCardPayment();

//payment.ProcessPayment();
//Console.WriteLine("-------------");
//payment1.ProcessPayment();

Payments p1 = new CreditCardPayments();
Payments p2 = new UPIPayments();
//p1.ProcessPayment();
//p1.ValidatePayment();
//p2.ProcessPayment();
//p2.ValidatePayment();

AutomationTest test = new AutomationTest();
//test.Log("Login test started");
//test.GenerateReport("Login Test");
//test.ValidateDatabase("Select * from Customers");

IDataBaseValidator dataBaseValidator = test;
ITestLogger testLogger = test;
ITestReporter testReporter = test;

//dataBaseValidator.ValidateDatabase("Select * from Trx");
//testLogger.Log("Log the steps");
//testReporter.GenerateReport("Geerate Report for Automation");

ITestLogger itl = new ExtentLogger();
//itl.Log("Hi");

BaseTest test1 = new LoginTest();
BaseTest test2 = new PaymentTest();
IDataBaseValidator ib = new LoginTest();
ITestLogger itl2 = new LoginTest();
ITestLogger il = new PaymentTest();
IDataBaseValidator il2 = new LoginTest();


//test1.SetUp("Login Test");
//test1.ExecuteTest("Login Test");
//ib.ValidateDatabase("Select * from Customers");
//itl2.Log("Logging the Database validation for Login Test");


//test2.SetUp("Payment Test");
//test2.ExecuteTest("Payment Test");
//il.Log("Logging the Database validation for payment Test");
//il2.ValidateDatabase("Select * from Trx");

Static s = new Static();
//Static.ShowBankName();
//Static.ShowBankNames();
//s.ShowBankNam();
//s.IndianBank();

//AutomationUtility.LogTest();
//Console.WriteLine(AutomationUtility.Calculator(10,10));

Calulator calc;
calc = Add;
//calc(20, 10);

calc = Subtract;
//calc(20, 10);

calc = Multiply;
//calc(20, 10);

calc = Divison;
//calc(20, 10);

//ExecuteOperation(Add);

//ExecuteValidation(UIValidation);
//ExecuteValidation(APIValidation);
//ExecuteValidation(DataBaseValidation);

Methods_Delegates d = new Methods_Delegates();
//d.ExecuteValidation(d.UIValidation);
//d.ExecuteValidation(d.APIValidation);
//d.ExecuteValidation(d.DataBaseValidation);

//ExecuteAction(Login);
//ExecuteAction(TakeScreenshot);
//ExecuteAction(Logout);

//ExecuteTest(LogTest,"Login",113);
//ExecuteTest(LogStatus,"Pass",200);

//ExecuteTests(CalculateAddition,4,5,"Addition :");
//ExecuteTests(CalculateSubtraction, 4, 5, "Subtraction :");
//ExecuteTests(CalculateMultiplication, 4, 5, "Multiplication :");


/*ExecuteBoolCheck(IsPassed, 75);
ExecuteBoolCheck(IsPassed, 35);*/

//ExecuteMultiCaseDelegates();

/*ExecuteAnonymousMethod("Transaction Started",800,"Approved");
ExecuteAnonymousMethod("AML Rule Validation Completed",150000,"Rejected");
ExecuteAnonymousMethod("Transaction Completed",80000,"Rejected");*/

//lamdaExcercise();

//ExecuteLamdaAsMethodArgument(x => x + 5, 7, "Addition of 7 and 5 : ");
//ExecuteLamdaAsMethodArgument(x => x * 5, 7, "Multiplication of 7 and 5 : ");
//ExecuteLamdaAsMethodArgument(x => x - 5, 7, "Subtraction of 7 and 5: ");

//ExecuteValidation(x => x == "Approved", "Approved", "Transaction Status is Approved hence it is ");
//ExecuteValidation(x => x == "Approved", "Rejected", "Transaction Status is Rejected hence it is ");

//ExecuteValidation(x => x.Length > 5, "CUST123", "Customer Length is greater than 5 hence it is ");
//ExecuteValidation(x => x.Length > 5, "CUS3", "Customer Length is less than 5 hence it is ");

//ExecuteValidation(x => x == "International", "International","Trx type is International hence it is ");
//ExecuteValidation(x => x == "International", "National", "Trx type is Natioanl hence it is ");

//ExecuteValidationn(x => (x.Length >= 5 && x.StartsWith("CUST") && (!string.IsNullOrWhiteSpace(x))), "CUST123");
//ExecuteValidationn(x => (x.Length >= 5 && x.StartsWith("CUST") && (!string.IsNullOrWhiteSpace(x))), "CUS");
//ExecuteValidationn(x => (x.Length >= 5 && x.StartsWith("CUST") && (!string.IsNullOrWhiteSpace(x))), "ABC123");
//ExecuteValidationn(x => (x.Length >= 5 && x.StartsWith("CUST") && (!string.IsNullOrWhiteSpace(x))), "");

//ExecuteValidationn(x =>
//{
//    if (x.Length >= 5 && x.StartsWith("CUST") && (!string.IsNullOrWhiteSpace(x)))
//        return true;
//    else
//        return false;
//},"CUST123");

Func<decimal, bool> validator1 = CreateTrxValidator(10000);
Func<decimal, bool> validator2 = CreateTrxValidator(50000);

//Console.WriteLine(validator1(15000));
//Console.WriteLine(validator1(5000));
//Console.WriteLine(validator2(15000));
//Console.WriteLine(validator2(60000));

Events_PaymentProcesseor paymentProcesseor = new Events_PaymentProcesseor();
//paymentProcesseor.PaymentCompleted += paymentProcesseor.LogPayment;
//paymentProcesseor.PaymentCompleted += paymentProcesseor.SendNotification;
//paymentProcesseor.PaymentCompleted += paymentProcesseor.GenerateReceipt;
//paymentProcesseor.ProcessPayment();

Events_EventHandler_PaytmentProcess ep = new Events_EventHandler_PaytmentProcess();
//ep.PaymentCompleted += ep.Login;
//ep.ProcessPayment();

EventHandlerWithParams ehwp = new EventHandlerWithParams();
//ehwp.PaymentCompleted += ehwp.LogPayment;
//ehwp.ProcessPayment();


//printValue("Shiva");
//printValue(1000);
//printValue(10.34);
//printValue(true);

//printTrx(100, "shiva");
//printTrx("Trx101", 34.45m);
//printTrx(true, 12);

GnereiceGetterSetter<int> gs = new GnereiceGetterSetter<int>();
//gs.Data = 34;
//gs.TrxID = "Shiva";
//Console.WriteLine(gs.Data.GetType().Name);

Gnereiucs_RefType<string> gf = new Gnereiucs_RefType<string>();
//gf.CalculateLength("Shiva");

//TestExecuteor_BaseClass.ExecuteTest(new LoginTest_BaseTest());
//TestExecuteor_BaseClass.ExecuteTest(new PaymentTest_BaseTest());

//Interface_Executor.ExecuteInterface(new Interface_ChuildClass.APIValidation());
//Interface_Executor.ExecuteInterface(new Interface_ChuildClass.DBValidation());
//Interface_Executor.ExecuteInterface(new Interface_ChuildClass.UIValidation());

//Exceutor.Exceutors<PaymentTests>();

Transaction t = new Transaction { Amount=10000,TrxID="Trx121"};

TransactionValidator tv = new TransactionValidator();
AmountValidator av = new AmountValidator();

//tv.Validation(t);
//av.Validation(t.Amount);

//TAsStruct.ProcessVal(1000);
//TAsStruct.ProcessVal(100.56);
//TAsStruct.ProcessVal(true);
//DateTime date = DateTime.Now;
//TAsStruct.ProcessVal(date);

//GenericsList.TrxList();

//List_Basics.BasicList();

//Arrays.ProcessTransactions();
//Arrays.MultiDimesnosalArrays();
//Arrays.ArrayProblems();
//List_Basics.ProcessTransactionList();
//List_Basics.CapacityCount();

//Dictionary.ProcessTrxs();
//HashSet.HashSetEx();
//Queue.QueueExample();
//Stack.StackExample();
//TestData < int > intTestData = new TestData<int>();
//TestData<int>.Show(199);
//TestData<string> stringTestData = new TestData<string>();
//TestData<string>.Show("Shivaraj");
//TestData<decimal> decimalTestData = new TestData<decimal>();
//TestData<decimal>.Show(100.23m);

//TestDatas<int> test1x = new TestDatas<int>();
//test1x.Show(100);
////test1x.Show("Hello");
//test1x.Print(100);
//test1x.Print("Hello");
//test1x.Print(25.5m);

TestRunner<LoginTestt> runner = new TestRunner<LoginTestt>();
runner.Run();

Console.ReadLine();