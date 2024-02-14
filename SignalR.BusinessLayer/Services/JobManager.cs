using Hangfire;
using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class JobManager : IJobService
{
    private readonly IBookingService _bookingService;
    private readonly IUnitOfWork _unitOfWork;

    public JobManager(IBookingService bookingService, IUnitOfWork unitOfWork)
    {
        _bookingService = bookingService;
        _unitOfWork = unitOfWork;
    }

    public async Task JobStart()
    {
        var localSaat = new TimeSpan(1, 0, 0);
        var utcDate = DateTime.Now.Date + localSaat;
        utcDate = utcDate.ToUniversalTime();

        string exp = Cron.Daily(utcDate.Hour, utcDate.Minute);
        RecurringJob.AddOrUpdate<JobManager>("Mail Yolla", j => j.HangfireStart(), exp);
    }
    public async Task HangfireStart()
    {
        var emails = await _unitOfWork.GetRepository<Booking>
            ().Query()
            .Select(x => x.Mail).ToListAsync();
        SmtpClient client = new SmtpClient();
        MimeMessage mimeMessage = new MimeMessage();
        var bodyBuilder = new BodyBuilder();

        foreach (var email in emails)
        {       
            MailboxAddress mailboxAddress = new MailboxAddress("Rezervasyon", "umutatras@gmail.com");
            mimeMessage.From.Add(mailboxAddress);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", email);
            mimeMessage.To.Add(mailboxAddressTo);

            bodyBuilder.TextBody = "Sayın Müşterim sizleri özledik. İşletmemize tekrar bekleriz";
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Otomatik Mail";
        
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("umutatras@gmail.com", "ukwl yzoz uqng khve");
            client.Send(mimeMessage);
          
        }
        client.Disconnect(true);

    }
}
