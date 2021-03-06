﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given a list of Integers representing seat numbers, group them into ranges 1-10, 11-20, and 21-30.
         (Any seat number less than 1, or greater than 30 is invalid, and can be ignored.) Preserve the order
         in which the seat number entered their associated group. Return a list of the grouped Integers 1-10,
         11-20, and 21-30. (Hint: Think multiple queues)
         DIFFICULTY: HARD
		 BoardingGate( [1, 13, 43, 22, 8, 11, 30, 2, 4, 14, 21] ) -> [1, 8, 2, 4, 13, 11, 14, 22, 30, 21]
         BoardingGate( [29, 19, 9, 21, 11, 1, 0, 25, 15, 5, 31] ) -> [9, 1, 5, 19, 11, 15, 29, 21, 25]
         BoardingGate( [0, -1, 44, 31, 17, 7, 27, 16, 26, 6] ) -> [7, 6, 17, 16, 27, 26]
         */
        public List<int> BoardingGate(List<int> seatNumberList)
        {
            Queue<int> lowerRange = new Queue<int>();
            Queue<int> midRange = new Queue<int>();
            Queue<int> upperRange = new Queue<int>();

            Queue<Queue<int>> totalRange = new Queue<Queue<int>>();
            totalRange.Enqueue(lowerRange);
            totalRange.Enqueue(midRange);
            totalRange.Enqueue(upperRange);


            List<int> groupedIntegers = new List<int>();

            for (int i = 0; i < seatNumberList.Count; i++)
            {
                if (seatNumberList[i] < 1 || seatNumberList[i] > 30)
                {
                    seatNumberList.RemoveAt(i);
                    i--;
                }
                else if (seatNumberList[i] >= 1 && seatNumberList[i] <= 10)
                {
                    lowerRange.Enqueue(seatNumberList[i]);
                }
                else if (seatNumberList[i] >= 11 && seatNumberList[i] <= 20)
                {
                    midRange.Enqueue(seatNumberList[i]);
                }
                else if (seatNumberList[i] >= 21 && seatNumberList[i] <= 30)
                {
                    upperRange.Enqueue(seatNumberList[i]);
                }
            }

            while (totalRange.Count > 0)
            {
                Queue<int> tmp = totalRange.Dequeue();
                while (tmp.Count > 0)
                {
                    groupedIntegers.Add(tmp.Dequeue());
                }

            }

            return groupedIntegers;
        }
    }
}
