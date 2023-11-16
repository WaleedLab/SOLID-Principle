using DIP.v2;
//using DIP.v3;

DVD dvd1 = new DVD { Price = 2.00M, Name = "Knockin’ on Heaven’s Door" };
DVD dvd2 = new DVD { Price = 1.99M, Name = "Barfuß auf Nacktschnecken" };
DVD dvd3 = new DVD { Price = 2.99M, Name = "Good Bye Lenin!" };

Book book1 = new Book(5.00M) { Name = "Der Prozess" };
Book book2 = new Book(4.99M) { Name = "Im Westen nichts Neues" };
Book book3 = new Book(10.00M) { Name = "Die unerträgliche Leichtigkeit des Seins" };

Shelf shelf = new Shelf();

shelf.AddProduct(dvd1);
shelf.AddProduct(book1);
shelf.AddProduct(dvd2);
shelf.AddProduct(book2);
shelf.AddProduct(dvd3);
shelf.AddProduct(book3);

Console.WriteLine("\nTotal products price is " + shelf.GetTotalPrice());
