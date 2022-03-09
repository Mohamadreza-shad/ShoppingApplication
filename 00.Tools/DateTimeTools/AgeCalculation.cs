namespace _00.Tools.DateTimeTools
{
    public static class AgeCalculation
    {
        public static int CalculateAge(this DateTime dateTime)
        {
            int age = DateTime.UtcNow.Year - dateTime.Year;
            return (DateTime.UtcNow < dateTime.AddYears(age)) ? age--:age ;
        }
    }
}
