//No AI, just hard work, self-learning, and continuous improvement.
//Every line of code I write helps me become a better developer. 
//Slowly but surely, I'm improving my skills and building my future in software development.
#region OOP 

#region  Before started OOP

#region  Return type

/*{
    *Void-- > The console doesn't wait for the function to return (return = non)
    *
    *
}*/

#endregion


#region  Access Modifire 
/*{
    * public--> Any public member can be accessed from outside
    * private-->Only function of the same class can access its private members 
    * protect-->allows a child class to access the member variables,functions of its base class 
    * Internal --> can be access by any code in the same assembly
    * PrivetInternal-->
    * PrivetProtected--> 
}*/

#endregion


#region  Example of a normal method:
/*static int AddNumber(int a, int b)
{
    int result = 0;
    result = a + b;
    return result;
}*/
#endregion







#endregion

#region class
#region

/*using System.Collections.Concurrent;

person personOne = new person();
personOne.FristName = "Ahmed"; // personOne.properties
personOne.LastName = "Bakry";
personOne.Countre = "Egypt";
Console.WriteLine(personOne.FristName);
Console.ReadLine();

class person
{     // variables
    string fristName;
    string lastName;
    string countre;
    DateOnly brithDay;

    //properties
    public string FristName
    {
        get { return fristName; }
        set { fristName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public DateOnly BrithDay { get; set; } //prop 2tab
    public string Countre { get; set; }


}*/
#endregion
#region Abstract Class 
/*Line line = new Line();
line.SayHello();
line.Draw();

Shape shape = new Shape(); //Cannot create an instance of the abstract type or interface 'Shape'

Console.ReadLine();

abstract class Shape
{
    abstract public void Draw();
    public void SayHello()
    {
        Console.WriteLine("Hello from the abstract class");
    }
}
class Line : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Hello from Line Draw ");
    }
}*/
#endregion
#region sealed class
// Sealed class used to restrict the inheritance
/*sealed class Animal
{
    public string anemal { get; set; }
}
class Dog:Animal // error becouse the father is seald class
{
    public string dog { get; set; }
}*/
#endregion
#region static class
// A static class cannot be instantiated (object)
/*
 * 1-Only ststic members allowed
 * 2-cannot be instantiated
 * 3-sealed by defauld
 * 4-cannot cantain instance constructor
 */

/*Console.WriteLine(Company.CompanyName);
Console.WriteLine(Company.CompanyLocation);
Console.WriteLine(Company.GetTitalEmloyees);
Console.ReadLine();
static class Company
{
   static public string CompanyName = "Bakry";
    static public string CompanyLocation = "cairo";

    static public int GetTitalEmloyees()
    {
        return 2000;
    }
}*/

#endregion
#region Partial class
//Emoloyee Method
//Emoloyee propreties
/*
 * 1. The source file name can be different,
 * but each partial class’s name must be the same.
 *
 * 2. All the partial class definitions
 * must be in the same namespace and assembly.
 *
 * 3. Must have the same access modifiers like public or private
 *
 * 4. If any part is declared abstract, sealed or base type
 * then the whole class is declared of the same type.
 *
 * 5. Different parts can have different base types
 * so the final class will inherit all the base types.
 *
 * 6. Must contain the partial keyword
 *
 * 7. The Partial modifier can only appear
 * immediately before the keywords class, struct, or interface.
 *
 * 8. Nested partial types are allowed.
 */
/*using OOP;

 Employee newEmployee = new Employee();
newEmployee.EmployeeName = "Ahmed";
newEmployee.EmployeeNumber=1;
Console.WriteLine($"{newEmployee.EmployeeName}-{newEmployee.EmployeeNumber}-{newEmployee.CalculateSalary()}");*/
#endregion
#region Nested class
#endregion


#endregion

#region  Methods in c#
#region Pass By value
// Pass By value -->copy prametar value to anather varibal ,more memory,time
/*ex:
string fristEmployee, secondEmployee;
fristEmployee = "Ahmed";
secondEmployee = "Bakry";
Console.WriteLine($" inside main method befor calling {fristEmployee},{secondEmployee}");
ChangeNames(fristEmployee, secondEmployee);
Console.WriteLine($" inside main method after calling {fristEmployee},{secondEmployee}");
static void ChangeNames(string frist, string sec)
{
    frist = "Mohamed";
    sec = "Ali";
    Console.WriteLine($"inside ChangeNames method {frist},{sec}");

}
Console.ReadLine(); */
#endregion

