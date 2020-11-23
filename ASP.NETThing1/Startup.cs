using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASP.NETThing1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // goal: make it to any existing html page, + error handleing if it not exists.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //? used to re-route traffic to endpoints
            app.UseRouting();


            //used to server the end points after getting routed to them (EG, if you go to some place, and the site wants to redirect you based on the url,
            // do some routing first)
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet()

                

                endpoints.MapGet("/hi", async context =>
                {
                    PathString path = new PathString(context.Request.Path);
                    Console.WriteLine(path);
                    if (File.Exists(path))
                    {
                        await context.Response.WriteAsync(await File.ReadAllTextAsync(path));
                    }
                    else
                    {
                        await context.Response.WriteAsync(path.ToString());
                    }

                });

                endpoints.MapGet("/", async context =>
                    {
                        PathString path = new PathString(context.Request.Path);
                        Console.WriteLine(path);
                        if (File.Exists(path))
                        {
                            await context.Response.WriteAsync( await File.ReadAllTextAsync(path));
                        } else
                        {
                            await context.Response.WriteAsync(path.ToString());
                        }

                    });
            });


            /*
            //right track, probably easier in the app.run
            app.MapWhen(context => context.Request.Path.Value.EndsWith(".html"), async context =>
              {
                  PathString path = new PathString(context.UseRequestLocalization.Path);
                  Console.WriteLine(path);
                  if (File.Exists(path))
                  {
                      await context.Response.WriteAsync(await File.ReadAllTextAsync(path));
                  }
                  else
                  {
                      await context.Response.WriteAsync(path.ToString());
                  }
              }
            );
            */

            //
            //app.UseStaticFiles();

            app.Run(async context =>
            {
                Console.WriteLine(context.Request.Path);
                await context.Response.WriteAsync("Didn't map to anything so you get this!. <p>");
            });
        }
    }
}
