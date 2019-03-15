using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace departmentPage.Models
{
    public class Departm
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }

        public Departm()
        {
            title = "";
            subtitle = "";
            p1 = "";
            p2 = "";
        }

        public void Produce()
        {
            title = "Produce";
            subtitle = "Produce Palace!";
            p1 = "When our customers think <strong>Super King</strong> the first thing that comes to mind is <strong>Produce</strong>.";
            p2 = "We guarantee fresh produce and the lowest prices every day. Our produce variety includes strawberries, blueberries, avocados, the largest variety of eggplant anywhere and even pomegranates.";
        }

    }
}