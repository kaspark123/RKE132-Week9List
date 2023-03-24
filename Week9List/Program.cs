using System;
using System.IO;
string filePath = @"/Users/projects";
string fileName = @"/Users/projects/shoppingList.txt";
List<string> myShoppingList = new List<string>();

if (File.Exists(fileName))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(fileName).Close();
    Console.WriteLine($"File {fileName} does not exist.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List<string> GetItemsFromUser()
{
    List<string> myShoppingLists = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            myShoppingLists.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return myShoppingLists;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");
    int i = 1;
    foreach (string item in someList)
    {

        Console.WriteLine($"{i}. {item}");
        i++;
    }
}
