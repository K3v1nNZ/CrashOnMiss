using CrashOnMiss.Interfaces;
using SiraUtil.Logging;
using UnityEngine;
using Zenject;

namespace CrashOnMiss
{
    internal class QuitOnMiss : INoteEventHandler
    {

        public void OnNoteMiss(NoteData data)
        {
            
            if (data.colorType != ColorType.None) Application.Quit();
        }
        
    }
}