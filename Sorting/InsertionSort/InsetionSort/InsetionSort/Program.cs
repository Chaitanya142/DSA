//https://youtu.be/OGzPmgsI-pQ
//See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the size of array:");
var p = get_array(out int N);
input_array(p, N);
Console.WriteLine("Output Array Before Sort");
output_array(p, N);
sort_array(p, N);
Console.WriteLine("Output Array After Sort");
output_array(p, N);


List<int> get_array(out int sizeOfArray)
{
    int.TryParse(Console.ReadLine(), out sizeOfArray);
    return new List<int>();
}

void input_array(List<int> list, int N)
{
    var random = new Random();
    for (int i = 0; i < N; i++)
    {
        list.Add(random.Next());
    }
}

void sort_array(List<int> list, int N)
{
    int i;
    //SortedArray-UnsortedArray
    for (i = 1; i < N; i++)
        insert_at_sorting_pos(list, i);
}

void output_array(List<int> list, int N)
{
    int i;
    for (i = 0; i < N; ++i)
        Console.WriteLine($"p[{i}]:{list[i]}\n");
}

void insert_at_sorting_pos(List<int> list, int N)
{
    int key, i;
    key = list[N];
    //Start compare from previous element of array
    //Start comparing from R to L as L is already sorted
    for (i = N - 1; i > -1 && p[i] > key; --i)
    {
        //Shift element to right as it is greater than currently selected element
        p[i + 1] = p[i];
    }
    //Copy element to next i
    p[i + 1] = key;
}