#region  Pass By Reference
//Pass By Reference --> passing actuai parameter to the method , less memory,time
/*string fristEmployee, secondEmployee;
fristEmployee = "Ahmed";
secondEmployee = "Bakry";
Console.WriteLine($" inside main method befor calling {fristEmployee},{secondEmployee}");
ChangeNames(ref fristEmployee, ref secondEmployee);
Console.WriteLine($" inside main method after calling {fristEmployee},{secondEmployee}");
static void ChangeNames(ref string frist, ref string sec)
{
    frist = "Mohamed";
    sec = "Ali";
    Console.WriteLine($"inside ChangeNames method {frist},{sec}");

}
Console.ReadLine();*/
#endregion

#region  overloaded method
//two methods with the same name but different signatures (different based on the number and type of parametar)

/*using System;

class Program
{
    static void Main()
    {
        string guestName;
        Console.WriteLine("Deer guest What is your name ?");
        guestName = Console.ReadLine();
        if (guestName == string.Empty)
            welcomeGuest();
        else
            welcomeGuest(guestName);

    
    }


    static void welcomeGuest()
    {
        Console.WriteLine("How can I help you ?");
    }

    static void welcomeGuest(string name)
    {
        Console.WriteLine($"Good day {name},how can I help you ?");
    }
   
}*/

#endregion

#region static method
/*Bank.creatNewAcountStatic();
Bank bank = new Bank();
bank.creatNewAcountNotStatic();
class Bank
{
    //static method  [dont nead object ]
    public static void creatNewAcountStatic()
    {
        Console.WriteLine("New Acount has been created using static method");
    }
          //instance method
    public  void creatNewAcountNotStatic()
    {
        Console.WriteLine("New Acount has been created using NON static method");
    }


}*/

#endregion

#region Extension method
/*int x = 5;
Console.WriteLine(x.IsGreaterByBakry(2));
string text = "Ahmed";
Console.WriteLine(text.IsNumbersByBakry());
Console.ReadLine();
static class Extensionmethod
{
    public static bool IsGreaterByBakry(this int no1, int no2)
    { 
        return (no1 > no2); 
    }
    public static bool IsNumbersByBakry(this string text)
    {
        return int.TryParse(text, out int n);
    }
}*/
#endregion

#region Recursive method
/*int numper = 3;
Console.WriteLine("Non Recursive way ");
Console.WriteLine(factorialNonRecursive(numper));
Console.WriteLine("recursave way");
Console.WriteLine(factorialRecursive(numper));
Console.ReadLine();
// Non Recursive way
static int factorialNonRecursive(int numper)
{
    if (numper == 0)
        return 1;
    int value = 1;
    for(int i =  numper; i > 0; i--)
    {
        value = value * i;
        //Console.WriteLine(i);
    }
    return value;

}
// Recursive way

static int factorialRecursive(int numper)
{
    if (numper == 0)
        return 1;
    return numper * factorialRecursive(numper - 1);
   
}*/
#endregion



#endregion

#region  Constructors in c#
// special method of ahe class which gets automatically invoked whenever an instance of the class is created 
#region  Default Constructor
/*Console.WriteLine("Default Constructors ");
Enemy Zombe = new Enemy();
Console.WriteLine(Zombe.Health);

Console.ReadLine();
class Enemy
{
    public string EnemyName { get; set; }
    public double Health { get; set; }
    public int ID { get; set; }

    //ctor
    public Enemy()
    {
        Console.WriteLine("New enemy is created");
        Health = 100;

    }

}*/
#endregion
#region parameterized Constructor
/*Console.WriteLine("parameterized Constructors ");

Enemy Zombe = new Enemy("Giant Zombe",200);
Console.WriteLine(Zombe.EnemyName);
Console.WriteLine(Zombe.Health);
Console.ReadLine();
class Enemy
{
    //prop 
    public string EnemyName { get; set; }
    public double Health { get; set; }
    public int ID { get; set; }

    //ctor
    public Enemy(string enemyName,double health)
    {
        Console.WriteLine("New enemy is created from parameterized Constructors ");
        EnemyName = enemyName;
        Health = health;

    }

}*/

