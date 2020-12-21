using System;

namespace PredictMyCarAPp
{
    public class Simulation
    {
        private static Simulation _instance;

        public static Simulation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Simulation();
                }

                return _instance;
            }
        }

        public decimal[] Calculate(Person person)
        {
            //decimal dec1 = person.IsEmployed ? 1 : 0;
            //decimal dec2 = person.IsUnEmployed ? 1 : 0;
            //decimal dec3 = person.IsPensioner ? 1 : 0;
            //decimal dec4 = person.IsOther ? 1 : 0;
            //decimal dec5 = person.HasShiftWork ? 1 : 0;
            //decimal dec6 = person.WorksFrom9Till5 ? 1 : 0;
            //decimal dec7 = person.HasPartTimeJob ? 1 : 0;
            //decimal dec8 = person.HasFullTimeJob ? 1 : 0;
            //decimal dec9 = person.IsSick ? 1 : 0;
            //decimal dec10 = person.IsOnVacation ? 1 : 0;
            //decimal dec11 = person.IsInHomeOffice ? 1 : 0;
            //decimal dec12 = person.WorksInTheCompany ? 1 : 0;
            //decimal dec13 = person.NeedsCarToCommuteToCompany ? 1 : 0;
            //decimal dec14 = person.NeedsCarForShoppingTrip ? 1 : 0;
            //decimal dec15 = person.NeedsCarForOtherTrip ? 1 : 0;

            decimal[] output = new decimal[24];
            CheckCommutesToCompany(person, output);
            CheckShoppingTrip(person, output);
            CheckOtherTrip(person, output);


            //decimal[] output = new decimal[24];
            return output;
        }

        private void CheckShoppingTrip(Person person, decimal[] output, int minWaitingTimeAfterUsage = 0)
        {
            if (!person.NeedsCarForShoppingTrip)
            {
                return;
            }

            // 7-20 
            var shoppingIndex = rnd.Next(7, 20 + 1);
            output[shoppingIndex] = 1;
            
            for (int index = shoppingIndex + 1; index < shoppingIndex + 1 + minWaitingTimeAfterUsage; index++)
            {
                if (index < output.Length)
                {
                    output[index] = 1;
                }
            }
        }

        private void CheckOtherTrip(Person person, decimal[] output, int minWaitingTimeAfterUsage = 0)
        {
            if (!person.NeedsCarForOtherTrip)
            {
                return;
            }

            // 0-23 
            var shoppingIndex = rnd.Next(0, 23 + 1);
            output[shoppingIndex] = 1;

            for (int index = shoppingIndex + 1; index < shoppingIndex + 1 + minWaitingTimeAfterUsage; index++)
            {
                if (index < output.Length)
                {
                    output[index] = 1;
                }
            }
        }


        private Random rnd = new Random();

        private void CheckCommutesToCompany(Person person, decimal[] output)
        {
            //decimal[] output = new decimal[24];
            if (!person.NeedsCarToCommuteToCompany)
            {
                return;
            }

            if (person.WorksFrom9Till5)
            {
                // 6,7,8,9
                var startWorkIndex = rnd.Next(6, 9 + 1);
                output[startWorkIndex] = 1;
                SetEndWork(startWorkIndex, person, output);
            }

            if (person.HasShiftWork)
            {
                // 2,3,4,5 oder 11,12,13,14 oder 20,21,22,23
                // a,b,c
                var shiftIndex = rnd.Next(1, 3 + 1);
                switch (shiftIndex)
                {
                    case 1:
                        var startWorkIndexShiftA = rnd.Next(2, 5 + 1);
                        output[startWorkIndexShiftA] = 1;
                        SetEndWork(startWorkIndexShiftA, person, output);
                        break;
                    case 2:
                        var startWorkIndexShiftB = rnd.Next(11, 14 + 1);
                        output[startWorkIndexShiftB] = 1;
                        SetEndWork(startWorkIndexShiftB, person, output);
                        break;
                    case 3:
                        var startWorkIndexShiftC = rnd.Next(20, 23 + 1);
                        output[startWorkIndexShiftC] = 1;
                        SetEndWork(startWorkIndexShiftC, person, output);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="startWorkIndex"></param>
        /// <param name="person"></param>
        /// <param name="output"></param>
        /// <param name="useCarWhileWholeWork">Während der Arbeit wird das Auto nicht weiter gegeben. Es wird eine Stunde zusätzlich hinzugefügt. Die minimale WarteZeit im Auswertebereich kann und sollte anschließend auf 0 gesetzt werden, da diese hier schon mit einberechnet wird!</param>
        private void SetEndWork(in int startWorkIndex, Person person, decimal[] output, bool useCarWhileWholeWork = false, int minWaitingTimeAfterUsage=0)
        {
            if (useCarWhileWholeWork)
            {
                //Modifizierung: Während der Arbeit wird das Auto nicht weiter gegeben. Es wird eine Stunde zusätzlich hinzugefügt. Die WarteZeit soll anschließend auf 0 gesetzt werden!
                if (person.HasFullTimeJob)
                {
                    //7,8,9,10,11
                    var endWork = rnd.Next(7, 11 + 1);
                    int endIndex = startWorkIndex + endWork;
                    for (int index = startWorkIndex; index <= endIndex + minWaitingTimeAfterUsage; index++)
                    {
                        if (index < output.Length)
                        {
                            output[index] = 1;
                        }
                    }
                    return;
                }

                //partTime 3,4,5
                var endWorkPartTime = rnd.Next(3, 5 + 1);
                int endIndexPartTime = startWorkIndex + endWorkPartTime;
                for (int index = startWorkIndex; index <= endIndexPartTime + minWaitingTimeAfterUsage; index++)
                {
                    if (index < output.Length)
                    {
                        output[index] = 1;
                    }
                }
                return;
            }
            //!useCarWhileWholeWork
            if (person.HasFullTimeJob)
            {
                //7,8,9,10,11
                var endWork = rnd.Next(7, 11 + 1);
                int endIndex = startWorkIndex + endWork;
                if (endIndex < output.Length)
                {
                    output[endIndex] = 1;
                }
                return;
            }

            //partTime 3,4,5
            var endWorkPartTime2 = rnd.Next(3, 5 + 1);
            int endIndexPartTime2 = startWorkIndex + endWorkPartTime2;
            if (endIndexPartTime2 < output.Length)
            {
                output[endIndexPartTime2] = 1;
            }
            return;
        }
    };
}