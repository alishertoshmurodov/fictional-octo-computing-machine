string[] InputByUser(){
    Console.WriteLine("Number of elements in your array:");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[n];

    int c = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Element number {0}", c);
        array[i] = Console.ReadLine();
        c++;
    }
    return array;
}


string[] byuser = InputByUser();

List<string> list = new List<string>();

for (int i = 0; i < byuser.Length; i++)
{
    if (byuser[i].Length <= 3)
    {
        list.Add(byuser[i]);
    }
}

string[] result = list.ToArray();

Console.WriteLine("["  + string.Join(", ", result) + "]");