#endregion
#region Copy Constructor 

/*Enemy Zombe1 = new Enemy("Giant Zombe", 200);
Enemy Zombe2 = new Enemy(Zombe1);
Console.WriteLine(Zombe2.EnemyName);
Console.WriteLine(Zombe2.Health);
Console.ReadLine();
class Enemy
{
    //prop 
    public string EnemyName { get; set; }
    public double Health { get; set; }
    public int ID { get; set; }

    //ctor
    public Enemy(string enemyName, double health)
    {
        Console.WriteLine("New enemy is created from parameterized Constructors ");
        EnemyName = enemyName;
        Health = health;

    }
    public Enemy(Enemy enemy)
    {
        Console.WriteLine("New enemy is created from copy Constructors ");
        EnemyName =enemy.EnemyName ;
        Health =enemy.Health;
    }

}*/
#endregion
#region Private Constructor
/*Console.WriteLine("Private Constructor");
counter.currenCount = 70;
counter.IncrementCount();
Console.WriteLine($"New counter={counter.currenCount} ");
Console.ReadLine();
public class counter
{
    public static int currenCount;
    private counter()
    {

        
    }
    public static int IncrementCount() 
    {
        return ++currenCount;
    }
}*/

#endregion
#region Static Constructor 
//Only once it is called 
/*Enemy Zombe = new Enemy();
Enemy thanos = new Enemy();
 Enemy Robot = new Enemy();
Console.ReadLine();
class Enemy

{
    static int staticCounter = 0;
    static int instanceCounter = 0;
    public string EnemyName { get; set; }
    public double Health { get; set; }
    public int ID { get; set; }

    //ctor
    public Enemy()
    {
        instanceCounter++;
        Console.WriteLine($"Instance constructor is calld {instanceCounter}");
    }
    static Enemy()
    {
        staticCounter++;
        Console.WriteLine($"Static constructor is calld {staticCounter}");
    }



         

}*/
#endregion




#endregion

#region Inheritance
/*Anemal anemal = new Anemal();
Dog dog = new Dog();
dog.WalkDog();
class Bird :Anemal
{
    public string BirdColor { get; set; }
    public double Altitude { get; set; } 

    public void fly()
    {

    }
}
class Dog : Anemal

{
    public string DoogBread { get; set; }
    public string EasyTotrainleyel { get; set; }
    public void WalkDog() { }
}
class Anemal
{
    public string anemalName { get; set; }
    public DateOnly anemalBirthDate { get; set; }
    public void FeedAnimal()
    {

    }
}*/
#endregion

#region  Encapsulation
//base class
/*class Animal
{
    private string privateVariable;
    public  string publicVariable;
    protected string protectedVariable;
    internal string internalVariable;

    private void TrainAnimaprivate() { }
    public void TrainAnimalpublic() { }
    protected void TrainAnimaprotected() { }
    internal void TrainAnimainternal() { }
}
class Cat :Animal
{
    void feedCat() { }
}
class Dog : Animal
{
    Dog dog = new Dog();
    
    void feedDog() { /* dog. *}
}*/
#endregion

#region  Polymorphism
//Many forms 
#region Compile Time (Static type)
// Overloading

#endregion

#region Runtime
// overrriding
/*using System.Threading.Channels;
Shape[] shapes = new Shape[4];
shapes[0] = new Circle();
shapes[1] = new Triangle();
shapes[2] = new Line();
shapes[3] = new Shape();

foreach (Shape shape in shapes)
{
   shape.Draw();

}   
Console.ReadLine();

class Shape
{
    public virtual void Draw ()
    {
        Console.WriteLine("Basic Shape is creaed");
    }
}

class Circle : Shape
{
   public override void Draw()
    {
        Console.WriteLine("Circle  is creaed");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Triangle  is creaed");
    }
}

class Line : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Line  is creaed");
    }
}*/
#endregion

#endregion

#region Abstractain
//Concept or and idea not associated with any specific instance
/*Line line = new Line();
line.SayHello();
line.Draw();

Shape shape = new Shape(); //Cannot create an instance of the abstract type or interface 'Shape'

Console.ReadLine();

abstract class Shape
{
    abstract public void Draw();
    public void SayHello()
    {
        Console.WriteLine("Hello from the abstract class");
    }
}
class Line : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Hello from Line Draw ");
    }
}*/

