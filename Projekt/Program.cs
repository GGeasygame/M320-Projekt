﻿using System;
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
            string answer;

            do
            {
                Console.Write("Enter distance until next stop: ");

                double distance = Convert.ToDouble(Console.ReadLine());
                journey.addStop(distance);

                Console.WriteLine("Would you like to add another stop? (y/n)");
                answer = Console.ReadLine();

            } while (answeredYes(answer));

            string meansOfTransportAnswer;
            Movable meansOfTransport;
            do {
                Console.Write("Enter your means of transport (car, plane, horse): ");
                meansOfTransportAnswer = Console.ReadLine();
                
                switch (meansOfTransportAnswer)
                {
                    case "car":
                        meansOfTransport = new Car();
                        break;
                    case "plane":
                        break;
                    case "horse":
                        break;

                }
                meansOfTransport = new Car();
            } while (isValidMeansOfTransportInput(meansOfTransportAnswer));

            Console.WriteLine("The journey will take you " + meansOfTransport.getSecondsUntilJourneyCompleted(journey));
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
