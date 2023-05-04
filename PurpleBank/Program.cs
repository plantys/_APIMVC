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
using AutoMapper;
using PurpleBank.Controllers;
using PurpleBank.Models;
using PurpleBank.CodeGeneration;

var entityModels = ModelBuilder.BuildModels();
var generatedEntities = ScribanCodeGenerator.GenerateCode(entityModels); //ans01
//var generatedEntities = ScribanCodeGenerator.GenerateCode(entityModels).ToList(); //ans01
//var generatedEntities = ScribanCodeGenerator.GenerateCode(entityModels.Select(em => em.EntityType).ToList());


//Dictionary<string, string> generatedEntities = ScribanCodeGenerator.GenerateCode(entityModels.Select(em => em.EntityType).ToList());
//var generatedEntities = ScribanCodeGenerator.GenerateCode(entityModels);


foreach (var generatedEntity in generatedEntities) {
 var fileName = $"GeneratedEntities/{generatedEntity}.cs";
 File.WriteAllText(fileName, generatedEntity);
}




//foreach (var generatedEntity in generatedEntities) {
// var fileName = $"GeneratedEntities/{generatedEntity.Key}.cs";
// File.WriteAllText(fileName, generatedEntity.Value);
//}

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();

// Register AutoMapper with the services collection
builder.Services.AddAutoMapper(typeof(MappingProfile));

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






/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AutoMapper;
using PurpleBank.Controllers;
using PurpleBank.Models;
using PurpleBank.CodeGeneration;

var entityModels = ModelBuilder.BuildModels();
ScribanCodeGenerator.GenerateCode(entityModels);

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();

// Register AutoMapper with the services collection
builder.Services.AddAutoMapper(typeof(MappingProfile));

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
*/



/*using Microsoft.OpenApi.Models;
using PurpleBank.CodeGeneration;

var entityModels = ModelBuilder.BuildModels();
var generatedEntities = ScribanCodeGenerator.GenerateCode(entityModels);
foreach (var generatedEntity in generatedEntities) {
 var fileName = $"GeneratedEntities/{generatedEntity.Key}.cs";
 File.WriteAllText(fileName, generatedEntity.Value);
}

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();

// Register AutoMapper with the services collection
builder.Services.AddAutoMapper(typeof(MappingProfile));

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

app.Run(); */

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AutoMapper; // Add this using statement

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();

// Register AutoMapper with the services collection
builder.Services.AddAutoMapper(typeof(Startup)); // Replace 'Startup' with the appropriate class containing your AutoMapper configuration

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

app.Run();*/



/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add AutoMapper services
builder.Services.AddAutoMapper(typeof(Startup));
builder.Services.AddDbContext<MyDbContext>(); // Replace `MyDbContext` with the actual name of your DbContext class

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
app.Run();*/


/*using System;
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
*/