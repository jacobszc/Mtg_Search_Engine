using Microsoft.EntityFrameworkCore;
using CompletemtgDatabase;
using System.Text.Json;
using  TestItemNS;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MagicCardDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MagiccardDb")));

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();


using (var scope = app.Services.CreateScope())
{
    var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true };
            
            string fileName = "test/test.json";
            string jsonString = File.ReadAllText(fileName);
            var _TestItem = JsonSerializer.Deserialize<TestItem>(jsonString, options)!;
            
            Console.WriteLine(_TestItem.Id);
            



}

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
