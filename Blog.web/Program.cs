using Blog.web.Data;
using Blog.web.Repositories.Interfaces;
using Blog.web.Repositories;
using Blog.web.Services.Interfaces;
using Blog.web.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Configuration;
using BlogPostRepository = Blog.web.Repositories.BlogPostRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseBlog")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

builder.Services.AddScoped<IBlogPostRepository, BlogPostRepository>();
builder.Services.AddScoped<IBlogPostService, BlogPostService>();

builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddScoped<ITagService, TagService>();
builder.Services.AddScoped<ITagRepository, TagRepository>();


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddRazorPages();

//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddDbContext<BlogDbContext>(options =>
//        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//    services.AddDefaultIdentity<IdentityUser>()
//        .AddEntityFrameworkStores<ApplicationDbContext>();

//    services.AddControllersWithViews();
//}

builder.Services.AddScoped<IBlogPostRepository, BlogPostRepository>();

builder.Services.Configure<IdentityOptions>(options =>
{
options.Password.RequireDigit = true;
options.Password.RequiredLength = 6;
options.Password.RequireNonAlphanumeric = false; 
options.Password.RequireUppercase = true;
options.Password.RequireLowercase = false; 
options.Password.RequiredUniqueChars = 6;
options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
options.Lockout.MaxFailedAccessAttempts = 5; 
options.Lockout.AllowedForNewUsers = true;
options.User.RequireUniqueEmail = true;
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<BlogDbContext>();


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
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

