using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_1302223136
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int sum = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                sum += uploadedVideos[i].GetPlayCount();
            }
            return sum;
        }

        public void AddVideo(SayaTubeVideo a)
        {
            uploadedVideos.Add(a);
        }

        public void PrintAllVideoPlaycount()
        {
            System.Console.WriteLine("User:" + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                System.Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i].GetTitle());
            }

        }
    }
}