#endregion

#region Bank Account Example

/*using System;
using System.Collections.Generic;
BankAccount acc1 = new BankAccount("Ahmed", 5000);

acc1.ShowBalance();

acc1.Deposit(1000);

acc1.Withdraw(2000);

acc1.ShowBalance();

NewBankAccount newBankAccount = new NewBankAccount("Amr", 10000);
newBankAccount.ShowBalance();

newBankAccount.Deposit(5000);

newBankAccount.Withdraw(10000);

newBankAccount.ShowBalance();
Console.ReadLine();*/


/*List<BankAccount> accounts = new List<BankAccount>();

accounts.Add(new BankAccount("Ahmed", 5000));
accounts.Add(new BankAccount("Amr", 10000));
accounts.Add(new BankAccount("Ali", 7000));
foreach (BankAccount account in accounts)
{
    account.ShowBalance();
    account.Deposit(1000);
    account.Withdraw(2000);
    account.ShowBalance();
    Console.WriteLine();
}




class BankAccount
{
    // Attributes
    private string accountOwner;
    private double balance;

    // Constructor
    public BankAccount(string owner, double initialBalance)
    {
        accountOwner = owner;
        balance = initialBalance;
         
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;   //balance = balance + amount;
            Console.WriteLine($"Deposited: {amount}");
           
        }
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
          
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    // Display Balance
    public void ShowBalance()
    {
        Console.WriteLine($"Owner: {accountOwner}");
        Console.WriteLine($"Balance: {balance}");
    }
}

class  NewBankAccount: BankAccount
{
    string NewaccountOwner;
    double NewinitialBalance;
    public NewBankAccount(string owner, double initialBalance)
         : base(owner, initialBalance) // if the father have parameterized Constructor You should to use {base ()}


    {
        NewaccountOwner = owner;
        NewinitialBalance = initialBalance;
        Console.WriteLine("New Accunt is created");
    }
}*/

#endregion

#region NameSpace
/*using Bank;
using Clinet;
using ParentNameSpace;
using ParentNameSpace.SonNameSpace;

BankAccount account = new BankAccount();
Clinet.Person person = new Clinet.Person();
ParentNameSpaceClass parent = new ParentNameSpaceClass();
SonNameSpaceClass sonNameSpace = new SonNameSpaceClass();



Console.ReadLine(); */


#endregion

#region Structs
//canot inhernt
/*using OOP;
Employee employee = new Employee("Ahmed",20);
employee.DisplayTimeSheet();
Console.WriteLine($"Employee name is {employee.EmployeeName}" +
    $" Employee Age {employee.EmployeeAge}");
Console.ReadLine();
public struct Employee
{
    public string EmployeeName { get; set; }
     public int EmployeeAge { get; set; }

    public void DisplayTimeSheet()
    {
        Console.WriteLine("TimeSheet mathod is sruct ");
    }
    public Employee (string name, int age)
    {
        EmployeeName = name;
        EmployeeAge = age;
    }
}*/
#endregion

#region  Class VS Structs 
//class                   |Structs  
/*                        | 
 * Reference type         |* Value type 
 * Allocted on heap memory|*Allocated on stack memory 
 * can contion constractor or destructor | can contain parameterized ,static constractor but cannot contian destructor
 * new keyword for creating instans | create an instance,with or whitht neu keyword  
 * Inhertans is allawed | inhertans is nat allawed 
 * can use protected modifire |cannot use protected modifire 
 
 */

#endregion

