namespace Domain.Entities.ETypes
{
    public enum ETypePaymentStatus : byte
    {
        Unpaid = 0,
        Paid = 1,
        Refunded = 2,
        PartiallyRefunded = 3,
        Canceled = 4
    }
}
