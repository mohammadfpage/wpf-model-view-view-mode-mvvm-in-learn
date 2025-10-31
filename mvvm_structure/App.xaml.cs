﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mvvm_structure.ApplicationDbContext;
using mvvm_structure.Repository;
using mvvm_structure.Service;
using mvvm_structure.ViewModel;
using System;
using System.Windows;

namespace mvvm_structure
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<AppDbContext>();

                    services.AddScoped<IUserRepository, UserRepository>();

                    services.AddScoped<IUserService, UserService>();

                    services.AddTransient<MainViewModel>();

                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await _host.StartAsync();

            var mainWindow = _host.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
            base.OnExit(e);
        }
    }
}
