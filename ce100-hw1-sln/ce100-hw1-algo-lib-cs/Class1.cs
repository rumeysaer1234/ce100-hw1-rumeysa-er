using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{
    public class Class1
    {
        /**
       * 
       * @name InsertionSort
       * 
       * @param [in] arr [\b int[]]
       * 
       * Insertion Sort is a sorting algorithm used in computer science 
       * that creates the sorted array item by item at each step. 
       * The Insertion Sort Algorithm is based on the principle
       * of handling irregular array elements one by one and
       * placing each one in its proper place in the sorted part of the array.
       * 
       * **/
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        /**
          * 
          * @name SelectionSort
          * 
          * @param [in] arr [\b int[]]
          * 
          * We have created an int array with a certain number of elements.
          We created a variable called temp=0.
          In two nested for loops, the first for loops starting from 0.
          index to the last index, the second for starting from i.
          index and returning to the last index. This is because as i increases in the first fore,
          there is no need to look again at the ones to the left of i, so we start the second fore from i.inex.
          Using the if control block, we compare the element in the array index in the first for
          and the element in the array index in the second for. If the element in the first
          fore is smaller than the element in the second fore, it enters the if block.
          We assign the second element in the foreground to the variable we have created called temp.
          We equate the element on the first fore to the element on the second fore. Finally, 
          we make the first element in the fore, the value in the temp variable. The purpose 
          of this operation is to replace the array element in the first fore with the array
          element in the second fore. But when we equate the two to each other, the value we
          equated disappears because it is not kept in one place. To avoid this, we keep this 
          value in a variable called temp.
          When the 2 nested for loops complete their rotation, our array will be sorted from smallest 
          to largest.
          With the foreach loop, we navigate the array variable and print it on the screen. In this way,
          it will print -9, -6, 1, 2, 3, 8 on the screen.
          * 
          * 
          * **/
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        /**
        * 
        * @name merge
        * 
        * @param [in] numbers [\b int[]]
        * @param [in] left [\b int []]
        * @param [in] mid [\b int []]
        * @param [in] right [\b int []]
        *Merge Sort is a recursive algorithm that sequentially
        *halves the array down to its smallest subsequences, 
        *then sorts them and merges them. The halving process 
        *continues until the largest subarray has at most two 
        *elements. Then, with the "Merge" operation, the subarrays are 
        *merged into a parent array sequentially,
        *in the order of dividing by twos. At the end of the process, the top row is reached.
        * **/
        public static void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        /**
       * 
       * @name RecursiveMergeSort
       * 
       * @param [in] arr [\b int[]]
       * retval [\b int []]
       * The algorithm is based on continuous bisection of the array.
       * When the last two elements remain,
       * it sorts between those two and returns them in order.
       * Then it sorts through the 4 elements and returns them.
       * Then it goes as 8 16 32. It is a simple algorithm. 
       * When we look at the working speed, it is T(n)=O(n lg n).
       * Bubble and Select works faster than sorting.
       * **/
        public static void RecursiveMergeSort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                RecursiveMergeSort(numbers, left, mid);
                RecursiveMergeSort(numbers, (mid + 1), right);
                Merge(numbers, left, (mid + 1), right);
            }
        }
        /**
     * 
     * @name RecursivePower
     * 
     * @param [in] arr [\b int[]]
     * retval [\b long ] 
     * A stack of calls to the function is created. This process continues
     * until it meets a termination condition/"base case" - here, a returned value.
     * At that point, all the functions can return and the original function call returns the answer. 
     * Explained in other terms, the returned values are popped
     * out of the stack and used to calculate the next step (in inverse order) and so forth until the stack is empty.
     * **/

        public static int RecursivePower(int n, int powerRaised)
        {
            if (powerRaised != 0)
                return (n * RecursivePower(n, powerRaised - 1));
            else
                return 1;
        }
        /**
       * 
       * @name NaivePower
       * 
       * @param [in] arr [\b int[]]
       * retval [\b int []] 
       * The most basic way to calculate the nth power of a number is to multiply that number exactly n-times.
       * In this case, we could just find the inverse of its positive power i.e. pow(2,-3) = 1/(2^3).
       * **/
        public static long Naive_Power(int a, int p)
        {
            long pow = 1L;
            for (int i = 1; i <= p; i++)
            {
                pow = pow * a;
            }
            return pow;
        }

      
        /**
        * 
        * @name RecursiveBinarySearch
        * 
        * @param [in] arr [\b int[]]
        * retval [\b int []] 
        * Binary search is a recursive algorithm. The high level approach 
        * is that we examine the middle element of the list.
        * The value of the middle element determines whether to terminate 
        * the algorithm (found the key), 
        * recursively search the left half of the list, or recursively search the right half of the list.
        * **/
        public static int RecursiveBinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

               
                if (arr[mid] == x)
                    return mid;

                
                if (arr[mid] > x)
                    return RecursiveBinarySearch(arr, l, mid - 1, x);

                
                return RecursiveBinarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }
        /**
         * 
         * @name IterativeBinarySearch
         * 
         * @param [in] arr [\b int[]]
         * retval [\b int []] 
         * In the case of Iterative algorithms, a certain set of statements
         * are repeated a certain number of time.An Iterative algorithm will 
         * use looping statements such as for loop,
         * while loop or do-while loop to repeat the same steps number of time.
         * **/
        public static int IterativeBinarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                
                if (arr[m] == x)
                    return m;
               
                if (arr[m] < x)
                    l = m + 1;
               
                else
                    r = m - 1;
            }
            return -1;
        }

        /**
        * 
        * @name MasterMethod
        * 
        * @param [in] x [\b int]
        * @param [in] y [\b int]
        * @param [in] f [\b string]   
        * The master method is a formula for solving recurrence
        * relations of the form: T(n) = aT(n/b) + f(n), where,
        * n = size of input a = number of subproblems in the recursion n/b = size of each subproblem.
        * All subproblems are assumed to have the same size.
        **/
        public static string MasterMethod(int x, int y, string f)
        {
            double e = Math.Log(Convert.ToDouble(x), Convert.ToDouble(y));
            double a;
            try
            {
                a = Convert.ToDouble(f.Replace("n^", ""));

            }
            catch (Exception)
            {
                a = 1;
            }

            if (x >= 1)
            {
                if (e > a)
                {
                    return "T(n) = n^" + e;
                }
                else if (e == a)
                {
                    return "T(n) = n^" + e + "logn";
                }
                else if (e < a)
                {
                    return "T(n) = n^" + a;
                }
            }
            return "Incalculable!";
        }
    }
}
    

