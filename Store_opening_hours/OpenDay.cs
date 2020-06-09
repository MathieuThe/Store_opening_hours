namespace Store_opening_hours
{
    internal class OpenDay
    {
        private string dayName;
        private string openingHour;
        private string closingHour;

        /// <summary>
        /// New Open Day
        /// </summary>
        /// <param name="dn">DayName</param>
        /// <param name="oh">Opening Hour</param>
        /// <param name="ch">Closing Hour</param>
        public OpenDay(string dn, string oh, string ch)
        {
            this.dayName = dn;
            this.openingHour = oh;
            this.closingHour = ch;
        }

        internal string GetDayName
        {
            get { return dayName; }
        }

        internal string GetOpeningHour
        {
            get { return openingHour; }
        }   
        
        internal string GetClosingHour
        {
            get { return closingHour; }
        } 
    }
}