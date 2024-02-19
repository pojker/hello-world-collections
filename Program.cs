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
*/




/* SEARCH AND SORT LISTS

Applications may often create lists with many more elements than just 5 names,
sometimes numbering in the thousands.
To find elements in these larger collections, I need to search the list for different items. 
The IndexOf method searches for an item and returns the index of the item.
If the item isn't in the list, IndexOf returns -1.
*/

var index = names.IndexOf("Felipe");
if (index != -1)
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");


/* Output:
The name Felipe is at index 1
When an item is not found, IndexOf returns -1
*/



/*
The items in my list can be sorted as well.
The Sort method sorts all the items in the list in their normal order (alphabetically for strings).
*/

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

/* Output:
Hello BILL!
Hello FELIPE!
Hello MARIA!
Hello AGA!
*/