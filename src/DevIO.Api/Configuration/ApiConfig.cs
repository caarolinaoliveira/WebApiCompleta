// using Microsoft.AspNetCore.Builder;
// using Microsoft.Extensions.DependencyInjection;

// namespace DevIO.Api.Configuration
// {
//     public static class ApiConfig
//     {
//         public static IServiceCollection WebApiConfig(this IServiceCollection services)
//         {
//             builder.Services.AddControllers()
//             .AddJsonOptions(options =>
//             {
//             options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
//             });

//             builder.Services.AddCors(options =>
//             {
//                 options.AddPolicy("AllowAngular",
//                     policy => policy
//                         .WithOrigins("http://localhost:4200")
//                         .AllowAnyHeader()
//                         .AllowAnyMethod());
//             });

//             builder.Services.Configure<ApiBehaviorOptions>(options =>
//             {
//                 options.SuppressModelStateInvalidFilter = true;
//             });


//         }

//         public static IApplicationBuilder UseMvcConfiguration(this IApplicationBuilder app)
//         {
            
//             app.UseHttpsRedirection();


//             app.UseCors("AllowAngular");

//             app.MapControllers();

//             return app;
//         }
//     }
// }