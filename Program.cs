// CREATE LISTS


var names = new List<string> { "aga", "Ana", "Felipe"};
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


/* Output:
Hello AGA!
Hello ANA!
Hello FELIPE!
*/


// MODIFY LIST CONTENTS


var names = new List<string> { "aga", "Ana", "Felipe"};
foreach (var name in names)

{
    Console.WriteLine($"Hello {name.ToUpper()}!"); 
}
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}


/* Output:
Hello AGA!
Hello ANA!
Hello FELIPE!

Hello AGA!
Hello FELIPE!
Hello MARIA!
Hello BILL!
*/

/*
I added 2 more names to the end of the list. I also removed one name.
The output from this part of code shows the initial contents of the list,
then prints a blank line and the new contents.
*/







var names = new List<string> { "aga", "Ana", "Felipe"};
foreach (var name in names)

{
    Console.WriteLine($"Hello {name.ToUpper()}!"); 
}
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I added {names[2]} and {names[3]} to the list.");

/* Output:
Hello AGA!
Hello ANA!
Hello FELIPE!

Hello AGA!
Hello FELIPE!
Hello MARIA!
Hello BILL!
My name is aga.
I added Maria and Bill to the list.


The List<T> enables me to reference individual items by index as well.
I access items using the [ and ] tokens.
*/



// I am not allowed to access past the end of the list.
// I can check how long the list is by using the Count property:

var names = new List<string> { "aga", "Ana", "Felipe"};
foreach (var name in names)

{
    Console.WriteLine($"Hello {name.ToUpper()}!"); 
}
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I added {names[2]} and {names[3]} to the list.");

Console.WriteLine($"The list has {names.Count} people in it");


/*Output:
Hello AGA!
Hello ANA!
Hello FELIPE!

Hello AGA!
Hello FELIPE!
Hello MARIA!
Hello BILL!
My name is aga.
I added Maria and Bill to the list.
The list has 4 people in it

In C#, indices start at 0, so the largest valid index
is one less than the number of items in the list.
So there are 5 names in the list in reality.