#region Interface
/*Console.WriteLine("currentAccount");
currentAccount newcurrentAccount = new currentAccount();
newcurrentAccount.OpenAccount = 150;
newcurrentAccount.BankStatmentFees();
newcurrentAccount.SendsStatmentViaEmail("ahmedsayedbakry050@gmail.com");

decimal annumalfees = newcurrentAccount.Annualfees();
Console.WriteLine(annumalfees);

Console.WriteLine("SavingsAccount");
SavingsAccount newsavingsAccount = new SavingsAccount();
newsavingsAccount.BankStatmentFees();
newsavingsAccount.SendsStatmentViaEmail("ahmedsayedbakry050@gmail.com");
newsavingsAccount.OpenAccount = 200;
Console.WriteLine(newsavingsAccount.Annualfees());
Console.ReadLine();



interface IAccountFees
{
    public string AccountNamber { get; set; }
    public decimal OpenAccount {  get; set; }
    void BankStatmentFees();
    void SendsStatmentViaEmail(string email);
    decimal Annualfees();
}

class currentAccount: IAccountFees
{
    public string AccountNamber { get; set; }
    public decimal OpenAccount { get; set; }

    public void BankStatmentFees()
    {
        Console.WriteLine("Bank statment fees is 30 EGP");
    }
    public void SendsStatmentViaEmail(string email)
    {
        Console.WriteLine($"Sending email{email}");
    }
    public decimal Annualfees() 
    {
        decimal mobileBankfeesperMoth = 7;
        decimal adinistrationfeesperMoth = 5;
        return 12 *(adinistrationfeesperMoth + mobileBankfeesperMoth);
    }
}
class SavingsAccount : IAccountFees
{

    public string AccountNamber { get ; set ; }
    public string AccountCurrency { get; set; }
    public decimal OpenAccount { get; set; }

    public decimal Annualfees()
    {
        return 75;
    }

    public void BankStatmentFees()
    {
        Console.WriteLine("Bank statment fees is 45 EGP");
    }
    public void SendsStatmentViaEmail(string email)
    {
        Console.WriteLine($"Sending email{email}");
    }
}*/

#endregion

#region Enumerations 
/*person personOne = new person();
personOne.PersonName = "Ahmed";
personOne.Contre = Contre.Palestine; 
personOne.language = Language.Arabic;
personOne.months = Months.January;
Console.WriteLine($"Person Name: {personOne.PersonName}, Country: {personOne.Contre}, Language: {personOne.language}, Month: {personOne.months}");
person personTwo = new person("Ali", Contre.Syria, Language.Arabic, Months.February);
Console.WriteLine($"Person Name: {personTwo.PersonName}, Country: {personTwo.Contre}, Language: {personTwo.language}, Month: {personTwo.months}");
Console.WriteLine(Months.January);
Console.WriteLine((byte)Months.January);

foreach (Months month in Enum.GetValues(typeof(Months)))
{
    Console.WriteLine($"{month}: {(byte)month}");
}
Console.ReadLine();
public enum Months : byte
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
}

public enum Contre
{
    Egypt,
    Syria,   
    Iraq,    
    Palestine
}
public enum Language
{
    Arabic,
    English,
    German

}
public class person 
{
    public string PersonName { get; set; }
    public Contre Contre { get; set; } 
    public Language language { get; set; }
    public Months months { get; set; }

    public person()
    {
        
    }

    public person(string name, Contre country, Language lang, Months month)
    {
        PersonName = name;
        Contre = country;
        language = lang;
        months = month;
    }
}*/

#endregion

#region This keyword
/*using System.Net.Http.Headers;
Employee employee1 = new Employee("Ahmed", Country.Palestine,5000);
employee1.ShowEmployee();
Console.ReadLine();
class Employee 
{

    public string Name { get; set; }
    public Country Country { get; set; }
    public decimal Salary  { get; set; }


    public Employee(string Name,Country Country,decimal Salary) 
    {
        this.Name = Name;
        this.Country = Country;
        this.Salary = Salary;
     
    }
    public void ShowEmployee()
   {
        Console.WriteLine($"Name:{Name},\n Country:{Country}");
        Console.WriteLine("salary after overtime:{0:C}",Overtime.CalculatOvertime(this,40,20));
    }
}
 class Overtime
{
    public static decimal CalculatOvertime ( Employee employee,decimal time , decimal rate)
    {
        return time * rate + employee.Salary;
    }
}
enum Country
{
    Egypt,
    Syria,
    Iraq,
    Palestine
}*/

#endregion

#region Exception Handling
#region 1 ex
/*int div = 0;
int x = 5;
try
{

    div = 5 / x;
}
catch (Exception ex)
{
    Console.WriteLine($"Exception is :{ex.Message} \nFUCK YOU");
// throw  تعرف المشكله  
}
finally
{
    Console.WriteLine("Resolt :{0} ", div);
}
Console.ReadLine();*/

