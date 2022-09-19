namespace CrashOnMiss.Interfaces
{

    public interface INoteEventHandler : IEventHandler
    {
        void OnNoteMiss(NoteData data);
    }
    
}