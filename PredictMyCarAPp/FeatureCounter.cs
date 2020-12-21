namespace PredictMyCarAPp
{
    public class FeatureCounter
    {


        public int IDCounter { get; set; }
        public int IsEmployedCounter { get; set; }
        public int IsUnEmployedCounter { get; set; }
        public int IsPensionerCounter { get; set; }
        public int IsOtherCounter { get; set; }
        public int HasShiftWorkCounter { get; set; }
        public int WorksFrom9Till5Counter { get; set; }
        public int HasPartTimeJobCounter { get; set; }
        public int HasFullTimeJobCounter { get; set; }
        public int IsSickCounter { get; set; }
        public int  IsOnVacationCounter { get; set; }
        public int IsInHomeOfficeCounter { get; set; }
        public int WorksInTheCompanyCounter { get; set; }
        public int NeedsCarToCommuteToCompanyCounter { get; set; }
        public int  NeedsCarForShoppingTripCounter { get; set; }
        public int  NeedsCarForOtherTripCounter { get; set; }

        public void AddPerson(Person person)
        {
            if (person == null)
            {
                return;
            }

            IDCounter++;
            if (person.IsEmployed)
            {
                IsEmployedCounter++;
            }

            if (person.IsUnEmployed)
            {
                IsUnEmployedCounter++;
            }

            if (person.IsPensioner)
            {
                IsPensionerCounter++;
            }

            if (person.IsOther)
            {
                IsOtherCounter++;
            }

            if (person.HasShiftWork)
            {
                HasShiftWorkCounter++;
            }

            if (person.WorksFrom9Till5)
            {
                WorksFrom9Till5Counter++;
            }

            if (person.HasPartTimeJob)
            {
                HasPartTimeJobCounter++;
            }

            if (person.HasFullTimeJob)
            {
                HasFullTimeJobCounter++;
            }

            if (person.IsSick)
            {
                IsSickCounter++;
            }

            if (person.IsOnVacation)
            {
                IsOnVacationCounter++;
            }

            if (person.IsInHomeOffice)
            {
                IsInHomeOfficeCounter++;
            }

            if (person.WorksInTheCompany)
            {
                WorksInTheCompanyCounter++;
            }

            if (person.NeedsCarToCommuteToCompany)
            {
                NeedsCarToCommuteToCompanyCounter++;
            }

            if (person.NeedsCarForShoppingTrip)
            {
                NeedsCarForShoppingTripCounter++;
            }

            if (person.NeedsCarForOtherTrip)
            {
                NeedsCarForOtherTripCounter++;
            }

        }


    }
}