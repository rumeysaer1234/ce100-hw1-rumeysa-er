using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_lib_cs;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionSort_Test1()
        {
            int[] array = { 2, 10, 8, 25, 19 };
            Class1.InsertionSort(array);
            int[] result = { 2, 8, 10, 19, 25 };
            CollectionAssert.AreEqual(array, result);

        }

        [TestMethod]
        public void InsertionSort_Test2()
        {
            int[] array = { 9, 17, 28, 5, 21, 35 };
            Class1.InsertionSort(array);
            int[] result = { 5, 9, 17, 21, 28, 35 };
            CollectionAssert.AreEqual(array, result);

        }
        [TestMethod]
        public void InsertionSort_Test3()
        {
            int[] array = { 51, 46, 11, 77, 36, 3, 6 };
            Class1.InsertionSort(array);
            int[] result = { 3, 6, 11, 36, 46, 51, 77 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void SelectionSort_Test1()
        {
            int[] array = { 7, 8, 1, 2, 85, 63 };
            Class1.SelectionSort(array);
            int[] result = { 1, 2, 7, 8, 63, 85 };
            CollectionAssert.AreEqual(array, result);

        }
        [TestMethod]
        public void SelectionSort_Test2()
        {
            int[] array = { 98, 78, 45, 6, 3, 14, 74 };
            Class1.SelectionSort(array);
            int[] result = { 3, 6, 14, 45, 74, 78, 98 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void SelectionSort_Test3()
        {
            int[] array = { 56, 45, 85, 3, 7, 1, 4 };
            Class1.SelectionSort(array);
            int[] result = { 1, 3, 4, 7, 45, 56, 85 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RecursiveMergeSort_Test1()
        {
            int[] array = { 1, 44, 98, 6, 7, 5 };
            Class1.RecursiveMergeSort(array, 0, array.Length - 1);
            int[] result = { 1, 5, 6, 7, 44, 98 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RecursiveMergeSort_Test2()
        {
            int[] array = { 6, 8, 18, 14, 3, 11 };
            Class1.RecursiveMergeSort(array, 0, array.Length - 1);
            int[] result = { 3, 6, 8, 11, 14, 18 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RecursiveMergeSort_Test3()
        {
            int[] array = { 64, 46, 34, 43, 2, 8 };
            Class1.RecursiveMergeSort(array, 0, array.Length - 1);
            int[] result = { 2, 8, 34, 43, 46, 64 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void RecursivePower_Test1()
        {
            Assert.AreEqual(Class1.RecursivePower(3, 2), 9);

        }
        [TestMethod]
        public void RecursivePower_Test2()
        {
            Assert.AreEqual(Class1.RecursivePower(7234, 0), 1);

        }
        [TestMethod]
        public void RecursivePower_Test3()
        {
            Assert.AreEqual(Class1.RecursivePower(4, 3), 64);

        }

        [TestMethod]
        public void NaivePower_Test1()
        {
            Assert.AreEqual(Class1.Naive_Power(2, 7), 128);
        }

        [TestMethod]
        public void NaivePower_Test2()
        {
            Assert.AreEqual(Class1.Naive_Power(25, 2), 625);
        }

        [TestMethod]
        public void NaivePower_Test3()
        {
            Assert.AreEqual(Class1.Naive_Power(12342, 0), 1);
        }

        [TestMethod]
        public void RecursiveBinarySearch_Test1()
        {
            int[] array = { 5, 12, 16, 19, 26, 45, 61 };
            int n = array.Length;
            int a = 19;
            Assert.AreEqual(Class1.RecursiveBinarySearch(array, 0, n - 1, a), 3);
        }

        [TestMethod]
        public void RecursiveBinarySearch_Test2()
        {
            int[] array = { 24, 43, 58, 74, 104, 127, 145, 168, 201 };
            int n = array.Length;
            int a = 145;
            Assert.AreEqual(Class1.RecursiveBinarySearch(array, 0, n - 1, a), 6);
        }

        [TestMethod]
        public void RecursiveBinarySearch_Test3()
        {
            int[] array = { 1, 9, 16, 25, 36, 49, 82, 100 };
            int n = array.Length;
            int a = 16;
            Assert.AreEqual(Class1.RecursiveBinarySearch(array, 0, n - 1, a), 2);
        }

        [TestMethod]
        public void IterativeBinarySearch_Test1()
        {
            int[] array = { 24, 43, 65, 78, 132, 156 };
            int a = 132;
            Assert.AreEqual(Class1.IterativeBinarySearch(array, a), 4);
        }

        [TestMethod]
        public void IterativeBinarySearch_Test2()
        {
            int[] array = { 13, 18, 34, 52, 67, 92, 145, 247, 278 };
            int a = 13;
            Assert.AreEqual(Class1.IterativeBinarySearch(array, a), 0);
        }

        [TestMethod]
        public void IterativeBinarySearch_Test3()
        {
            int[] array = { 25, 43, 60, 124, 245, 274, 311, 346, 451 };
            int a = 451;
            Assert.AreEqual(Class1.IterativeBinarySearch(array, a), 8);
        }

        [TestMethod]
        public void MasterMethod_Test1()
        {
            Assert.AreEqual(Class1.MasterMethod(8, 64, "n^2"), "T(n) = n^2");
        }

        [TestMethod]
        public void MasterMethod_Test2()
        {
            Assert.AreEqual(Class1.MasterMethod(4, 64, "n^3"), "T(n) = n^3");
        }

        [TestMethod]
        public void MasterMethod_Test3()
        {
            Assert.AreEqual(Class1.MasterMethod(7, 7, "n^1"), "T(n) = n^1logn");
        }
    }
}
        

    