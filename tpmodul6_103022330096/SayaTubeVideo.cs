using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022330096
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        Random rand = new Random();

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.id = rand.Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int jumlah)
        {
            this.playCount += jumlah;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($" ID: {id}, Title: {title}, PlayCount: {playCount}");
        }
    }

    
}
