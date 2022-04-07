using System;
namespace program
{
    class CDPlayer : IMedia
    {
        Disc disc;
        private ushort Track{get;set;}
        private MediaState State{get;set;}
        public bool MediaIn{get; private set;}

        public CDPlayer(){
            State = MediaState.Playing;
            Track = 1;
            MediaIn = false;
        }
        public string MessageToDisplay{
            get {
                string message = "NO DISC\n";
                if(MediaIn){
                    switch (State){
                        case MediaState.Playing:
                            message = $"PLAYING... {disc}. Track {Track} {disc[Track]}\n";
                            break;
                        case MediaState.Paused:
                            message = $"PAUSED... {disc}. Track {Track} {disc[Track]}\n";
                            break;
                        case MediaState.Stopped:
                        message = $"STOPPED... {disc}\n";
                            break;
                    }
                }
                return message;
            }
        }

        public void Next()
        {
            if(Track == disc.NumTracks) Track=1;
            else Track++;
        }

        public void Pause()
        {
            if(State==MediaState.Paused){
                State=MediaState.Playing;
            }
            else if(State==MediaState.Playing){
                State=MediaState.Paused;
            }

        }

        public void Play()
        {
            if(State == MediaState.Stopped){
                Track = 1;
                State = MediaState.Playing;
            }else{
                State = MediaState.Playing;
            }
        }

        public void Previous()
        {
            if(Track == 1) Track= disc.NumTracks;
            else Track--;
        }

        public void Stop()
        {
            
            State=MediaState.Stopped;
            
        }
        public void InsertMedia(Disc media){
            MediaIn = true;
            Track = 1;
            disc = media;
            Play();
        }
        public void ExtractMedia(){
            MediaIn = false;
            Track = 1;
            disc = null;
            Stop();
        }
    }
}