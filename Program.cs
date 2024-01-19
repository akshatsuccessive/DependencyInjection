using MyDependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// (i) Add MVC services to the container
builder.Services.AddMvc();

// Add Application Service to the Container

builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
//builder.Services.AddSingleton(typeof(IStudentRepository), typeof(StudentRepository));
//builder.Services.AddTransient<IStudentRepository, StudentRepository>();
//builder.Services.AddTransient(typeof(IStudentRepository), typeof(StudentRepository));
//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
//builder.Services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


/*
app.UseEndpoints(endpoints =>
{
    // (ii) Configuring the MVC middleware to the request processing pipeline
    endpoints.MapDefaultControllerRoute();
});
*/

app.Run();

