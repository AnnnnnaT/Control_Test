

string [] AdditArray (string [] array)
{
    int indexes = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            indexes += i;
        }
    }

    string[] newArray = new string[indexes];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

void ShowStringArray (string [] arr)
{   
    Console.Write("{");
    for (int i = 0; i < arr.Length; i++)
    {            
        Console.Write(arr[i] + "  ");
    }
     Console.Write("}\n");  
}

string [] CreateStringArray (int n)
{
    string [] newArray = new string [n];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine("Input string: ");
        string? value = Console.ReadLine();
        while(value == String.Empty)
        {
            Console.Write("Input string: ");
            value = Console.ReadLine();
        }
        if(value != null) 
        newArray[i] = value;
    }
    return newArray;
}

Console.WriteLine("Input number of elements in String Array: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] myArray = CreateStringArray(n);

Console.WriteLine();
ShowStringArray(myArray);
string [] newArray = AdditArray(myArray);

Console.WriteLine();
ShowStringArray(newArray);
