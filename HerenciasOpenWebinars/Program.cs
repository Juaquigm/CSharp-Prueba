using System;
using System.Collections.Generic;

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

            PlayList<Song> playListSongs = new PlayList<Song>();

            playListSongs.Add(song);
            playListSongs.Add(song2);

            WriteLineSpecial(song, "Start with", "enjoy");

            Tuple<int, string, Song> tuple = new Tuple<int, string, Song>(0, "Hola", song);

           
            ListExplanation();
            StackExplanation();
            QueueExplanation();
            DictionaryExplanation();




            // Aqui compara solo los titulos 
            Console.WriteLine(song.Equals(song2));
            
            Console.WriteLine(song2.ToString());
            Console.ReadKey(); // Pause cuando demos enter pues terminaria en nuestro casp
        }

        private static void ListExplanation()
        {
            List<int> numbers = new List<int>();
            numbers.Add(0);
            //numbers.Count
            //Dist
        }
        private static void StackExplanation()
        {
            /*
            Stack<Song> salesSongs = new Stack<Song>();
            salesSongs.Push(new Song());
            Song song = salesSongs.Pop();
            */
        }
        private static void QueueExplanation()
        {
            Queue<int> queueNumbers = new Queue<int>();
            queueNumbers.Enqueue(1);
            queueNumbers.Dequeue();
        }

        private static void DictionaryExplanation()
        {
            Dictionary<string, Cliente> clientes = new Dictionary<string, Cliente>();
            clientes.Add("000000000", new Cliente() { Nombre = "Juaki" });
            //Da error lo siguiente ya que es lo mismo clave
            //clientes.Add("000000000", new Cliente() { Nombre = "Luis" });
            if (!clientes.ContainsKey("000000000"))
            {
                clientes.Add("000000000", new Cliente() { Nombre = "Luis" });

            }
            //Para llamar clientes["000000000"]
            clientes["000000000"] = new Cliente();
            Cliente miCliente = clientes["000000000"];
            //Keys para especificar las claves o Values solo los valores
            //clientes.TryGetValue("000000000");
        }
        static void WriteLineSpecial<T>(T data, string prefix, string suffix)
        {
            Console.WriteLine($"{prefix} {data} {suffix}");
        }

       
    }
}
