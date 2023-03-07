namespace Zinsrechnung
{
    public class Program
    {
        static void Main (string[] args){
            Calculator calculator = new Calculator();
            Zinsobjekt zinsobjekt = new Zinsobjekt();

            System.Console.WriteLine("[1]Zinssatz berechnen\n[2]Kapital berechnen\n[3]Endkapital berechnen");
            int choice = Convert.ToInt32(System.Console.ReadLine());
            switch (choice){
                case 1:
                    System.Console.WriteLine("Kapital eingeben:");
                    zinsobjekt.kapitlal = Convert.ToDouble(System.Console.ReadLine());
                    System.Console.WriteLine("Endkapital eingeben:");
                    zinsobjekt.endkapital = Convert.ToDouble(System.Console.ReadLine());
                    zinsobjekt.zinssatz = calculator.calcZinssatz(zinsobjekt);
                    System.Console.WriteLine(zinsobjekt.ToString());
                    break;
                case 2:
                    System.Console.WriteLine("Zinssatz eingeben:");
                    zinsobjekt.zinssatz = Convert.ToDouble(System.Console.ReadLine());
                    System.Console.WriteLine("Endkapital eingeben:");
                    zinsobjekt.endkapital = Convert.ToDouble(System.Console.ReadLine());
                    zinsobjekt.kapitlal = calculator.calcStartkapital(zinsobjekt);
                    System.Console.WriteLine(zinsobjekt.ToString());
                    break;
                case 3:
                    System.Console.WriteLine("Kapital eingeben:");
                    zinsobjekt.kapitlal = Convert.ToDouble(System.Console.ReadLine());
                    System.Console.WriteLine("Zinsatz eingeben:");
                    zinsobjekt.zinssatz = Convert.ToDouble(System.Console.ReadLine());
                    zinsobjekt.endkapital = calculator.calcEndkapital(zinsobjekt);
                    System.Console.WriteLine(zinsobjekt.ToString());
                    break;
                default:
                    System.Console.WriteLine("Falsche Eingabe.");    
                    break;    
            }
        }
    }
}