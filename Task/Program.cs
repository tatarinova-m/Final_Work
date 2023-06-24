Console.Write("Введите количество элементов массива: ");
int ElementsCount = Convert.ToInt32(Console.ReadLine());
if (ElementsCount <= 0) Console.Write("Число должно быть больше нуля");

string[] myArray = new string[ElementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}: ");
    myArray[i] = Console.ReadLine();
}

int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length < 4) count++;

}

string[] newArray = new string[count];
int j = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length < 4)
    {
        newArray[j] = myArray[i];
        j++;
    }
}

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"{newArray[i]} ");
}
