namespace Zinsrechnung
{
    public class Calculator
    {
        public double calcEndkapital (Zinsobjekt zinsobjekt){
            return zinsobjekt.kapitlal * (1+ (zinsobjekt.zinssatz * zinsobjekt.jahre) / 100);
            //return zinsobjekt.kapitlal*Math.Pow(1 + (zinsobjekt.zinssatz/100), zinsobjekt.jahre);
        }

        public double calcStartkapital (Zinsobjekt zinsobjekt){
            return zinsobjekt.endkapital / (1+ (zinsobjekt.zinssatz * zinsobjekt.jahre) / 100);
            //return zinsobjekt.endkapital / Math.Pow(1 + zinsobjekt.zinssatz / 100, zinsobjekt.jahre);
        }

        public double calcZinssatz (Zinsobjekt zinsobjekt){
            return ((zinsobjekt.endkapital / zinsobjekt.kapitlal - 1) * 100) / zinsobjekt.jahre;
            //return 100*(Math.Pow(zinsobjekt.endkapital / zinsobjekt.kapitlal, 1 / zinsobjekt.jahre) -1);
        }

        public double calcJahre( Zinsobjekt zinsobjekt){
            return ((zinsobjekt.endkapital / zinsobjekt.kapitlal - 1) * 100) / zinsobjekt.zinssatz;
        }
    }
}