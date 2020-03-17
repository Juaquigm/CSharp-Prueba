using System;
namespace HerenciasOpenWebinars
{
    public class Media
    {
        private int ParentRate;
        public String Title { get; set; }

        public virtual void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }

        protected bool ThisContentIsCorrectForthisAge(int age)
        {
            if (age >= ParentRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
