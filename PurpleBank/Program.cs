using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen(c => {
 c.SwaggerDoc("v1", new OpenApiInfo { Title = "PurpleBank", Version = "v1" });
});
var app = builder.Build();
if (!app.Environment.IsDevelopment()) {
 app.UseExceptionHandler("/Error");
 app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI(c => {
 c.SwaggerEndpoint("/swagger/v1/swagger.json", "PurpleBank v1");
 c.RoutePrefix = "swagger"; 
});
app.UseRouting();
app.UseAuthorization();
app.MapControllers(); 
app.MapRazorPages();
app.Run();
/* var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment()) {
 app.UseSwagger();
 app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
*/