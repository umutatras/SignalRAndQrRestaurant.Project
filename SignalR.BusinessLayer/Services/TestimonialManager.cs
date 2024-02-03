using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.TestimonialDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class TestimonialManager : ServiceManager<TestimonialCreateDto, TestimonialUpdateDto, TestimonialListDto, Testimonial>, ITestimonialService
{
    public TestimonialManager(IMapper mapper, IValidator<TestimonialCreateDto> createValidator, IValidator<TestimonialUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
