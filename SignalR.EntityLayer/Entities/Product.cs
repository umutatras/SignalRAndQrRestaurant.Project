using SignalR.EntityLayer.Entities;

namespace SignalR.EntityLayer;

public class Product: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
    public int CategoryId { get; set; }

    #region NavigationProperty
    public virtual Category Category { get; set; }
    public virtual List<OrderDetail> OrderDetails { get; set; }
    #endregion
}
