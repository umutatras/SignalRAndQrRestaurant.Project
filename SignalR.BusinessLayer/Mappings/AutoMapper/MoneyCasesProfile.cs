using AutoMapper;
using SignalR.DtoLayer.MoneyCase;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class MoneyCasesProfile:Profile
{
    public MoneyCasesProfile()
    {
        CreateMap<MoneyCase,MoneyCaseListDto>().ReverseMap();
        CreateMap<MoneyCase,MoneyCaseCreateDto>().ReverseMap();
        CreateMap<MoneyCase,MoneyCaseUpdateDto>().ReverseMap();
    }
}
