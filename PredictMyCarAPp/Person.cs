using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PredictMyCarAPp.Annotations;

namespace PredictMyCarAPp
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Person(string name, int id, bool isEmployed, bool isUnEmployed, bool isPensioner, bool isOther, bool hasShiftWork,bool worksFrom9Till5, bool hasPartTimeJob, bool hasFullTimeJob, bool isSick, bool isOnVacation, bool isInHomeOffice, bool worksInTheCompany, bool needsCarToCommuteToCompany, bool needsCarForShoppingTrip, bool needsCarForOtherTrip)
        {
            Name = name;
            ID = id;
            IsEmployed = isEmployed;
            IsUnEmployed = isUnEmployed;
            IsPensioner = isPensioner;
            IsOther = isOther;
            HasShiftWork = hasShiftWork;
            WorksFrom9Till5 = worksFrom9Till5;
            HasPartTimeJob = hasPartTimeJob;
            HasFullTimeJob = hasFullTimeJob;
            IsSick = isSick;
            IsOnVacation = isOnVacation;
            IsInHomeOffice = isInHomeOffice;
            WorksInTheCompany = worksInTheCompany;
            NeedsCarToCommuteToCompany = needsCarToCommuteToCompany;
            NeedsCarForShoppingTrip = needsCarForShoppingTrip;
            NeedsCarForOtherTrip = needsCarForOtherTrip;
        }

        
        public string Name { get; set; }

        public int ID { get; set; }

        
        public bool IsEmployed { get; set; }
        public bool IsUnEmployed { get; set; }

        public bool IsPensioner { get; set; }
        public bool IsOther { get; set; }

        public bool HasShiftWork { get; set; }
        public bool WorksFrom9Till5 { get; set; }
        public bool HasPartTimeJob { get; set; }
        public bool HasFullTimeJob { get; set; }
        public bool IsSick { get; set; }
        public bool IsOnVacation { get; set; }
        public bool IsInHomeOffice { get; set; }

        public bool WorksInTheCompany { get; set; }

        public bool NeedsCarToCommuteToCompany { get; set; }

        public bool NeedsCarForShoppingTrip { get; set; }
        public bool NeedsCarForOtherTrip { get; set; }

        private decimal[] _calculatedOutParameter { get; set; }

        public void SetCalculatedOutParameter(decimal[] outParameter)
        {
            _calculatedOutParameter = outParameter;
        }

        public ObservableCollection<NeededCarsData> NeedsCarData= new ObservableCollection<NeededCarsData>();

        public void AddNeedsCarData(NeededCarsData neededCarsData)
        {
            this.NeedsCarData.Add(neededCarsData);
        }
    }
}