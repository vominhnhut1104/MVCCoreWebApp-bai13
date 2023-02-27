var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddMvc();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


//app.UseMvc();   
//app.UseMvcWithDefaultRoute();

 app.UseMvc(routes =>
{
//routes.MapRoute("secure", "secure", new
//{
//    Controller = "Admin",
//    Action = "Index"
//});

//routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:alpha:minlength(6)?}");
routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");


    //routes.MapRoute("default", "{controller}/{action}/{id}",
    //    new { controller = "Home", action = "Index" },
    //    new
    //    {
    //        id = new CompositeRouteConstraint(
    //            new IRouteConstraint[]
    //            {
    //                new AlphaRouteConstraint(), 
    //                new MinLengthRouteConstraint(6), 
    //            })
    //    });


    //routes.MapRoute("default", "{controller}/{action}/{id}",
    //    new {controller = "Home",action="Index"},
    //    new { id = new IntRouteConstraint()});

    //routes.MapRoute("default",
    //    "post/{id:int}",
    //    new { controller = "Post", action = "PostsByID" });

    //routes.MapRoute("anotherRoute",
    //    "post/{id:alpha}",
    //    new { controller = "Post", action = "PostsByPostName" });

    //routes.MapRoute("default",
    //    "{controller}/{action}/{year:regex(^\\d{{4}}$)}",
    //    new { controller = "Home", action = "Index" });
});



app.Run( async (context) =>
{
    await context.Response.WriteAsync("fail to find route");
});
app.Run();