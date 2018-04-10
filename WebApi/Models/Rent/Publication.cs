using System;

namespace Models.Rent
{
    public class Publication
    {
        public int Id { get; set; }
        public int RentalObjectId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
