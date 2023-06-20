using UpdaterExtensions;
using UpdaterExtensions.WinApi;

namespace Updater
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger) => _logger = logger;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //    await Task.Delay(1000, stoppingToken);
            //}            
        }
        

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                //ProcessExtensions.StartProcessAsCurrentUser(@"D:\Projects\Dijital-Celenk-SignalR\Dijital-Celenk\Yeni-Setup\DijitalCelenkSetup\bin\Release\net7.0-windows\publish\win-x64\Dijital Celenk Setup.exe",
                //    "runas");
                
                String applicationName = @"D:\Projects\Dijital-Celenk-SignalR\Dijital-Celenk\Yeni-Setup\DijitalCelenkSetup\bin\Release\net7.0-windows\publish\win-x64\Dijital Celenk Setup.exe";
                ApplicationLoader.PROCESS_INFORMATION procInfo;
                ApplicationLoader.StartProcessAndBypassUAC(applicationName, out procInfo);


                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.CompletedTask;
            }
        }


        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

    }
}