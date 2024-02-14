using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }
    [HttpGet]
    public async Task JobStart()
    {
        await _jobService.JobStart();
    }
}
