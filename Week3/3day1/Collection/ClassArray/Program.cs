using ClassArray;

fruits fruits1 = new("jeruk");
fruits fruits2 = new("apel");
fruits fruits3 = new("pisang");

fruits[] fruitsStock = {fruits1, fruits2, fruits3};

public fruits output;
foreach (var i in fruitsStock)
{
	output = i;
	Console.WriteLine(output);
}

