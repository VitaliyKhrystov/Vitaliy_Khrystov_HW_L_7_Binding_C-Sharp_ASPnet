using System.Reflection.Emit;

namespace Task1
{
    public class Program
    {

        //Задание 1 (Additional Task)
        //<form action="/Home/Index " method="post">
        //<label>First</label>
        //<input name = "first" />
        //< br />
        //< label > Second </ label >
        //< input name="second" />
        //<br />
        //<label>Count</label>
        //<input type = "number" name="count" />
        //<br />
        //<button type = "submit" > Create </ button >
        //</ form >
        //Создайте представление и скопируйте в него код выше.
        //Подготовьте соответствующий метод действия, который сможет получить значения из данной
        //формы и отображать их в Output окно Visual Studio.Для решения задачи используйте привязку
        //модели.


        public static void Main(string[] args)
        {
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

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}