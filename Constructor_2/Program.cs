using System;
class Car
{
    public string Brand;
    public int Year;
    public Car()
    {
        Brand="Unknown";
        Year=0;
    }
    public Car(string b,int y)
    {
        Brand=b;
        Year=y;
    }
    public void display()
    {
        Console.WriteLine($"Car brand name: {Brand}, & year:{Year}");
    }
}
class Program
{
    static void Main()
    {
        Car C1=new Car();
        Car C2=new Car("Rules Royel",2022);
        C1.display();
        C2.display();
    }
}