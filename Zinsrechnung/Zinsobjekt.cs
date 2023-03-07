namespace Zinsrechnung
{
    public class Zinsobjekt
    {
        public double kapitlal {get; set;}
        public double zinssatz {get; set;}
        public double endkapital {get; set;}

        public override string ToString()
        {
            return "Kapital: " + kapitlal + "€, Zinssatz: " + zinssatz + "%, Endkapital: " + endkapital + "€";
        }
    }
}