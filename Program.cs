string[] arr = { "hello", "world", "!", "My", "name", "is", "Alisher!" };

List<string> list = new List<string>();

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        list.Add(arr[i]);
    }
}

string[] result = list.ToArray();

Console.WriteLine("["  + string.Join(", ", result) + "]");