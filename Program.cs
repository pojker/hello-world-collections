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

