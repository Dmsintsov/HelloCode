int [,] pic1 = new int [15, 15];


void FillArray(int[,] matr)
{
    var random = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.Next(0, 2);
        }

    }
}

void PrintImage(int[,] image)
{


    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else
            {
                Console.Write($"+");
            }
        }
        Console.WriteLine();
    }
}

void FillImage (int row, int col)
{
    if (pic1[row, col] == 0)
    {
        pic1[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }

}


FillArray (pic1);
PrintImage (pic1);
Console.WriteLine();
FillImage (7,7);
PrintImage (pic1);