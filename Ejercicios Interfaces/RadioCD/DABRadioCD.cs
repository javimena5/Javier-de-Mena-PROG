using System;
namespace program
{
    class DABRadioCD : IMedia
    {
        CDPlayer cdplayer;
        DABRadio radio;
        private IMedia ActiveDevice{get; set;}
        public Disc InsertCD{
            set{
                if(ActiveDevice.GetType() == cdplayer.GetType() && cdplayer.MediaIn) throw new Exception("ERROR. Ya hay un CD.");
                else {
                    ActiveDevice = cdplayer;
                    cdplayer.InsertMedia(value);
                }
            }
        }

        public string MessageToDisplay{
            get {
                string message = "";
                if(ActiveDevice.GetType() == cdplayer.GetType()) message += "MODO: CD\n";
                else message += "MODO: RADIO\n";
                message+=ActiveDevice.MessageToDisplay+"\n[1]Play [2]Pause [3]Stop [4]Prev [5]Next [6]Switch [7]Insert CD [8]Extract CD, [ESC]Turn off";
                return message;
            }
        }

        public DABRadioCD(){
            cdplayer = new CDPlayer();
            radio = new DABRadio();
            ActiveDevice = radio;
        }
        public void ExtractCD(){
            ActiveDevice = radio;
            cdplayer.ExtractMedia();
        }

        public void SwitchMode(){
            if(ActiveDevice.GetType() == cdplayer.GetType()) ActiveDevice = radio;
            else ActiveDevice = cdplayer;
            ActiveDevice.Play();
        }

        public void Play()
        {
            ActiveDevice.Play();
        }

        public void Stop()
        {
            ActiveDevice.Stop();
        }

        public void Pause()
        {
            ActiveDevice.Pause();
        }

        public void Next()
        {
            ActiveDevice.Next();
        }

        public void Previous()
        {
            ActiveDevice.Previous();
        }
    }
}