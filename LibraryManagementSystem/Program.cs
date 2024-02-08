//Problem 1 and Problem 2
// //Creating book1 using the default constructor
// Book book1 = new Book();
// //Invoke toString method
// Console.WriteLine(book1.ToString());
// Console.WriteLine();

// //Create book2 using parameterized constructor
// Book book2 = new Book("Hamlet", "Williamn Shakespeare", 289);
// Console.WriteLine("Book 2");
// Console.WriteLine($"Title: {book2.title}\nAuthor:{book2.author}\nPages: {book2.pages}");

// // Create book3 with page 1
// Book book3 = new Book("Random Book", "Random Author", 1);

// //Invoke readpage method for book1, book2 and book3
// Console.WriteLine("\nAttempting to Read Book 1:");
// Console.WriteLine(book1.ReadPage());
// Console.WriteLine();


// Console.WriteLine("\nAttempting to Read Book 2:");
// Console.WriteLine(book2.ReadPage());
// Console.WriteLine();

// //Read book3 two times
// Console.WriteLine("\nAttempting to Read Book 3:");
// Console.WriteLine(book3.ReadPage());
// Console.WriteLine();

// Console.WriteLine("Attempting to Read Book 3 again:");
// Console.WriteLine(book3.ReadPage());


// Problem3

Book book1 = new();
Book book2 = new("Hamlet", "William Shakespeare", 289);
Book book3 = new("Some Book", "Some Author", 1);

//Attempt to Read Book 1 (read one page)
Console.WriteLine(book1.ReadPage());
Console.WriteLine();

//Attempting to Read Book 2 (read one page)
Console.WriteLine(book2.ReadPage());
Console.WriteLine();

//Attempting to Read Book 2 (read -1 page)
Console.WriteLine(book2.ReadPage(-1));
Console.WriteLine();

//Attempting to Read Book 2 (read 8 page)
Console.WriteLine(book2.ReadPage(8));
Console.WriteLine();

// Attempting to Read 289 pages of Book 2
Console.WriteLine(book2.ReadPage(289));
Console.WriteLine();

// Attempting to read 280 pages of Book 2
Console.WriteLine(book2.ReadPage(280));
Console.WriteLine();

// Attempting to Read 1 page of Book 3
Console.WriteLine(book3.ReadPage(1));
Console.WriteLine();

