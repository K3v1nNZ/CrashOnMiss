using CrashOnMiss.Interfaces;
using Zenject;

namespace CrashOnMiss.Event_Broadcasters
{

    internal class NoteEventBroadcaster : EventBroadcaster<INoteEventHandler>
    {
        [Inject] private BeatmapObjectManager beatmapObjectManager;

        public override void Initialize()
        {
            beatmapObjectManager.noteWasMissedEvent += NoteWasMissedEvent;
        }

        private void NoteWasMissedEvent(NoteController data)
        {
            foreach (INoteEventHandler noteEventHandler in EventHandlers)
            {
                noteEventHandler?.OnNoteMiss(data.noteData);
            }
        }

        public override void Dispose()
        {
            beatmapObjectManager.noteWasMissedEvent -= NoteWasMissedEvent;
        }
    }
    
}