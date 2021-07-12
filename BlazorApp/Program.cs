using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Octokit;
using System.Threading;
using System.IO;

namespace BlazorApp
{
    public class Program
    {
        public static async Task<List<string>> userSearchAsync(string username)
        {
          var userList = await githubAPIAsync(username); 

            return userList;
        }
        public static async Task<List<string>> githubAPIAsync(string userName)
        {
            File.Delete("userList.txt");
            File.Delete("idList.txt");

            var github = new GitHubClient(new ProductHeaderValue("VermeerTest"));
                var request = new SearchUsersRequest(userName)
                {
                    In = new[] { UserInQualifier.Username, UserInQualifier.Email, UserInQualifier.Fullname },
                    SortField = UsersSearchSort.Followers
                };

            var result = await github.Search.SearchUsers(request);

                List<string> userList = new List<string>();
                List<string> idList = new List<string>();
            
            foreach (var Item in result.Items)
                {
                        userList.Add(Item.Login.ToString());
                        idList.Add(Item.Id.ToString());
                }

            System.IO.File.WriteAllLines("UserList.txt", userList);
            System.IO.File.WriteAllLines("idList.txt", idList);
            return userList;
        }

        public static void genList()
        {
                Globals.userList = File.ReadAllLines("UserList.txt").ToList();
                Globals.idList = File.ReadAllLines("idList.txt").ToList();
                Globals.count = Globals.userList.Count;
        }

        public static void waitFile()
        {
            while (!File.Exists("UserList.txt"))
            {
                Thread.Sleep(1000);
            }

        }


        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
