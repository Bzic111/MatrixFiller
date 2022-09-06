using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFiller;
/// <summary></summary>
public class Matrix
{
    int counter, leftBorder, rightBorder, upBorder, downBorder, lenghtVertical, lenghtHorizontal;
    int[,] arr;
    private void Init()
    {
        counter = 1;
        leftBorder = rightBorder = upBorder = downBorder = 0;
    }
    /// <summary></summary>
    /// <param name="vertical"></param>
    /// <param name="horizontal"></param>
    public Matrix(int vertical,int horizontal)
    {
        Init();
        lenghtHorizontal = horizontal-1;
        lenghtVertical = vertical-1;
        arr = new int[horizontal,vertical];
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

    private void WriteArrayUpLineLR()
    {
        for (int i = 0 + rightBorder; i <= lenghtHorizontal - leftBorder; i++)
            arr[upBorder, i] = counter++;
        upBorder++;
    }
    private void WriteArrayUpLineRL()
    {
        for (int i = lenghtHorizontal - leftBorder; i >= 0 + rightBorder; i--)
            arr[upBorder, i] = counter++;
        upBorder++;
    }
    private void WriteArrayRightLineUD()
    {
        for (int i = 0 + upBorder; i <= lenghtVertical - downBorder; i++)
            arr[i, lenghtHorizontal - leftBorder] = counter++;
        leftBorder++;
    }
    private void WriteArrayRightLineDU()
    {
        for (int i = lenghtVertical - downBorder; i >= 0 + upBorder; i--)
            arr[i,lenghtHorizontal - leftBorder] = counter++;
        leftBorder++;
    }
    private void WriteArrayLeftLineDU()
    {
        for (int i = lenghtVertical - downBorder; i >= 0 + upBorder; i--)
            arr[i, rightBorder] = counter++;
        rightBorder++;
    }
    private void WriteArrayLeftLineUD()
    {
        for (int i = 0 + upBorder; i <= lenghtVertical - downBorder; i++)
            arr[i, rightBorder] = counter++;
        rightBorder++;
    }
    private void WriteArrayDownLineRL()
    {
        for (int i = lenghtHorizontal - leftBorder; i >= 0 + rightBorder; i--)
            arr[lenghtVertical - downBorder, i] = counter++;
        downBorder++;
    }
    private void WriteArrayDownLineLR()
    {
        for (int i = 0 + rightBorder; i <= lenghtHorizontal - leftBorder; i++)
            arr[lenghtVertical - downBorder, i] = counter++;
        downBorder++;
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
    
    
    public void FillMatrixFromLeftDownCornerToRight()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayDownLineLR();
            WriteArrayRightLineDU();
            WriteArrayUpLineRL();
            WriteArrayLeftLineUD();
        }
    }
    public void FillMatrixFromRightDownCornerToUp()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayRightLineDU();
            WriteArrayUpLineRL();
            WriteArrayLeftLineUD();
            WriteArrayDownLineLR();
        }
    }
    public void FillMatrixFromRightUpCornerToLeft()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayUpLineRL();
            WriteArrayLeftLineUD();
            WriteArrayDownLineLR();
            WriteArrayRightLineDU();
        }
    }
    public void FillMatrixFromLeftUpCornerToDown()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayLeftLineUD();
            WriteArrayDownLineLR();
            WriteArrayRightLineDU();
            WriteArrayUpLineRL();
        }
    }

    public void FillMatrixFromLeftUpCornerToRight()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayUpLineLR();
            WriteArrayRightLineUD();
            WriteArrayDownLineRL();
            WriteArrayLeftLineDU();
        }
    }
    public void FillMatrixFromRightUpCornerToDown()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayRightLineUD();
            WriteArrayDownLineRL();
            WriteArrayLeftLineDU();
            WriteArrayUpLineLR();
        }
    }
    public void FillMatrixFromRightDownCornerToLeft()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayDownLineRL();
            WriteArrayLeftLineDU();
            WriteArrayUpLineLR();
            WriteArrayRightLineUD();
        }
    }
    public void FillMatrixFromLeftDownCornerToUp()
    {
        while (counter <= arr.GetLength(0) * arr.GetLength(1))
        {
            WriteArrayLeftLineDU();
            WriteArrayUpLineLR();
            WriteArrayRightLineUD();
            WriteArrayDownLineRL();
        }
    }
    
}
