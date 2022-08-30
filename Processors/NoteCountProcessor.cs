using System.Collections.Generic;
using System.Linq;
using Zenject;

namespace CrashOnMiss.Processors
{
    public abstract class NoteCountProcessor
    {
        public List<NoteData> Data => data ??= GetNoteData(beatmapData);

        public int NoteCount => Data.Count;

        private List<NoteData> data;


        [Inject] private IReadonlyBeatmapData beatmapData;

        protected List<NoteData> GetNoteData(IReadonlyBeatmapData data)
        {
            return data
                .GetBeatmapDataItems<NoteData>()
                .Where(noteData => noteData.gameplayType != NoteData.GameplayType.Bomb && !ShouldIgnoreNote(noteData))
                .ToList();
        }

        public abstract bool ShouldIgnoreNote(NoteData data);
    }
}