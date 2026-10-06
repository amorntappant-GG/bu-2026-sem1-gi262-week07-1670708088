using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            // Your code here ...
            // ...
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            // Your code here ...
            // ...
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    if (array[r, c] == target)
                    {
                        row = r;
                        col = c;
                        break;
                    }
                }
            }

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            // Your code here ...
            // ...
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else if (array[mid] > target)
                {
                    right = mid - 1;
                }
            }
            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int first = -1;
            int last = -1;

            // ไล่เช็คทุกตัวใน array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    // ถ้าเจอครั้งแรก ให้เก็บตำแหน่งไว้
                    if (first == -1)
                    {
                        first = i;
                    }

                    // ถ้าเจออีก ให้เก็บตำแหน่งล่าสุด
                    last = i;
                }
            }

            // ถ้าไม่เจอ target เลย ให้คืนแค่ -1
            if (first == -1)
            {
                return new[] { -1 };
            }

            // ถ้าเจอ ให้คืนตำแหน่งแรกกับตำแหน่งสุดท้าย
            return new[] { first, last };
        }


        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int max = -1;

            // ไล่เช็คทุกตัวใน array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target && array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            List<int> result = new List<int>();

            // ไล่เช็คทุกตัวใน array
            for (int i = 0; i < array.Length; i++)
            {
                // ถ้าค่าอยู่ในช่วงที่กำหนด
                if (array[i] >= min && array[i] <= max)
                {
                    // เก็บค่านั้นไว้
                    result.Add(array[i]);
                }
            }

            // เปลี่ยน List กลับเป็น Array
            return result.ToArray();
        }



        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            List<int> targets = new List<int>();

            // ไล่ดู enemy ทีละตัว
            for (int i = 0; i < enemyHPs.Length; i++)
            {
                // ถ้า mana พอ ให้เลือก enemy ตัวนี้
                if (enemyHPs[i] <= mana)
                {
                    // หัก mana ตาม HP ของ enemy
                    mana -= enemyHPs[i];

                    // เก็บค่า HP ของ enemy
                    targets.Add(enemyHPs[i]);
                }
            }

            // เปลี่ยน List กลับเป็น Array
            return targets.ToArray();
        }

        #endregion
    }
}
