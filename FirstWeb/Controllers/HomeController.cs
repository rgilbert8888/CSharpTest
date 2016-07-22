using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Hello from c#";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CoriellTest()
        {
            var model = new Models.CoriellTestModel
            {
                RobynInput = "some gibberish here",
                WhoDat = "who is you??"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult CoriellTest(Models.CoriellTestModel model)
        {
            Console.WriteLine(model.RobynInput);
            Console.WriteLine(model.WhoDat);

            var value = model.RobynInput;

            //aaaaaabbbbbbbbbbccccdddddddddddddaaa

            var dict = new Dictionary<string, int>();
            for (int i = 0; i < value.Length; i++)
            {
                var item = value[i] + "_" + i; //$"{value[i]}_{i}";
                int lengthOfRun = 0;
                char currentChar = value[i];

                for (int j = i; j <= value.Length; j++)
                {
                    if (value[j] == currentChar)
                    {
                        lengthOfRun++;
                        continue;
                    }
                    i = j;
                    dict.Add(item, lengthOfRun);
                    break;
                }
            }

            var result = dict.OrderByDescending(x => x.Value).First().Key.Split('_')[1];
            model.IndexResult = int.Parse(result);
            return View(model);
        }
    }
}








//int currentIndex = 0,
//    indexOfLongestRunSoFar = 0;

//char lastChar = value[0];

//            for (int i = 1; i<value.Length; i++)
//            {
//                char currentChar = value[i];
//                if (currentChar != lastChar)
//                {
//                    indexOfLongestRunSoFar = i;
//                }
//                else
//                {

//                }

//                currentIndex++;
//            }

//            int answer = 0;