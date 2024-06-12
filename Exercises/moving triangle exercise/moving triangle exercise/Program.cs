public override bool AppliesToHorse(Horse myhorse)
{
    BrisRace race = myhorse.CorrespondingBrisHorse.Parent;
    BrisHorse horse = myhorse.CorrespondingBrisHorse;

    try
    {
        List<BrisPastPerformance> pp = horse.PastPerformances;

        if (pp.Count <= 1)
        {
            return false;
        }
        else
        {

            //int finalPosition1 = Convert.ToInt32(pp[0].FinalPosition.Trim());
            //int finalPosition2 = Convert.ToInt32(pp[1].FinalPosition.Trim());

            return pp[0].WasTheWinner && pp[1].WasTheWinner;

        }
    }
    catch
    {
        return false;
    }
}
