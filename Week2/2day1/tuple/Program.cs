


int a = 3;
string b = "baba";

(int c, string d) tuple = tupleMethod(a,b);  

Console.WriteLine(tuple);
Console.WriteLine(tuple.Item1 = $"({tuple.Item1}, tuple.Item2 = {tuple.Item2})");


static (int a, string b) tupleMethod(int a, string b)

{
	return (a,b);
}