
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreatArray(int size)
{
  //создаем новый массив
  int[] massiv = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < massiv.Length; i++)
  {
    massiv[i] = rnd.Next(0, 2);
  }
  return massiv;
}
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write(array[i] + " ");
  }
}


int[] array = CreatArray(8);
PrintArray(array);