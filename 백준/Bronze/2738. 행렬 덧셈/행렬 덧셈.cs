int rows, cols;
int[,] matrix, sumValueMatrix;

int[] size = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  //행렬 생성
rows = size[0]; cols = size[1];
matrix = new int[rows, cols]; sumValueMatrix = new int[rows, cols];
Array.Clear(matrix);


//기본 행렬
for (int i = 0; i < matrix.GetLength(0); i++)	//행 반복
{
    int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //행 값 입력
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = inputArray[j];
}

//더할 행령
for (int i = 0; i < sumValueMatrix.GetLength(0); i++)	//행 반복
{
    int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //행 값 입력
    for (int j = 0; j < sumValueMatrix.GetLength(1); j++)
        sumValueMatrix[i, j] = inputArray[j];
}

//더하기
for (int i = 0; i < matrix.GetLength(0); i++)	//행 반복
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] += sumValueMatrix[i, j];
}

//출력
for (int i = 0; i < matrix.GetLength(0); i++)	//행 반복
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i,j] + " ");

    Console.WriteLine();
}