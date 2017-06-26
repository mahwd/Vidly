namespace Vidly.Models
{
    public class MemberShipType
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public byte Duration { get; set; }
        public int DiscountRate { get; set; }
        public int MemberShipTypeId { get; set; }
    }
}