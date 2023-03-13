using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Portal_Remedios.Models;
using Portal_Remedios.Services;
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



/*
var remedios = new List<Remedios>
{
    new Remedios {Id = 1, Nome ="Novalgina" , Descricao = "Alfa beta gama" , Hora_Cadastro= DateTime.Now ,Link_Bula = ""}

};

var unidade = new List<Unidades>
{
    new Unidades {Nome = "UPA Mario Monteiro", Id = 1},
    new Unidades {Nome = "Hospital Estadual Azevedo Lima", Id = 2},
    new Unidades {Nome = "Policlinica Largo da Batalha", Id = 3},
    new Unidades {Nome = "Hospital Municipal Carlos Tortelly", Id = 4},
    new Unidades {Nome = "Hospital Universitario Antonio Pedro", Id = 5}
};

var regiao = new List<Regiao>
{
    new Regiao {Nome = "Niteroi" , Id = 1}
};

*/


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
