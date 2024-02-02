using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.CategoryDtos;

public class CategoryCreateDto : IDto
{
    public string Name { get; set; }
    public bool Status { get; set; }
}
