using biblioteka3000;
{
    Book wiedzmin = new Book( "Wiedźmin", "Andrzej Sapkowski", 1990, 320, "Fantasy" ); 
    Movie matrix = new Movie( "Matrix", "Wachowscy", 1999, 136, "Sci-Fi" );

    Console.WriteLine(wiedzmin.ShowInfo());
    Console.WriteLine(matrix.ShowInfo());
}
