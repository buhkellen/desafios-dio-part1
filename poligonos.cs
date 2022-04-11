using System; 

class Problem 
{

    static void Main(string[] args) 
    { 

        string[] v = Console.ReadLine().Split(' ');
        int N = Int32.Parse(v[0]);
        int L = Int32.Parse(v[1]);
        Console.WriteLine(N*L);
        

    }

}
