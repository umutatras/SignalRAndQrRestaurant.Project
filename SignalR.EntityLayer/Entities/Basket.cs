namespace SignalR.EntityLayer.Entities;

public class Basket : BaseEntity
{
    public int ProductId { get; set; }
    public int DeskId { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }

    #region NavigationProperty
    public virtual Product Product { get; set; }
    public virtual Desk Desk { get; set; }
    #endregion
}
