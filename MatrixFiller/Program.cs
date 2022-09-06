using MatrixFiller;


Console.WriteLine("Input Height");
int height = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input Width");
int width = int.Parse(Console.ReadLine()!);

Matrix matrix = new(height, width);

matrix.FillMatrixFromLeftUpCornerToRight();

matrix.ArrayToConsole();

Matrix[] mxs = new Matrix[8];
for (int i = 0; i < mxs.Length; i++)
{
    mxs[i] = new Matrix(4, 4);
}
mxs[0].FillMatrixFromRightDownCornerToUp();
mxs[1].FillMatrixFromRightUpCornerToLeft();
mxs[2].FillMatrixFromLeftUpCornerToDown();
mxs[3].FillMatrixFromLeftDownCornerToRight();

mxs[4].FillMatrixFromLeftDownCornerToUp();
mxs[5].FillMatrixFromLeftUpCornerToRight();
mxs[6].FillMatrixFromRightUpCornerToDown();
mxs[7].FillMatrixFromRightDownCornerToLeft();

foreach (var item in mxs)
{
    item.ArrayToConsole();
    Console.WriteLine();
}