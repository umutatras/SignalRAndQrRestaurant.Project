namespace SignalR.EntityLayer.Entities;

public class OrderDetail : BaseEntity
{
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public int Count { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }

    #region NavigationProperty
    public virtual Product Product { get; set; }
    public virtual Order Order { get; set; }
    #endregion

}
