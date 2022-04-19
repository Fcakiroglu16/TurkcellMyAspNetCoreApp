using MiddlewareExample.Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


#region MapWhen Kullanımı
//app.MapWhen(context => context.Request.Query.ContainsKey("name"), app => 

//{

//    app.Use(async (context, next) =>
//    {
//        await context.Response.WriteAsync("Before 1. Middleware\n");

//        await next();

//        await context.Response.WriteAsync("After 1. Middleware\n");

//    });
//    app.Run(async context =>
//    {

//        await context.Response.WriteAsync("Terminal 3. Middleware\n");


//    });


//});
#endregion

#region Map ve Run Kullanımı

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Before 1. Middleware\n");

//    await next();

//    await context.Response.WriteAsync("After 1. Middleware\n");

//});


//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Before 2. Middleware\n");

//    await next();

//    await context.Response.WriteAsync("After 2. Middleware\n");

//});


//app.Run(async context =>
//{

//    await context.Response.WriteAsync("Terminal 3. Middleware\n");


//}); 
#endregion

#region Map Methodu Kullanımı
//app.Map("/ornek", app =>
//{
//    //app.Run(async context =>
//    //{

//    //    await context.Response.WriteAsync("Ornek url'i için middleware");

//    //});
//}); 
#endregion



app.UseMiddleware<WhiteIpAddressControlMiddleware>();




app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
