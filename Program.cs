using Microsoft.EntityFrameworkCore;
using CompletemtgDatabase;
using System.Text.Json;
using  TestItemNS;
using Microsoft.Identity.Client;
using Json.Parser;
using System.Net.Http;

//static readonly HttpClient client = new HttpClient();



var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<mtgDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MagicCardDb")));

builder.Services.AddControllers();

builder.Services.AddOpenApi();

//builder.Services.AddSingleton<MtgJsonDeserializer>(new MtgJsonDeserializer("C:\\Users\\Jacob\\repos\\AllPrintings.json"));

var app = builder.Build();









app.UseHttpsRedirection();









app.UseDefaultFiles(); // Looks for index.html by default
 app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.MapGet("/loadjson", async (MtgJsonDeserializer loader) =>
// {
//     await loader.DeserializeMtgJson();
//     return Results.Ok("Loaded!");
// });

app.UseAuthorization();

app.MapControllers();




app.Run();
