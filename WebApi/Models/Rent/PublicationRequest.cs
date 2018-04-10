using System;

namespace Models.Rent
{
    public class PublicationRequest
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int PublicationId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public bool IsApproved { get; set; }
    }
}
