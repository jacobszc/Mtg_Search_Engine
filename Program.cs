﻿


using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<MagicCardDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MagiccardDb")));


builder.Services.AddControllers();
//Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var app = builder.Build();
//app.UseHttpsRedirection();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<MagicCardDbContext>();
       
       if(!dbContext.Database.CanConnect())
    {

        throw new NotImplementedException("cant connect");
    }




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
