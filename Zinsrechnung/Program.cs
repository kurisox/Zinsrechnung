namespace Zinsrechnung
{
    public class Program
    {
        static void Main (string[] args){
            Calculator calculator = new Calculator();
            bool endLoop = false;
            do{
                System.Console.WriteLine("[1]Zinssatz berechnen\n[2]Startkapital berechnen\n[3]Endkapital berechnen\n[4]Jahre berechnen\n[5]Programm beenden");
                int choice = Convert.ToInt32(System.Console.ReadLine());
                Zinsobjekt zinsobjekt = new Zinsobjekt();
                switch (choice){
                    case 1:
                        System.Console.WriteLine("Kapital eingeben:");
                        zinsobjekt.kapitlal = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Jahre eingeben:");
                        zinsobjekt.jahre = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Endkapital eingeben:");
                        zinsobjekt.endkapital = Convert.ToDouble(System.Console.ReadLine());
                        zinsobjekt.zinssatz = calculator.calcZinssatz(zinsobjekt);
                        System.Console.WriteLine(zinsobjekt.ToString()+"\n");
                        break;
                    case 2:
                        System.Console.WriteLine("Zinssatz eingeben:");
                        zinsobjekt.zinssatz = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Jahre eingeben:");
                        zinsobjekt.jahre = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Endkapital eingeben:");
                        zinsobjekt.endkapital = Convert.ToDouble(System.Console.ReadLine());
                        zinsobjekt.kapitlal = calculator.calcStartkapital(zinsobjekt);
                        System.Console.WriteLine(zinsobjekt.ToString()+"\n");
                        break;
                    case 3:
                        System.Console.WriteLine("Startkapital eingeben:");
                        zinsobjekt.kapitlal = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Zinsatz eingeben:");
                        zinsobjekt.zinssatz = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Jahre eingeben:");
                        zinsobjekt.jahre = Convert.ToInt32(System.Console.ReadLine());
                        zinsobjekt.endkapital = calculator.calcEndkapital(zinsobjekt);
                        System.Console.WriteLine(zinsobjekt.ToString() +"\n");
                        break;
                    case 4:
                        System.Console.WriteLine("Startkapital eingeben:");
                        zinsobjekt.kapitlal = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Zinsatz eingeben:");
                        zinsobjekt.zinssatz = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Endkapital eingeben:");
                        zinsobjekt.endkapital = Convert.ToInt32(System.Console.ReadLine());
                        zinsobjekt.jahre = calculator.calcJahre(zinsobjekt);
                        System.Console.WriteLine(zinsobjekt.ToString() +"\n");
                        break;
                    case 5:
                        endLoop = true;
                        break;
                    default:
                        System.Console.WriteLine("Falsche Eingabe.");    
                        break;    
            }
            }while(!endLoop);
        }
    }
}