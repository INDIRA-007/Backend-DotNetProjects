namespace ServerManagement.Components.Models
{
    public class CitiesRepository
    {
        private static List<string> cities = new List<string>()
        {
            "Toronto",
            "Halifax",
            "Montreal",
            "Calgary",
            "Ottawa"
        };

        public static List<string> GetCities() => cities;
    }
}
