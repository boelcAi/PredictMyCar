using System.ComponentModel;
using System.Runtime.CompilerServices;
using PredictMyCarAPp.Annotations;


namespace PredictMyCarAPp
{
    public class RegionStatistics : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public RegionStatistics()
        {
            Employed = 54;
            ShiftWork = 16;
            PartTimeJob = 28;
            HomeOffice = (decimal) 3.5;
            Holidays = (decimal) 30.9;
            SickDays = (decimal) 10.9;
            CommuteWithCar = (decimal) 67.7;
            UnEmployed = 2;
            Pensioner = 26;
            ShoppingTripsWithCars = (decimal) 70;
            NumberOfShoppingTripsPer5Days = 1;
            OtherTrips = 85;
            NumberOfOtherTripsPer5Days = (decimal) 0.5;
        }

        public RegionStatistics(decimal employed, decimal shiftWork, decimal partTimeJob, decimal homeOffice, decimal holidays, decimal sickDays, decimal commuteWithCar, decimal unEmployed, decimal pensioner, decimal shoppingTripsWithCars, decimal numberOfShoppingTripsPer5Days, decimal otherTrips, decimal numberOfOtherTripsPer5Days)
        {
            Employed = employed;
            ShiftWork = shiftWork;
            PartTimeJob = partTimeJob;
            HomeOffice = homeOffice;
            Holidays = holidays;
            SickDays = sickDays;
            CommuteWithCar = commuteWithCar;
            UnEmployed = unEmployed;
            Pensioner = pensioner;
            ShoppingTripsWithCars = shoppingTripsWithCars;
            NumberOfShoppingTripsPer5Days = numberOfShoppingTripsPer5Days;
            OtherTrips = otherTrips;
            NumberOfOtherTripsPer5Days = numberOfOtherTripsPer5Days;
        }

        public decimal Employed { get; set; }

        public decimal ShiftWork { get; set; }

        public decimal PartTimeJob { get; set; }
        public decimal HomeOffice { get; set; }
        public decimal Holidays { get; set; }
        public decimal SickDays { get; set; }
        public decimal CommuteWithCar { get; set; }
        public decimal UnEmployed { get; set; }

        public decimal Pensioner { get; set; }
        public decimal ShoppingTripsWithCars { get; set; }

        public decimal NumberOfShoppingTripsPer5Days { get; set; }
        public decimal OtherTrips { get; set; }
        public decimal NumberOfOtherTripsPer5Days { get; set; }
    }
}