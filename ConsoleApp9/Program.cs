using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            playable.Pause();
            playable.Play();
            playable.Stop();
            IRecordable recordable = new Player();
            recordable.Pause();
            recordable.Record();
            recordable.Stop();
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
         
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();

    }
    class Player : IPlayable, IRecordable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("IPlayable.Pause");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

         void IRecordable.Pause()
        {
            Console.WriteLine("IRecordable.Pause()");
        }

         void IRecordable.Stop()
        {
            Console.WriteLine("IRecordable.Stop()");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("IPlayable.Stop()");
        }
    }

}

