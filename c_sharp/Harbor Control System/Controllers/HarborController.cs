using Microsoft.AspNetCore.Mvc;
using System;

namespace Harbor_Control_System.Controllers
{
    public class HarborController : Controller
    {
        private enum Status { Occupied, Not_Occupied }
        private string currentStatus;
        public string CurrentStatus
        {
            get
            {
                var random = new Random();
                var value = random.Next(2);

                switch (value)
                {
                    case 0:
                        currentStatus = Status.Occupied.ToString();
                        break;
                    case 1:
                        currentStatus = Status.Not_Occupied.ToString().Replace('_', ' ');
                        break;
                }
                return currentStatus;
            }
        }

        public string Output()
        {

            if (currentStatus == Status.Occupied.ToString())
            {
                return "The Harbor entrance is currently in use, please wait few minutes";
            }
            else
            {
                return "Please proceed to the Harbor entrnce";

                //
            }
        }

        //

    }
}
