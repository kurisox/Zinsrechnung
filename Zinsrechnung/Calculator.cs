namespace Zinsrechnung
{
    public class Calculator
    {
        public double calcEndkapital (Zinsobjekt zinsobjekt){
            return Math.Round(zinsobjekt.kapitlal * (1+ (zinsobjekt.zinssatz * zinsobjekt.jahre) / 100),2);
        }

        public double calcStartkapital (Zinsobjekt zinsobjekt){
            return Math.Round(zinsobjekt.endkapital / (1+ (zinsobjekt.zinssatz * zinsobjekt.jahre) / 100), 2);
        }

        public double calcZinssatz (Zinsobjekt zinsobjekt){
            return Math.Round(((zinsobjekt.endkapital / zinsobjekt.kapitlal - 1) * 100) / zinsobjekt.jahre, 2);
        }

        public double calcJahre( Zinsobjekt zinsobjekt){
            return Math.Round(((zinsobjekt.endkapital / zinsobjekt.kapitlal - 1) * 100) / zinsobjekt.zinssatz,2);
        }
    }
}