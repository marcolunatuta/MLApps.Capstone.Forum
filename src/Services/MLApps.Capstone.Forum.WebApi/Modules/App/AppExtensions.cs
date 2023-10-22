﻿namespace MLApps.Capstone.Forum.WebApi.Modules.App
{
    public static class AppExtensions
    {
        public static WebApplication AddApplication(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            return app;
        }
    }
}