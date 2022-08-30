using SiraUtil.Logging;
using Zenject;

namespace CrashOnMiss.Installers
{
    internal class GamePlayInstaller : Installer<GamePlayInstaller>
    {

        private readonly SiraLog _logger;

        public GamePlayInstaller(SiraLog logger)
        {
            _logger = logger;
            _logger.Info("GamePlayInstaller");
        }

        public override void InstallBindings()
        {
            Container.Bind<QuitOnMiss>().AsSingle();
        }

    }
}