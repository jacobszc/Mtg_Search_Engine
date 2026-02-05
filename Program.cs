using Microsoft.EntityFrameworkCore;
using CompletemtgDatabase;
using System.Text.Json;
using  TestItemNS;
using Microsoft.Identity.Client;
using Json.Parser;
using System.Net.Http;

//static readonly HttpClient client = new HttpClient();



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

builder.Services.AddDbContext<mtgDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MagicCardDb")));

builder.Services.AddControllers();

builder.Services.AddOpenApi();


builder.Services.AddCors(options =>
{
    options.AddPolicy("DevCors", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});




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

app.UseCors("DevCors");

app.MapControllers();


// using (var scope = app.Services.CreateScope())
// {
//     var db = scope.ServiceProvider.GetRequiredService<mtgDbContext>();

//     var jsonPath = Path.Combine(app.Environment.ContentRootPath, "AllPrintings.json");

   
//     using var document = new AllPrintingsJsonDocumentConverter(jsonPath);

//      var final =  new AllPrintingsJsonDocumentDeserialzier(document.GetJsonDocument(), db);

    
// }




app.Run();
