using System;

namespace project_pkdsim.Assets.USys.HSys.Base
{
    public class Holiday_Base
    {
        public string Name { get; }
        public DateTime Date { get; }
        public string AddressableKey { get; }
        protected bool NotAHoliday_Toggle;

        public Holiday_Base(string name, DateTime date, string addressableKey)
        {
            Name = name;
            Date = date;
            AddressableKey = addressableKey;
            NotAHoliday_Toggle = true;
        }

        public Holiday_Base()
        {
        }

        public bool IsHoliday(DateTime DateToCheck, DateTime today)
        {
            UpdateHolidayStatus(DateToCheck);
            return !NotAHoliday_Toggle;
        }

        public void UpdateHolidayStatus(DateTime dateToCheck)
        {
            NotAHoliday_Toggle = !(dateToCheck.Month == Date.Month && dateToCheck.Day == Date.Day);
        }
        
        public bool IsNotHoliday(DateTime DateTocCheck, DateTime Today)
        {
            UpdateHolidayStatus(DateTocCheck);
            return NotAHoliday_Toggle;
        }
    }
}
