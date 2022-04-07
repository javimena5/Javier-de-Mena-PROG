using System;
namespace program
{
    enum MediaState
    {
        Stopped, Paused, Playing
    }
    
    interface IMedia
    {
        string MessageToDisplay{get;}
        void Play();
        void Stop();
        void Pause();
        void Next();
        void Previous();
        
    }
}