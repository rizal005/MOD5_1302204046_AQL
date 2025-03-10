﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD5_1302204046_AQL
{
    internal class SayaTubeUser
    {
        private int id;
        private String username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(String username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }

        public int GetTotalVideoPlay()
        {
            int hasil = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
                hasil = hasil + uploadedVideos[i].getPlayCount();

            return hasil;
        }

        public void AddVideo(SayaTubeVideo a)
        {
            uploadedVideos.Add(a);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + this.username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadedVideos[i].getTitle());
                Console.WriteLine();
                Console.WriteLine("Total semua playcount : " + GetTotalVideoPlay());
            }

        }

    }
}