var builder = WebApplication.CreateBuilder(args);

// Add MVC services to the container
builder.Services.AddMvc();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.MapControllers();   
/*
app.UseEndpoints(endpoints =>
{
    //Configuring the MVC middleware to the request processing pipeline
    endpoints.MapDefaultControllerRoute();
});
*/


app.Run();

