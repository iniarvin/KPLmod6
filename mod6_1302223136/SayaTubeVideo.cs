using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_1302223136
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random i = new Random();
            this.id = i.Next(10000, 99999);

            if (title == "" || title == null)
            {
                System.Console.WriteLine("Judul video tidak boleh kosong");
            }
            else if(title.Length > 200) 
            {
                System.Console.WriteLine("Judul video memiliki panjang maksimal 200 karakter");
            }
            else
            {
                this.title = title;
            }

            this.playCount = 0;
        }

        public void IncreasePlayCount(int p)
        {
            this.playCount += p;
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }
        
        public string GetTitle() { 
            return this.title;
        }

        public void PrintVideoDetails()
        {
            System.Console.WriteLine("Video ID      : " + id);
            System.Console.WriteLine("Video Title   : " + title);
            System.Console.WriteLine("Playcount     : " + playCount);
            System.Console.WriteLine("");
        } 
    }
}
