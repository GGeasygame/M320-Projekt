using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Journey journey = new Journey();
            Movable meansOfTransport = getInput(journey);

            Console.WriteLine("The journey will take you " + meansOfTransport.getSecondsUntilJourneyCompleted(journey) / 60.0 + " minutes");
            Console.WriteLine("Here is a short description to the means of transport you used: \n" + meansOfTransport.getDescription());
            Console.ReadKey();
        }

        private static Movable getInput(Journey journey)
        {
            Movable meansOfTransport;
            getStops(journey);
            meansOfTransport = getMeansOfTransport();
            return meansOfTransport;
        }

        private static Movable getMeansOfTransport()
        {
            string meansOfTransportAnswer;
            do
            {
                Console.Write("Enter your means of transport (car, plane, horse): ");
                meansOfTransportAnswer = Console.ReadLine();

                switch (meansOfTransportAnswer)
                {
                    case "car":
                        return new Car();
                    case "horse":
                        return new Horse();
                    case "plane":
                        return new Plane();
                    default:
                        return new Car();

                }
            } while (!isValidMeansOfTransportInput(meansOfTransportAnswer));
        }

        private static void getStops(Journey journey)
        {
            string answer;
            do
            {
                Console.Write("Enter distance until next stop: ");

                double distance = Convert.ToDouble(Console.ReadLine());
                journey.addStop(distance);

                Console.WriteLine("Would you like to add another stop? (y/n)");
                answer = Console.ReadLine();

            } while (answeredYes(answer));
        }

        private static bool answeredYes(String answer)
        {
            return answer.Equals("y") || answer.Equals("yes");
        }

        private static bool isValidMeansOfTransportInput(string input)
        {
            return input.Equals("car") || input.Equals("plane") || input.Equals("horse");
        } 
    }
}
