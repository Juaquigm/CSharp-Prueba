﻿using System;

namespace HerenciasOpenWebinars
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.Title = "JUPITER";
            song.Seconds = 300;
            song.Position = new ShelvePosition(1, 2);
            song.Play();

            Song song2 = new Song();
            song2.Title = "JUPITER";
            song2.Seconds = 200;
            song2.Position = new ShelvePosition(3, 4);

            // Aqui compara solo los titulos 
            Console.WriteLine(song.Equals(song2));
            
            Console.WriteLine(song2.ToString());
            Console.ReadKey(); // Pause cuando demos enter pues terminaria en nuestro casp
        }
    }
}