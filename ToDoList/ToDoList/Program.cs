// See https://aka.ms/new-console-template for more information
Console.WriteLine("___                                                      \r\n |  _ --- _| _     |  o  _ _|_                           \r\n | (_)   (_|(_)    |  | _>  |_                           \r\n          __                         _                   \r\n|_  \\/   |_ __ __  _ __     _  |    | \\    _ |_  _ __  _ \r\n|_) /    |__||||||(_|| ||_|(/_ |    |_/|_|(_ | |(/_| |(/_\n");
List<string> list = new List<string>();
string option = "";



while (option != "4")
{
    if (list != null)
    {
        Console.WriteLine("Current list:\n");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(i + " : " + list[i]);    
        }
    }
    

    Console.WriteLine("\nPlease choose any of the following alternatives:\n");
    Console.WriteLine("Enter 1 to add an item to the list");
    Console.WriteLine("Enter 2 to remove an item from list");
    Console.WriteLine("Enter 3 to edit an item from list");
    Console.WriteLine("Enter 4 to exit the program\n");

    option = Console.ReadLine();
    
    

    if(option == "1")
    {
        Console.WriteLine("Please enter the task to add to the list");
        string task = Console.ReadLine();
        list.Add(task);
        Console.WriteLine("The task has been added to the list\n");
    }

    else if(option == "2")
    {
        for(int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(i + " : " + list[i]);
        }
        Console.WriteLine("Please enter the index number of the task to remove from the list");
        int taskNr = Convert.ToInt32(Console.ReadLine());
        list.RemoveAt(taskNr);
        Console.WriteLine("The task has been removed from the list\n");
    }

    else if(option == "3")
    {
        Console.WriteLine("Please enter the index number of the task you would like to edit");
        int taskNr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the updated task");
        string edit = Console.ReadLine();
        list.Insert(taskNr, edit);
        list.RemoveAt(taskNr + 1);
        Console.WriteLine("The task has been update\n");
    }

    else
        Console.WriteLine("Invalid input, try again\n");
}








