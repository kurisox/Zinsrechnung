namespace Zinsrechnung
{
    public class Calculator
    {
        public double calcEndkapital (Zinsobjekt zinsobjekt){
            return zinsobjekt.kapitlal * (1 + (zinsobjekt.zinssatz / 100));
        }

        public double calcStartkapital (Zinsobjekt zinsobjekt){
            return Math.Round(zinsobjekt.endkapital / (1 + (zinsobjekt.zinssatz / 100)));
        }

        public double calcZinssatz (Zinsobjekt zinsobjekt){
            return ((zinsobjekt.endkapital - zinsobjekt.kapitlal) / zinsobjekt.kapitlal) * 100;
        }
    }
}