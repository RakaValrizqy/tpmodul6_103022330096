using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            if (title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh lebih dari 100 karakter.");
            }
            this.title = title;
            this.id = rand.Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int jumlah)
        {
            try
            {
                if (jumlah > 10000000)
                {
                    throw new ArgumentException("Jumlah penambahan play count melebihi batas maksimum (10.000.000).");
                }

                checked
                {
                    this.playCount += jumlah;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Terjadi overflow saat menambah play count.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($" ID: {id}, Title: {title}, PlayCount: {playCount}");
        }
    }

    
}
