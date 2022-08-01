int CalculateDaysBetweenDates(DateTime firstDate, DateTime secondDate)
{
    int days = (int)(secondDate - firstDate).TotalDays;
    return days;
}