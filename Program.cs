using System;
using Bhavesh_DSA.Array;
using Bhavesh_DSA.SortAlgorithm;

namespace Bhavesh_DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting.SortArrays();
            ArrayMinMax.MinMaxArray();
            SumOfArrays.SumOfArray();
            ReverseAnArray.ReverseArray();
            StringOperator.OperatorStringArray();
            Traversal.ArrayTraversal();
            SubArray.FindSubArrayAndCount();
            Reverse2DArray.ReverseArray2D();
            MatrixTranspose.TransposeMatrix();
            ClockWise2DArray.RotateClockWise();
            RotateArray180.Array180();
            RotateArray270.Rotate270Array();
            FindMissingNumber.FindMissingNumbers();
            PeakElement.FindPeakElementFromArray();
            CountOccurance.NumOfOccurances();
            RemoveDuplicateElements.ToRemoveDuplicateElements();
            NutsBolts.nutBoltMatch();
            SelectionSort.SortingWithSelection();
            BubbleSort.SortingWithBubble();

            Console.ReadKey();
        }
    }
}
