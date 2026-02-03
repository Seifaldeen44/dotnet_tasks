// See https://aka.ms/new-console-template for more information
int[] arrayRotation(int[] arr, int k)
{
    int n = arr.Length;
    if (n == 0)
        return arr;

    int[] result = new int[n];
    int j = 0;

    for (int i = n - k; i < n; i++)
    {
        result[j++] = arr[i];
    }

    for (int i = 0; i < n - k; i++)
    {
        result[j++] = arr[i];
    }

    return result;
}

int [] arr = {1,2,3,4,5};
System.Console.WriteLine("hello world");
int [] res = arrayRotation(arr , 2);
for( int i = 0 ; i < res.Length; i++)
    {
        System.Console.Write(res[i]);
    }

/////////////////////////////////////////////////////

static int[][] Pascal_triangle(int n)
{
    int[][] res = new int[n][];

    for (int i = 0; i < n; i++)
    {
        res[i] = new int[i + 1];
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
                res[i][j] = 1;
            else
                res[i][j] = res[i - 1][j - 1] + res[i - 1][j];
        }
    }
    return res;
}

static void PrintTriangle(int[][] triangle)
{
    for (int i = 0; i < triangle.Length; i++)
    {
        for (int j = 0; j < triangle[i].Length; j++)
            Console.Write(triangle[i][j] + " ");
        Console.WriteLine();
    }
}

int n = 5;

        int[][] triangle = Pascal_triangle(n);

        Console.WriteLine("Pascal Triangle:");
        PrintTriangle(triangle);

        Console.ReadLine();

///////////////////////////////////////////////////////////

// int [] BubbleSort(int [] arr)
// {
//     Boolean Notsorted = true;
//     int temp;
//     while (Notsorted)
//     {
//         Notsorted = false;
//         for(int i = 0 ; i < arr.Length-1 ; i++)
//         {
//             if(arr[i] > arr[i + 1])
//             {
//                 temp = arr[i];
//                 arr[i] = arr[i+1];
//                 arr[i+1] = temp;
//                 Notsorted = true;
//             }
//         }
//     }
//     return arr;
// }

//     int[] arr = { 5, 3, 8, 1, 2 };

//     int[] sortedArr = BubbleSort(arr);

//     for (int i = 0; i < sortedArr.Length; i++)
//     {
//         Console.Write(sortedArr[i] + " ");
//     }

///////////////////////////////////////////////////////

// int[] SelectionSort(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         int min = arr[i];
//         int location = i;

//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[j] < min)
//             {
//                 min = arr[j];
//                 location = j;
//             }
//         }

//         int temp = arr[i];
//         arr[i] = arr[location];
//         arr[location] = temp;
//     }

//     return arr;
// }

//     int[] arr = { 5, 3, 8, 1, 2 };

//     int[] sortedArr = SelectionSort(arr);

//     for (int i = 0; i < sortedArr.Length; i++)
//     {
//         Console.Write(sortedArr[i] + " ");
//     }

//////////////////////////////////

// BankAccount b1 = new BankAccount(123,20000,"ahmed");
// BankAccount b2 = new BankAccount(133,20000,"sefo");


// b1.displayInfo();
// b2.displayInfo();
// b1.transfere(b2,200);
// b1.displayInfo();
// b2.displayInfo();


// class BankAccount
// {
//     int accountNumber;
//     float Balance;
//     String ownerName;

//     public BankAccount(int a ,float b ,String o){
//         accountNumber = a;
//         Balance = b;
//         ownerName = o;
//     }
//     public void deposit(float value)
//     {
//         this.Balance = this.Balance + value;
//     }
//     public void withDraw(float value)
//     {
//         this.Balance = this.Balance - value;
//     }

//     public void transfere(BankAccount b , float value){
//         if (b == null || value> Balance || value<0)
//         {
//             return;
//         }
//         else
//         {
//             this.Balance -= value;
//             b.Balance += value;
//             System.Console.WriteLine("transfered succefully");
//         }
//     }

//     public float GetBalance()
//     {
//         return this.Balance;
//     }

//     public void displayInfo()
//     {
//         System.Console.WriteLine($"the bank account is {this.accountNumber}, the value is {this.Balance} and the owner is {this.ownerName}");
//     }

// }

/////////////////////////////////

public static class ArrayUtills
{
    public static int [] Reverse(int [] arr)
    {
        int p1;
        int p2;
        int temp;
        for(p1 = 0, p2 = arr.Length -1 ; p1<arr.Length /2 ; p1++, p2--)
        {
            temp = arr[p1];
            arr[p1] = arr[p2];
            arr[p2] = temp;
        }
        return arr;
    }

    public static int max_val(int [] arr)
    {
        int max = arr[0];

        for(int i = 0 ; i < arr.Length; i++)
        {
            if(max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }

    public static int min_val(int [] arr)
    {
        int min = arr[0];

        for(int i = 0 ; i < arr.Length; i++)
        {
            if(min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }

    public static Boolean IsSorted(int [] arr)
    {
        for(int i = 0 ; i < arr.Length-1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }


    public static int countOccurance(int [] arr,int value)
    {
        int counter = 0;
        for(int i = 0 ; i < arr.Length; i++)
        {
            if(arr[i] == value)
            {
                counter++;
            }
        }
        return counter;
    }

    public static int[] mergeTwoArrays(int[] arr1, int[] arr2)
    {
        int p1 = 0, p2 = 0;
        int[] res = new int[arr1.Length + arr2.Length];
        int i = 0;

        while (p1 < arr1.Length && p2 < arr2.Length)
        {
            if (arr1[p1] <= arr2[p2])
            {
                res[i++] = arr1[p1++];
            }
            else
            {
                res[i++] = arr2[p2++];
            }
        }

        while (p1 < arr1.Length)
        {
            res[i++] = arr1[p1++];
        }

        while (p2 < arr2.Length)
        {
            res[i++] = arr2[p2++];
        }

        return res;
    }
}

/////////////////////////////////////////////////////


// string input = "The cat and the dog and the bird";

//         input = input.ToLower();

//         string[] words = input.Split(' ');

//         Dictionary<string, int> freq = new Dictionary<string, int>();

//         foreach (string word in words)
//         {
//             if (freq.ContainsKey(word))
//             {
//                 freq[word] = freq[word] + 1;
//             }
//             else
//             {
//                 freq.Add(word, 1);
//             }
//         }

//         List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>(freq);

//         list.Sort((a, b) =>
//         {
//             int compare = b.Value.CompareTo(a.Value);
//             if (compare == 0)
//                 return a.Key.CompareTo(b.Key);
//             return compare;
//         });

//         foreach (var item in list)
//         {
//             string output = string.Concat(item.Key, " - ", item.Value);
//             Console.WriteLine(output);
//         }
    