#endregion
#region 2 ex
/*using System.Linq.Expressions;

string[] Colors = {"black","red","white"};
int index = 5;
try
{ 
    Console.WriteLine(Colors[index]);
}
catch (Exception e) when (index > 0)
{
    Console.WriteLine("index > 0");
    Console.WriteLine($"Exception is :{e.Message}");
}
catch (Exception e) when (index < 0)
{
    Console.WriteLine("index <0 ");

    Console.WriteLine($"Exception is :{e.Message}");
}

Console.ReadLine();*/

#endregion


#endregion

#region finalizer = Destructor
/*Employee employee = new Employee();
Console.ReadLine();
class Employee
{
    public Employee()
    {
        Console.WriteLine("Constractor is called");
    }
    ~Employee()
    {
        Console.WriteLine("finalizer/Destructor is called"); // after .net5 finalizer/Destructor dont used
    }
}*/
#endregion

#region Documentation Comments 
/*Point point = new Point();
point.Translate(2,3,4);
/// <summary>
/// point class is used to move , rotate and scale any object in viewport
/// Developed By Ahmed Bakry 
/// </summary>
class Point
{
    /// <summary>
    /// Moves the object current point to the location provided by given x,y and z
    /// Developed By Eng Ahmed Bakry 
    /// </summary>
    /// <param name="x">daytatype int </param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    public void Translate (int x, int y,int  z)
    {

    }
}*/
#endregion

#region Stream.IO

#region  Dispose
/*
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
//1) not recommended
//CurrecyService _currecyService = new CurrecyService();
//var result = _currecyService.GeeCurrencies().Result;
//_currecyService.Dispose();
//Console.WriteLine(result);

//2) recommended
//CurrecyService _currecyService = null;
//try
//{
//    _currecyService = new CurrecyService();
//    var result = _currecyService.GeeCurrencies().Result;
//    Console.WriteLine(result);
//}
//catch(Exception)
//{
//    Console.WriteLine("Error");
//}
//finally
//{
//    _currecyService?.Dispose(); //Null-conditional operator
//}

//3) more recommended
using (CurrecyService _currecyService = new CurrecyService())
{
    var result = _currecyService.GeeCurrencies();
    Console.WriteLine(result);
}


class CurrecyService : IDisposable
{
    private bool _disposed = false;
    private readonly HttpClient _httpClient;
    public CurrecyService()
    {
        _httpClient = new HttpClient();

    }
    ~CurrecyService()
    {
        Dispose(false);
    }
    // disposing : true (dispose managed + unmanged)
    // disposing : false (dispose unmanged + large fieds)


    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) // you have to _dispose one time
            return;
        // Dispose Logic
        if (disposing)
        {
            //dispos managed resources
            _httpClient.Dispose();
        }
        //unmanaged object
        //set large fields to null
        _disposed = true;
    }
    public void Dispose()
    {
        // dispose is called 100%
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    public string GeeCurrencies()
    {

        string url = "https://coinbase.com/api/v2/currencies"; // class http Clinet
        var result = _httpClient.GetStringAsync(url).Result;
        //var result = _httpClient.GetStringAsync(url).Result;
        #region await vs .Result
        /*
		 * await vs .Result
		 * 
		 * await:
              Asynchronous (non-blocking)
              Does NOT block the thread
              Recommended for modern C# code
              Prevents deadlocks (safe for ASP.NET / UI apps)
              Requires async method

		 * .Result:
		     Synchronous (blocking)
             Blocks the thread until completion
             Can cause deadlocks (especially in ASP.NET / UI)
             Should be avoided in most cases
             Only used when async cannot be used

		 *{Remove me :) }/
       

        return result;
    }

}
#endregion
*/
#endregion

