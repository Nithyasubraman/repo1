public abstract class Bank{
    public abstract void deposit();
     public abstract void withdraw();
      public abstract void bankdetails();
}

public class Child : Bank{
     public override void deposit(){
        Console.WriteLine("Enter the amount to deposit :");
        int cash=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The amount deposit successfully");
        Console.WriteLine("The total deposit amount is : "+cash);
     }
     public override void withdraw(){
        int bal=5000;
        Console.WriteLine("Enter the amount to withdraw");
        int amount=Convert.ToInt32(Console.ReadLine());
        if(amount<bal){
            Console.WriteLine("The amount was successfully withdrawed");
        }
        else{
            Console.WriteLine("Insufficient Balance");
        }
     }
     public override void bankdetails(){
        Console.WriteLine("Enter the bank name");
        string bname=Console.ReadLine();
        Console.WriteLine("Enter the bank location");
        string bloc=Console.ReadLine();
        Console.WriteLine("***************************");
        Console.WriteLine("The bank name is : "+bname);
        Console.WriteLine("The bank location is : "+bloc);
     }

}

public class Userinteface{
    public static void Main(string[]args){
        Child ref1=new Child();
        Console.WriteLine("Welcome to withdraw method");
         Console.WriteLine("************************");
        ref1.withdraw();
        Console.WriteLine("Welcome to deposit method");
         Console.WriteLine("************************");
        ref1.deposit();
        Console.WriteLine("Welcome to visit the bank details");
         Console.WriteLine("************************");
        ref1.bankdetails();
    }
}