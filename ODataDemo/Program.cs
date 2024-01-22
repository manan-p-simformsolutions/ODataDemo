using Microsoft.OData.Edm;
using ODataDemo.Models;
using ODataDemo.Services;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;

namespace ODataDemo
{
    public class Program
    {
        static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new();
            builder.EntitySet<Employee>("Employees");
            return builder.GetEdmModel();
        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddOData(opt => opt.AddRouteComponents("v1", GetEdmModel()).Filter().Select().Expand().Count().OrderBy().SetMaxTop(20));

            builder.Services.AddScoped<EmployeeService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}