using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Profile> profiles = new List<Profile>();

            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하동훈", Height = 171 });
            profiles.Add(new Profile() { Name = "톰크루즈", Height = 170 });

            var profiles1 = from item in profiles
                            orderby item.Height ascending
                            select item;

            Console.WriteLine("전체 프로필 리스트(키 오름차순)");
            foreach (var item in profiles1)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm");
            }

            /*
            List<Profile> newProfiles = new List<Profile>();
            foreach (var item in profiles)
            {
                if (item.Height < 172)
                    newProfiles.Add(item);
            }
            */

            var newProfiles = from item in profiles
                              where item.Height < 172
                              orderby item.Height descending
                              select item;

            
            Console.WriteLine("172 이하 프로필 리스트");
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm");
            }

            // 15.3
            Console.WriteLine();
            InstClass[] arrClass =
            {
                new InstClass() {Name="연두반",Score=new int[]{99,80,70,24 }},
                new InstClass() {Name="분홍반",Score=new int[]{60,45,87,72 }},
                new InstClass() {Name="파랑반",Score=new int[]{92,30,85,94 }},
                new InstClass() {Name="노랑반",Score=new int[]{90,88,0,17 }}
            };
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };
            foreach (var c in classes)
            {
                Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
            }

            // groupby
            Console.WriteLine();
            var listProfile = from item in profiles
                              group item by item.Height < 172 into g
                              select new { GroupKey = g.Key, profiles = g };
            foreach (var item in listProfile)
            {
                Console.WriteLine($"-172cm 미만?:{item.GroupKey}");

                foreach (var sub in item.profiles)
                {
                    Console.WriteLine($">>>> {sub.Name}:{sub.Height}");
                }
            }

        }
    }
}
