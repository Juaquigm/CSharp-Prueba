using System;
namespace HerenciasOpenWebinars
{
    public class Song: Media
    {
        public long Seconds { get; set; }

       
        public ShelvePosition Position { get; set; }

        public override void Play()
        {
            Console.WriteLine("Increase volume");
            base.Play();
        }
        /*
        public override bool Equals(object obj)
        {
            // == 
            return base.Equals(obj);
        }
        */
        public override bool Equals(object obj)
        {
            var mediaObj = (Media)obj;

            if(mediaObj.Title == this.Title)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Consejo no tocar demasiado el HashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // 
        public override string ToString()
        {
            return $"Title: {Title}, Duration: {Seconds} esto es el metodo ToString";
        }

    }
}

