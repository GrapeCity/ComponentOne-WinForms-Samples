namespace TransposeSample
{
    // Create a custom class Hotel
    internal class Hotel
    {
        static Random _rnd = new Random();
        static string[] _names = ["Dragon Hotel", "Tiger's Nest", "Wind Horse"];
        static double[] _roomRevenue = [54000, 45000, 32000];
        static double[] _restaurantRevenue = [50000, 46000, 49000];
        static double[] _barRevenue = [23000, 43250, 10100];
        static double[] _otherRevenue = [9800, 5500, 20200];
        static double[] _grossRevenue = [136000, 139750, 111300];
        static double[] _pat = [75600, 71388, 36900];
        static double[] _expense = [52000, 60430, 70200];
        static double[] _totalGuest = [821, 750, 668];
        static double[] _totalStaff = [20, 23, 30];
        static double[] _numberRooms = [21, 19, 15];
        public Hotel(int i)
        {
            HotelName = _names[i];
            RoomRevenue = _roomRevenue[i];
            RestaurantRevenue = _restaurantRevenue[i];
            BarRevenue = _barRevenue[i];
            OtherRevenue = _otherRevenue[i];
            GrossRevenue = _grossRevenue[i];
            PAT = _pat[i];
            Expense = _expense[i];
            TotalGuests = _totalGuest[i];
            TotalStaff = _totalStaff[i];
            NumberRooms = _numberRooms[i];
        }
        public string HotelName { get; set; }
        public double RoomRevenue { get; set; }
        public double RestaurantRevenue { get; set; }

        public double BarRevenue { get; set; }

        public double OtherRevenue { get; set; }
        public double GrossRevenue { get; set; }
        public double PAT { get; set; }
        public double Expense { get; set; }
        public double TotalGuests { get; set; }

        public double TotalStaff { get; set; }
        public double NumberRooms { get; set; }
    }
}