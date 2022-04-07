using System;
namespace program
{
    class Disc 
    {
        private string Album{get; set;}
        private string Artist{get; set;}
        private string[] Songs{get;}
        public ushort NumTracks{get;} 
        public Disc(string album, string artist, string[] songs){
            Album = album;
            Artist = artist;
            Songs = songs;
            NumTracks = (ushort) Songs.Length;
        }
        public string this[in int song] {
            get{
                if(song > 0 && song <= Songs.Length) {
                    return Songs[song-1];
                }else {
                    throw new ArgumentOutOfRangeException();
                }
            } 
        }

        public override string ToString()
        {
            return $"Álbum: {Album}  Artista: {Artist}";
        }
    }
}