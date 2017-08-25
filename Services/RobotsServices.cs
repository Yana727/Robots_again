using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Robots_again.Models;
using System.Linq; 

namespace Robots_again.Services
{
    public class RobotsServices
    {


        public static List<RobotModel> Builder()
        {
            using (var reader = new StreamReader(System.IO.File.Open("robots.json", FileMode.Open)))
            {
                var robotsInfo = JsonConvert.DeserializeObject<List<RobotModel>>(reader.ReadToEnd());
                return robotsInfo;
            }
        }
    }
}