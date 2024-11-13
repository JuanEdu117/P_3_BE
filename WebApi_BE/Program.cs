using BLL.Interfase;
using BLL.SQLServer;
using DAL.Interfase;
using DAL.SQLServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//INYECCION DEPENDENCIA SQLSERVER
builder.Services.AddTransient(typeof(IInvent_DAL), typeof(cls_Invent_DAL));
builder.Services.AddTransient(typeof(IInvent_BLL), typeof(cls_Invent_BLL));
builder.Services.AddTransient(typeof(IInvent_DAL), typeof(cls_Invent_DAL));
builder.Services.AddTransient(typeof(IInvent_BLL), typeof(cls_Invent_BLL));
builder.Services.AddTransient(typeof(IInvent_DAL), typeof(cls_Invent_DAL));
builder.Services.AddTransient(typeof(IInvent_BLL), typeof(cls_Invent_BLL));
builder.Services.AddTransient(typeof(IInvent_DAL), typeof(cls_Invent_DAL));
builder.Services.AddTransient(typeof(IInvent_BLL), typeof(cls_Invent_BLL));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
