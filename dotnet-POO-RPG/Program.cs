using dotnet_POO_RPG.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight hero = new Knight("João", 23, "Knight");
        Wizard wizard = new Wizard("Wizard Avveo", 23, "White Wizard");

        Console.WriteLine();
        Console.WriteLine(hero.Attack());
        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));
    }
}