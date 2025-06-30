namespace FlexGridExplorer.Samples
{
    // Create a custom class Hotel
    internal class Hotel
    {
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