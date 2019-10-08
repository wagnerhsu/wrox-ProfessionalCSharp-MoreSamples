using System;
using ASPNETCore21Authentication.Data;
using ASPNETCore21Authentication.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ASPNETCore21Authentication.Areas.Identity.IdentityHostingStartup))]
namespace ASPNETCore21Authentication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

                services.AddTransient<IEmailSender, EmailSender>();

            });
        }
    }
}