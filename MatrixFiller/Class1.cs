using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFiller;

public class Matrix
{
    int counter, leftBorder, rightBorder, upBorder, downBorder, lenghtVertical, lenghtHorizontal;
    int[,] arr;
    private void Init()
    {
        counter = 1;
        leftBorder = rightBorder = upBorder = downBorder = 0;
    }
    public Matrix()
    {
        Init();
    }
    public void Selecting()
    {
        var key = Console.ReadKey(false);
        switch (key.Key)
        {

            case ConsoleKey.UpArrow:
                break;
            case ConsoleKey.DownArrow:
                break;
            case ConsoleKey.Enter:
                break;
            case ConsoleKey.Escape:
                break;
            default:
                break;
        }
    }
    private void WriteArrayDU()
    {
        for (int i = lenghtVertical - downBorder; i >= 0 + upBorder; i--)
            arr[i, rightBorder] = counter++;
        rightBorder++;
    }
    private void WriteArrayRL()
    {
        for (int i = lenghtHorizontal - leftBorder; i >= 0 + rightBorder; i--)
            arr[lenghtVertical - downBorder, i] = counter++;
        downBorder++;
    }
    private void WriteArrayUD()
    {
        for (int i = 0 + upBorder; i <= lenghtVertical - downBorder; i++)
            arr[i, lenghtHorizontal - leftBorder] = counter++;
        leftBorder++;
    }
    private void WriteArrayLR()
    {
        for (int i = 0 + rightBorder; i <= lenghtHorizontal - leftBorder; i++)
            arr[upBorder, i] = counter++;
        upBorder++;
    }
    public void ArrayToConsole()
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write($"{arr[i, j]}\t");
            Console.WriteLine();
        }
    }
    public void FillMatrixRightDown()
    {
        while (counter < lenghtVertical * lenghtHorizontal)
        {
            WriteArrayLR();
            WriteArrayUD();
            WriteArrayRL();
            WriteArrayDU();
        }
    }
}
