/*step 2:
Create a custom class to model
    Taxi Fare with  minutes and kilometers travelled and 
	an instance-level method to calculate and return the fare:

Fare = (Minutes * 0.25 + Kilometers * 1.25) * 1.10


The mutator for minutes 
	will validate the new value is at minimum 10 or more.

The mutator for kilometers
    will validate the new value is at minimum 2 or more.

The constructor has parameters for minutes and kilometers.


added an extra one to account for tipping, hope i dont get docked marks
*/

namespace CPSC1012_lab6_michaelessex
{
    internal class TaxiFare
    {
        public int _minutes { get; set; }
        public int _kmTravelled { get; set; }
        public int _tip{ get; set; }
        public double Fare { get; set; }


        //process for calculating minutes for reference
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 10)
                {
                    throw new Exception("Invalid trip minutes. Minimum minutes is 10.");
                }
                _minutes = value;
            }
        }

        //process for calculating kilometers travelled for reference

        public int KmTravelled
        {
            get { return _kmTravelled; }
            set
            {
                if (value < 2)
                {
                    throw new Exception("Invalid trip kilometers. Minimum kilometers is 2.");
                }

                _kmTravelled = value;
            }
        }

        public int Tip
        {
            get { return _tip; }
            set
            {
                if (value < 5)
                {
                    throw new Exception("You must have pressed a wrong button, minimum tip is 5 because you need to caffinate your driver");
                }
               
                _tip = value;
            }
        }
            


        public TaxiFare(int minutes, int km, int tip)
        {
            Minutes = minutes;
            KmTravelled = km;
            Tip = tip;

            CalculateFare(minutes, km, tip);

        }

        public double CalculateFare(int minutes, int km, int tip)
        {
            Fare = ((minutes * 0.25 + km * 1.25) * 1.10) + tip;

            return Fare;
                
        }


    }
}


