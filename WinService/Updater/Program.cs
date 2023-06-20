using Updater;


var host = Host.CreateDefaultBuilder(args)
    .UseWindowsService(op =>
    {
        op.ServiceName = "Dijital Çelenk Updater Serivce";       
    })
    .ConfigureServices((hostContext, services) =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<Worker>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();