

//1. For loop
//2. if check

int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };


bool LinearSearch(int[] array, int key)
{
    for(int i=0; i<array.Length; i++)
    {
        if (array[i] == key)
            return true;
    }
    return false;
}

Console.WriteLine("Element found in Linear Search: ", LinearSearch(array, 5));