#region Stream
/*
using static System.Runtime.InteropServices.JavaScript.JSType;

Example1();
Example2();
Example3();
StreamWriter_Example1();
StreamReader_Example1();
StreamWriter_Example2();
StreamReader_Example2();
static void Example1()
{
    string path = @"C:\Users\Ahmed\Documents\New Text Document.txt";

    using var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
    Console.WriteLine($"Length:{fs.Length} Byte(s)");
    Console.WriteLine($"CanRead:{fs.CanRead}");
    Console.WriteLine($"CanSeek:{fs.CanSeek}");
    Console.WriteLine($"CanTimeout:{fs.CanTimeout}");
    Console.WriteLine($"Position_1:{fs.Position}");
    fs.WriteByte(65);// A
    Console.WriteLine($"Position_2:{fs.Position}");
    fs.WriteByte(13); // Enter
   
    //        A            Z
    for (byte i = 65; i < 123; i++)
        fs.WriteByte(i);
    

}

static void Example2()
{
    string path1 = @"C:\Users\Ahmed\Documents\New Text Document.txt";

    using (var fs = new FileStream(path1, FileMode.Open, FileAccess.ReadWrite))

    {
        byte[] data = new byte[fs.Length];
        int numBytesToRead = (int)fs.Length;
        int numBytesRead = 0;
       
        while (numBytesToRead > 0)
        {
            int n = fs.Read(data, numBytesRead, numBytesToRead);

            if (n == 0)
                break;
            numBytesToRead -= n;
            numBytesRead += n;

            foreach (var b in data)
            {
                Console.WriteLine(b);
            }
            var newFile = @"C:\Users\Ahmed\Documents\New Text Document2.txt";
            using var fa = new FileStream(newFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            {
                fa.Write(data, 0, data.Length);
            }
        }
      
    }

   
}

static void Example3()
{
    string path = @"C:\Users\Ahmed\Documents\New Text Document3.txt";
    using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
    {
        fs.Seek(20, SeekOrigin.Begin);
        fs.WriteByte(65);
        fs.Position = 0;
        for (int i = 0; i < fs.Length; i++)
        {
            Console.WriteLine(fs.ReadByte());
        }
    }

}

static void StreamWriter_Example1()
{
    string path = @"C:\Users\Ahmed\Documents\New Text Document4.txt";
    using (var sw = new StreamWriter(path))
    {
        sw.WriteLine("Hi");
        sw.Write("Im Ahmed");

        // File.WriteAllLines(path, lines);
       // File.WriteAllText(path, text);
    }
}

static void StreamWriter_Example2()
{
    string path = @"C:\Users\Ahmed\Documents\New Text Document.txt";
    string[] lines =
       {
         "it's",
          "me"
       };

    File.WriteAllLines(path, lines);

    string text = "Im Ahmed";
    File.WriteAllText(path, text);
}

static void StreamReader_Example1()
{

    string path = @"C:\Users\Ahmed\Documents\New Text Document.txt";
    using (var sr = new StreamReader(path))
    {

       while (sr.Peek()>0) 
        {
            Console.WriteLine((char)sr.Read());
        }
        Console.WriteLine("-----------------------");
        string line;
        while ((line = sr.ReadLine()) is not null) //!= null
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("------------------");
        var result = File.ReadAllText(path);
        Console.WriteLine(result);
    }
}

static void StreamReader_Example2() 
{
    string path = @"C:\Users\Ahmed\Documents\New Text Document.txt";

    Console.WriteLine(File.ReadAllText(path));
    var lines = File.ReadAllLines(path);
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}*/
#endregion

#region DeflateStream
/*
using System.IO.Compression;

using (var stream = File.Create("data.bin"))
{
    using (var ds = new DeflateStream(stream,CompressionMode.Compress))
    {
        ds.WriteByte(65);
        ds.WriteByte(66);
    }
}
using (var stream = File.OpenRead("data.bin"))
{
    using (var ds = new DeflateStream(stream, CompressionMode.Decompress))
    {
        for (int i = 0; i < stream.Length; i++)
        {
            Console.WriteLine(ds.ReadByte());
        }
    }
}
*/
#endregion
#endregion

#region Association, Aggregation & Composition
// Association (uses a)
//Aggregation (has a ) spachal Association
//Composition (owns a)
/*Department department = new Department();
Employee employee = new Employee();
employee.department = department;
employee.Name = "Ahmed";
employee.department.NameEmployee = "AhmedBakry";
employee.department.ID = 1242415;
class Department
{
    public  string NameEmployee { get; set; }
    public string NameDepartment { get; set; }
    public int ID { get; set; }
}
class Company
{
    public string Name { get; set; }
    public Department department { get; set; }
}
class Employee
{
    public string Name { get; set; }
    public Department department { get; set; }
}
*/

#endregion

#endregion
