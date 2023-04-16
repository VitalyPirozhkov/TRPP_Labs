using TBPP_LABS.Models;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;

namespace TBPP_LABS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;
            var configuration = builder.Configuration;
            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    options.ClientId = "156838787140-oc5eg0hp2bs350nn7dubqb1f7bhl68n5.apps.googleusercontent.com-Client-Id";
                    options.ClientSecret = "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";
                });
            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.MapRazorPages();

            app.Run();

            Person person = new Person("Jake", "Moor");
            Person person1 = new Person("Jake", "Moor1");
        }
    }
}