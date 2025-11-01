using Microsoft.EntityFrameworkCore;
using CompletemtgDatabase;
using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MagicCardDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MagiccardDb")));

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();


// using (var scope = app.Services.CreateScope())
// {
//             string fileName = "C:\\Users\\Jacob\repos\\AllPrintings.json";
//             string jsonString = File.ReadAllText(fileName);
//             CompletemtgDbContext mtgDbContext = JsonSerializer.Deserialize<CompletemtgDbContext>(jsonString)!;
            
//             //Console.WriteLine($"Date: {mtgDbContext.Rulings}");
            



// }

app.UseDefaultFiles(); // Looks for index.html by default
 app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



app.UseAuthorization();

app.MapControllers();




app.Run();
