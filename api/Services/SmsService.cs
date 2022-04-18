namespace WebApi.Services;

using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System.Net;
using WebApi.Helpers;

public interface ISmsService
{
    Task SendMessage(string numero, string mensagem);
    string GetCredits();

}

public class SmsService : ISmsService
{
    private readonly AppSettings _appSettings;
    string key = "CQOQQ012QFLT7J0XE49OD5OL";


    public SmsService(IOptions<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }


    public string GetCredits()
    {
        try
        {
            var url = string.Format(@"https://api.smsdev.com.br/v1/balance?key={0}", key);
            using (WebClient webClient = new WebClient())
            {
                string reply = webClient.DownloadString(url);
                return Task.FromResult(reply).Result;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task SendMessage(string numero, string mensagem)
    {
        try
        {
            numero = numero.Replace("(", "").Replace(")", "");
            var url = string.Format(@"https://api.smsdev.com.br/send?key={2}&type=9&number={0}&msg={1}", numero, mensagem, key);
            using (WebClient webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}