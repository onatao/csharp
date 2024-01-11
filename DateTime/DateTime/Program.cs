Console.WriteLine("Struck DateTime");

DateTime actualDate = DateTime.Now;
Console.WriteLine(actualDate);

// Creating a custom date
DateTime todaysDate = new DateTime(2024, 01, 24);
Console.WriteLine(todaysDate);

// Defining hours
DateTime todaysDateAndTime = new DateTime(2024, 01, 24, 12,30,00);
Console.WriteLine(todaysDateAndTime);

// Obtaining info through actual date
Console.WriteLine(actualDate.Year);
Console.WriteLine(actualDate.Month);
Console.WriteLine(actualDate.Day);
Console.WriteLine(actualDate.Hour);

// Adding values to a date 
Console.WriteLine(actualDate.AddDays(30));
Console.WriteLine(actualDate.AddMonths(2));
Console.WriteLine(actualDate.AddHours(1));
Console.WriteLine(actualDate.AddYears(2));

// Obtaining day of week
Console.WriteLine(actualDate.DayOfWeek);
Console.WriteLine(actualDate.DayOfYear);

// Formating to longer or shorter
Console.WriteLine(actualDate.ToLongDateString());
Console.WriteLine(actualDate.ToShortDateString());

Console.ReadKey();