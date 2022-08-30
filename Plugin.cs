using CrashOnMiss.Installers;
using IPA;
using IPA.Logging;
using SiraUtil.Zenject;

namespace CrashOnMiss
{
    [Plugin(RuntimeOptions.DynamicInit), NoEnableDisable]
    public class Plugin
    {
        [Init]
        public Plugin(Logger logger, Zenjector zenject)
        {
            zenject.UseLogger(logger);
            zenject.UseMetadataBinder<Plugin>();
            
            zenject.Install<GamePlayInstaller>(Location.Player);
        }
    }
}
