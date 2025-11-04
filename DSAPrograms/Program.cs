// See https://aka.ms/new-console-template for more information
//Arrays

//Array Insertions & Deletions

//int[] intArray = new int[8];
//int length = 0;

//Inserting at the End of the Array

//for (int i = 0; i < 8; i++)
//{
//    intArray[length] = i + 1;
//    length++;
//}

//intArray[length] = 8;
//length++;


//Inserting at the start of the Array

//for (int i = 3; i > 0; i--)
//{
//    intArray[i + 1] = intArray[i];
//}
//intArray[0] = 20;
//int value = 0;

//Inserting at the anywhere of the Array
//for (int i=4; i>=2; i--)
//{
//    intArray[i + 1] = intArray[i];

//}
//intArray[2] = 8;
//int value = 10;



int[] intArray = new int[9];
int length = 0;

//for(int i=0; i< 6; i++)
//{
//    intArray[length] = i;
//    length++;
//}
////length--;

//for(int i=1; i<length; i++)
//{
//    intArray[i - 1] = intArray[i];
//}
//length--;

//for(int i=0; i< length; i++)
//{
//    Console.WriteLine(intArray[i]);
//}

//Deleting anywhere
for (int i = 0; i < 6; i++)
{
    intArray[length] = i;
    length++;
}
for(int i=3; i<length; i++)
{
    intArray[i - 1] = intArray[i];
}
length--;
for (int i = 0; i < length; i++)
{
    Console.WriteLine(intArray[i]);
}