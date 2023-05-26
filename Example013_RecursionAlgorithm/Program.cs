// string [,] table = new string [2,5];
// table [1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"-{table [rows, columns]}-");
//     }
// }

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





// void PrintArray(int[,] matr)
// {


//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             Console.Write($"{matr[rows, columns]} ");
//         }
//         Console.WriteLine();
//     }
// }


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


void FillImage(int row, int col)
{
    if (pic1[row, col] == 0)
    {
        pic1[row, col] = 1;
        FillImage[row - 1, col];
        FillImage[row, col - 1];
        FillImage[row + 1, col];
        FillImage[row, col + 1];
    }

}

int[,] pic1 = new int [25, 25];
// PrintImage(pic);
// Console.WriteLine();
FillArray(pic1);
PrintImage(pic);
FillImage(13,13);