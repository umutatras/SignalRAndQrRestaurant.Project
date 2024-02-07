namespace SignalR.EntityLayer.Entities;

public class Order : BaseEntity
{
    public string TableNumber { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalPrice { get; set; }

    #region NavigationProperty
    public virtual List<OrderDetail> OrderDetails { get; set; }
    #endregion
}
