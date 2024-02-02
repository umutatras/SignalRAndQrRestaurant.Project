using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.CategoryDtos;

public class CategoryUpdateDto : IUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
