using Azure.Core;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Reflection.PortableExecutable;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Reflection.Metadata.Ecma335;
using CodeFirst.PartTwo.Models;
using CodeFirst.Services.ExternalAPI.DeserializeJSON;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CodeFirst.Services.ExternalAPI
{
    public class CarAPI
    {
        public async Task<List<string>> CallExternalAPI(int year, string brand) 
        {
            var client = new HttpClient();
                 var request = new HttpRequestMessage
                 {
                      Method = HttpMethod.Get,
                      RequestUri = new Uri("https://car-api2.p.rapidapi.com/api/models?make="+ brand +"&sort=id&direction=asc&year="+ year +"&verbose=yes"),
                      Headers =
                      {
                        { "X-RapidAPI-Key", "839558d3a1msh460b3a6bedc8125p1018f6jsn355abf4ce822" },
                        { "X-RapidAPI-Host", "car-api2.p.rapidapi.com" },
                      },
                 };
            List<string> models = new List<string>();

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var root = JsonSerializer.Deserialize<Root>(body);

                for (int i = 0; i < root.data.Count; i++)
                {
                    models.Add(root.data[i].name);
                }

            }

            return models;
        }
        }
    }
