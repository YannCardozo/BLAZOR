using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Portal_Remedios.Data;
using Portal_Remedios.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();


static async void Rodar()
{
    try
    {
        HttpClient cliente = new HttpClient();

        string resultado = await cliente.GetStringAsync("http://www.macoratti.net/vbn_jqsm.htm");
        Console.WriteLine(resultado);
    }
    catch
    {
        throw;
    }
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
