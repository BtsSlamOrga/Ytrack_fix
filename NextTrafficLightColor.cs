// NextTrafficLightColor.cs

using CSharpDiscovery.Models;
namespace CSharpDiscovery.Quest01
{
    //Create a method GetNextTrafficLightColor() that returns the next traffic light color.

    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            //TODO : write your code here
            // A traffic light is a signaling device positioned at road intersections, pedestrian crossings, and other locations to control the flow of traffic.
            // The colors of a traffic light are typically red, yellow (or orange), and green.
            // TrafficsLightColor is an enum with the following values : None, Red, Green, Orange.
            //switch statement is a control statement that allows you to execute different code blocks based on the value of a variable or expression.
            switch (currentColor)
            {
                // The switch statement evaluates the value of currentColor and executes the corresponding case block.
                case TrafficLightColor.None:
                    return TrafficLightColor.None;
                case TrafficLightColor.Red:
                    return TrafficLightColor.Green;
                case TrafficLightColor.Green:
                    return TrafficLightColor.Orange;
                case TrafficLightColor.Orange:
                    return TrafficLightColor.Red;
            }
            // If the value of currentColor does not match any of the cases, the default block is executed.
            return TrafficLightColor.None;
        }
    }
}