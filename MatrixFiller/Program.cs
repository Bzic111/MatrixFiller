Console.WriteLine("Input Height");
int height = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input Width");
int width = int.Parse(Console.ReadLine()!);

int counter = 1;
int leftBorder, rightBorder, upBorder, downBorder, vertical, horizontal;
leftBorder = rightBorder = upBorder = downBorder = 0;
int[,] arr = new int[height, width];
vertical = arr.GetLength(0) - 1;
horizontal = arr.GetLength(1) - 1;

FillMatrixRightDown(height, width, ref counter, ref leftBorder, ref rightBorder, ref upBorder, ref downBorder, vertical, horizontal, arr);

ArrayToConsole(arr);

static void WriteArrayDU(ref int counter,
                         ref int rightBorder,
                         int upBorder,
                         int downBorder,
                         int lenghtVertical,
                         int[,] arr)
{
    for (int i = lenghtVertical - downBorder; i >= 0 + upBorder; i--)
        arr[i, rightBorder] = counter++;
    rightBorder++;
}

static void WriteArrayRL(ref int counter,
                         int leftBorder,
                         int rightBorder,
                         ref int downBorder,
                         int lenghtVertical,
                         int lenghtHorizontal,
                         int[,] arr)
{
    for (int i = lenghtHorizontal - leftBorder; i >= 0 + rightBorder; i--)
        arr[lenghtVertical - downBorder, i] = counter++;
    downBorder++;
}

static void WriteArrayUD(ref int counter,
                         ref int leftBorder,
                         int upBorder,
                         int downBorder,
                         int lenghtVertical,
                         int lenghtHorizontal,
                         int[,] arr)
{
    for (int i = 0 + upBorder; i <= lenghtVertical - downBorder; i++)
        arr[i, lenghtHorizontal - leftBorder] = counter++;
    leftBorder++;
}

static void WriteArrayLR(ref int counter,
                         int leftBorder,
                         int rightBorder,
                         ref int upBorder,
                         int lenghtHorizontal,
                         int[,] arr)
{
    for (int i = 0 + rightBorder; i <= lenghtHorizontal - leftBorder; i++)
        arr[upBorder, i] = counter++;
    upBorder++;
}

static void ArrayToConsole(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
}

static void FillMatrixRightDown(int height,
                                int width,
                                ref int counter,
                                ref int leftBorder,
                                ref int rightBorder,
                                ref int upBorder,
                                ref int downBorder,
                                int vertical,
                                int horizontal,
                                int[,] arr)
{
    while (counter < height * width)
    {
        WriteArrayLR(ref counter, leftBorder, rightBorder, ref upBorder, horizontal, arr);
        WriteArrayUD(ref counter, ref leftBorder, upBorder, downBorder, vertical, horizontal, arr);
        WriteArrayRL(ref counter, leftBorder, rightBorder, ref downBorder, vertical, horizontal, arr);
        WriteArrayDU(ref counter, ref rightBorder, upBorder, downBorder, vertical, arr);
    }
}