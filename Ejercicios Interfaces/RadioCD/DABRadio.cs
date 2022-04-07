using System;
namespace program
{
    class DABRadio : IMedia
    {
        const float SEEK_STEP = 0.5F;
        const float MAX_FREQUENCY = 108F;
        const float MIN_FREQUENCY = 87.5F;

        private float Frequency{get;set;}
        private MediaState State{get;set;}

        public string MessageToDisplay{
            get {
                string message = "NO DISC\n";
                switch (State){
                    case MediaState.Playing:
                        message = $"HEARING... FM - {Frequency:F1} MHz\n";
                        break;
                    case MediaState.Paused:
                        message = $"PAUSED - BUFFERING... FM - {Frequency:F1} MHz\n";
                        break;
                    case MediaState.Stopped:
                    message = $"RADIO OFF\n";
                        break;
                }
                return message;
            }
        }

        public DABRadio(){
            Frequency = MIN_FREQUENCY;
            State = MediaState.Playing;
        }

        public void Play()
        {
            if(State == MediaState.Stopped){
                Frequency = MIN_FREQUENCY;
                State = MediaState.Playing;
            }else{
                State = MediaState.Playing;
            }
        }

        public void Stop()
        {
            State=MediaState.Stopped;
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

        public void Next()
        {
            if(Frequency == MAX_FREQUENCY) Frequency=MIN_FREQUENCY;
            else Frequency = Frequency + SEEK_STEP;
        }

        public void Previous()
        {
            if(Frequency == MIN_FREQUENCY) Frequency= MAX_FREQUENCY;
            else Frequency = Frequency - SEEK_STEP;
        }
    }
}