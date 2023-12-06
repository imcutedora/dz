using MatrixFile;

Matrix m = new Matrix("matrix.txt");
m.Print();
Console.WriteLine("***************");
m.ChangeAllPrimeElements();
m.Print();