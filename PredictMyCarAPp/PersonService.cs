using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace PredictMyCarAPp
{
    public class PersonService
    {
        private static PersonService _instance;
        public static PersonService Instance 
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new PersonService();
                }

                return _instance;
            }

            private set{}
        }

        public PersonService()
        {

        }

        public (ObservableCollection<Person>, FeatureCounter) CreatePersons(decimal nmbToCreate, RegionStatistics regionStatistics)
        {
            FeatureCounter fc = new FeatureCounter();
            int nmbToCreateInt = (int)nmbToCreate;
            ObservableCollection<Person> persons = new ObservableCollection<Person>();
            /*
            int o = 0;

            
            //Paralleles Erzeugen
            var result = Parallel.For(0, nmbToCreateInt, (o) =>
            {
                Person person = CreateRandomPerson(o, regionStatistics);
                lock (fc)
                {
                  fc.AddPerson(person);  
                }
                
                lock (person)
                {
                    persons.Add(person);
                }
                
            });
            
            List<int> listIndexes= new List<int>();
            for (var index = 0; index < persons.Count; index++)
            {
                var VARIABLE = persons[index];
                if (VARIABLE == null)
                {
                    listIndexes.Add(index);
                }
            }

            for (int i = listIndexes.Count-1; i >=0; i--)
            {
                var index=listIndexes[i];
                listIndexes.RemoveAt(index);
            }*/

            
            for (int i = 0; i < nmbToCreate; i++)
            {
                Person person = CreateRandomPerson(i, regionStatistics);
                fc.AddPerson(person);
                persons.Add(person);
            }


            return (persons, fc);
        }

        private Person CreateRandomPerson(int i, RegionStatistics regionStatistics)
        {
            string name = RandomNames.Instance.GetNameAndFamilyName();

            int id = i;

            GenerateEmploymentRelationship(regionStatistics,out var isEmployed, out var isUnEmployed, out var isPensioner, out var isOther);
            GenerateEmploymentConditions(isEmployed, regionStatistics, out var hasShiftWork,out var worksFrom9Till5, out var hasPartTimeJob, out var hasFullTimeJob );
            GenerateEmploymentIsInCompany(isEmployed, regionStatistics, out var isSick,out var isOnVacation,out var isInHomeOffice,out var worksInTheCompany);
            GenerateCommuteToCompany(worksInTheCompany, regionStatistics, out var needsCarToCommuteToCompany);
            GenerateCarForShopping(regionStatistics, out var needsCarForShoppingTrip);
            GenerateCarForOtherTrip(regionStatistics, out var needsCarForOtherTrip);
            Person person = new Person(name, id, isEmployed,  isUnEmployed,  isPensioner,  isOther,  hasShiftWork, worksFrom9Till5,hasPartTimeJob,hasFullTimeJob,  isSick,  isOnVacation,  isInHomeOffice,  worksInTheCompany,  needsCarToCommuteToCompany,  needsCarForShoppingTrip, needsCarForOtherTrip);
            return person;
        }

        private void GenerateCarForOtherTrip(RegionStatistics regionStatistics, out bool needsCarForOtherTrip)
        {
            needsCarForOtherTrip = false;

            if (HitsProbability(regionStatistics.OtherTrips))
            {
                if (HitsProbability(regionStatistics.NumberOfOtherTripsPer5Days / 5 * 100))
                {
                    needsCarForOtherTrip = true;
                }
            }
            
            return;
        }

        private void GenerateCarForShopping(RegionStatistics regionStatistics, out bool needsCarForShoppingTrip)
        {
            needsCarForShoppingTrip = false;
            if (HitsProbability(regionStatistics.ShoppingTripsWithCars))
            {
                if (HitsProbability(regionStatistics.NumberOfShoppingTripsPer5Days / 5 * 100))
                {
                    needsCarForShoppingTrip = true;
                }
            }
            return;
        }




        private void GenerateCommuteToCompany(in bool worksInTheCompany, RegionStatistics regionStatistics, out bool needsCarToCommuteToCompany)
        {
            needsCarToCommuteToCompany = false;
            if (worksInTheCompany && HitsProbability(regionStatistics.CommuteWithCar))
            {
                needsCarToCommuteToCompany = true;
            }
        }

        private void GenerateEmploymentIsInCompany(in bool isEmployed, RegionStatistics regionStatistics, out bool isSick, out bool isOnVacation, out bool isInHomeOffice, out bool worksInTheCompany)
        {

            isSick = false;
            isOnVacation = false;
            isInHomeOffice = false;
            worksInTheCompany = false;

            if (!isEmployed)
            { 
                return;
;
            }
            if (HitsProbability(regionStatistics.SickDays/220*100))
            {
                isSick = true;
            }
            if (HitsProbability(regionStatistics.Holidays / (254) * 100))
            {
                isOnVacation = true;
            }
            if (HitsProbability(regionStatistics.HomeOffice))
            {
                isInHomeOffice = true;
            }

            if (!isSick && !isOnVacation && !isInHomeOffice)
            {// muss tatsächlich in die Firma und dort arbeiten
                worksInTheCompany = true;
            }
        }

        private void GenerateEmploymentConditions(bool isEmployed, RegionStatistics regionStatistics, out bool hasShiftWork, out bool worksFrom9Till5 ,out bool hasPartTimeJob, out bool hasFullTimeJob)
        {
            hasShiftWork = false;
            hasPartTimeJob = false;
            worksFrom9Till5 = false;
            hasFullTimeJob = false;
            if (!isEmployed)
            {
                return;
            }

            if (HitsProbability(regionStatistics.ShiftWork))
            {
                hasShiftWork=true;
            }
            else
            {
                worksFrom9Till5 = true;
            }
            if (HitsProbability(regionStatistics.PartTimeJob))
            {
                hasPartTimeJob = true;
            }
            else
            {
                hasFullTimeJob = true;
            }
        }

        public int EmployeeCounter = 0;
        private Random rnd = new Random();

        private void GenerateEmploymentRelationship(RegionStatistics regionStatistics, out bool isEmployed,  out bool isUnEmployed, out bool isPensioner, out bool isOther)
        {
            isEmployed = false;
            isUnEmployed = false;
            isPensioner = false;
            isOther = false;
            var val = rnd.Next(0, 100000);
            if (regionStatistics.UnEmployed * 1000 > val)
            {
                isUnEmployed = true;
                return;
            }

            if ((regionStatistics.UnEmployed + regionStatistics.Pensioner) * 1000 > val)
            {
                isPensioner = true;
                return;
            }
            if ((regionStatistics.UnEmployed + regionStatistics.Pensioner+regionStatistics.Employed) * 1000 > val)
            {
                isEmployed = true;
                EmployeeCounter++;
                return;
            }

            isOther = true;
            return;

        }


        private bool HitsProbability(decimal probability)
        {
            var val =rnd.Next(0,100000);
            if (probability * 1000 > val)
            {
                return true;
            }

            return false;
        }


        public decimal[] GetKnnInputForPerson(Person person)
        {


            decimal dec1 = person.IsEmployed ? 1 : 0;
            decimal dec2 = person.IsUnEmployed ? 1 : 0;
            decimal dec3 = person.IsPensioner ? 1 : 0;
            decimal dec4 = person.IsOther ? 1 : 0;
            decimal dec5 = person.HasShiftWork ? 1 : 0;
            decimal dec6 = person.WorksFrom9Till5 ? 1 : 0;
            decimal dec7 = person.HasPartTimeJob ? 1 : 0;
            decimal dec8 = person.HasFullTimeJob ? 1 : 0;
            decimal dec9 = person.IsSick ? 1 : 0;
            decimal dec10 = person.IsOnVacation ? 1 : 0;
            decimal dec11 = person.IsInHomeOffice ? 1 : 0;
            decimal dec12 = person.WorksInTheCompany ? 1 : 0;
            decimal dec13 = person.NeedsCarToCommuteToCompany ? 1 : 0;
            decimal dec14 = person.NeedsCarForShoppingTrip ? 1 : 0;
            decimal dec15 = person.NeedsCarForOtherTrip ? 1 : 0;
            
            decimal[] input = new decimal[15] { dec1, dec2, dec3, dec4, dec5, dec6, dec7, dec8, dec9, dec10, dec11, dec12, dec13, dec14, dec15 };
            
            return input;
        }
    }


}