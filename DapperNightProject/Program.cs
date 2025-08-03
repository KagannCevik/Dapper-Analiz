using DapperNightProject.Context;
using DapperNightProject.Services.DapperService;
using DapperNightProject.Services.DepartmentServices;
using DapperNightProject.Services.EfService;
using DapperNightProject.Services.EmployeeServices;
using DapperNightProject.Services.StatisticsServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<DapperContext>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IStatisticsService,StatisticsService>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContextDb>();

builder.Services.AddScoped<IEfService, EfService>();
builder.Services.AddScoped<IDapperService,DapperService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{   
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
