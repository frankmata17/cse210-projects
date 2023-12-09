using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create activity objects
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("03 Nov 2022", 30, 6.0);
        Swimming swimmingActivity = new Swimming("03 Nov 2022", 30, 2);

        // Add activities to the list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display activity summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}