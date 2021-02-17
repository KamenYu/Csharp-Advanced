using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = int.Parse(Console.ReadLine());

            TryPark(dimensions, start);           
        }

        public static void TryPark(int[] dimensions, int start)
        {
            bool parked = false;
            string whereToPark = null;
            int matrixColIndex = dimensions[1] + 1;
            int totalSamSteps = 0;
            int colToStart = 0;

            while (parked == false)
            {
                string[] parkingSpots = Console.ReadLine()
                .Split();

                whereToPark = parkingSpots[start - 1];
                int[] spot = WhereToPark(parkingSpots, start, whereToPark);

                int samSteps = MovingToTarget(start, colToStart, spot, matrixColIndex);
                totalSamSteps += samSteps;

                if (IsConflict(parkingSpots, whereToPark))
                {
                    int rowToStartOther = IndexFinder(parkingSpots, whereToPark, start - 1) + 1;

                    int othersSteps = MovingToTarget(rowToStartOther, colToStart, spot, matrixColIndex);

                    if (samSteps > othersSteps)
                    {
                        totalSamSteps += samSteps;
                    }
                    else
                    {
                        parked = true;
                    }
                }
                else
                {
                    parked = true;
                }
            }

            ParkSuccess(whereToPark, totalSamSteps);
        }

        public static void ParkSuccess(string whereToPark, int totalSamSteps)
        {
            Console.WriteLine($"Parked successfully at {whereToPark}.");
            Console.WriteLine($"Total Distance Passed: {totalSamSteps}");
        }

        public static int IndexFinder(string[] parkingSpots, string whereToPark, int start)
        {
            int index = 0;

            for (int i = 0; i < parkingSpots.Length; i++)
            {
               if(parkingSpots[i] == whereToPark && i != start)
               {
                    index = i;
                    break;
               }
            }

            return index;
        }

        public static bool IsConflict(string[] parkingSpots, string whereToPark)
        {
            int counter = 0;

            counter = parkingSpots.Where(x => x == whereToPark).Count();

            return counter == 1 ? false : true;
        }

        public static int MovingToTarget(int start, int colToStart, int[] parkingCoordinates, int matrixColIndex)
        {
            int steps = 0;
            bool toRight = true;
            int rowToStart = (start * 2) - 1;
            int[] currentPosition = new int[] { rowToStart, colToStart }; 

            while (!There(currentPosition, parkingCoordinates))
            {
                steps++;
                currentPosition[1] += toRight ? 1 : -1;

                bool isEnd = currentPosition[1] == matrixColIndex && toRight
                    || currentPosition[1] == 0 && !toRight;

                if (isEnd)
                {
                    bool tagetRowIsAbove = currentPosition[0] > parkingCoordinates[0]; // hmmmm?
                    currentPosition[0] += tagetRowIsAbove ? -2 : 2;
                    toRight = !toRight;
                    steps += 2;
                }
            }

            return steps;
        }

        private static bool There(int[] currentPosition, int[] parkingCoordinates)
        {
            bool sameCol = currentPosition[1] == parkingCoordinates[1];

            bool rowAboveSpot = currentPosition[0] == parkingCoordinates[0] - 1;
            bool rowBelowSpot = currentPosition[0] == parkingCoordinates[0] + 1;
            bool rowNextToSpot = rowAboveSpot || rowBelowSpot;

            return sameCol && rowNextToSpot;
        }

        public static int[] WhereToPark(string[] parkingSpots, int rowToStart, string whereToPark)
        {            
            char[] chars = whereToPark.ToCharArray();

            int rowToPark = int.Parse(chars[1].ToString()) * 2 - 2;
            int colToPark = chars[0] - 64;

            int[] coordinates = new int[2] { rowToPark, colToPark};
            return coordinates;
        }
    }
}
