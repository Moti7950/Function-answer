// See https://aka.ms/new-console-template for more information
//1
//List<string> nams = new List<string> { "Ali", "Yosi", "Ron", "Maya", "Ronit" };
//nams.Add("Amit");
//nams.Add("Moti");
//nams.Remove("Ron");
//foreach (string name in nams)
//{
//    Console.WriteLine(name);
//}

//2
//Dictionary<string, int> prodact = new Dictionary<string, int> {
//            {"Leptop", 25},
//            {"Mouse", 30},
//            {"Keybord", 28},
//        };
//prodact["Leptop"] = 20;

//foreach (KeyValuePair<string, int> kvp in prodact)
//{
//    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//}

//3
//List<Dictionary<string, string>> data = new List<Dictionary<string, string>> ()
//{
//    new Dictionary<string, string>()
//    {
//        { "name", "Ali" },
//        { "email", "aa@aa.com" },
//        { "status", "Active" },
//    },

//    new Dictionary<string, string>()
//    {
//        { "name", "Moti" },
//        { "email", "bb@bb.com" },
//        { "status", " NOT Active" }
//    }
//};
//foreach (var item in data)
//{
//    foreach (var kvp in item)
//    {
//        if (kvp.Key == "email")
//        { 
//            Console.WriteLine($"email: {kvp.Value}");
//        }
//    }
//}

//4
//List<string> userName = new List<string> { "Admin", "Moti", "admin" };
//Console.WriteLine("Please enter a username: ");
//string userNameInput = Console.ReadLine();

//bool found = false;
//for (int i = 0; i < userName.Count; i++)
//{
//    if (userNameInput == userName[i])
//    {
//        Console.WriteLine(i);
//        found = true;
//        break;
//    }
//}
//if (!found)
//{
//    Console.WriteLine("User not found");
//}

//5
//string recorderTools = "recorder";
//string mapTools = "map";
//string notebookTools = "notebook";
//Dictionary<string, List<string>> tools = new Dictionary<string, List<string>>
//{
//    { "Avi", new List<string> {"recorder","map", "notebook"} },
//    { "Moshe",new List<string> {"recorder","map", "notebook" } },
//    { "Rami", new List<string> {"recorder", "notebook"} }
//};

//foreach (var kvp in tools)
//{
//    string name = kvp.Key;
//    List<string> toolList = kvp.Value;

//    if (toolList.Count == 3)
//    {
//        Console.WriteLine($"{name} is ready for intel work.");
//    }
//    else
//    {
//        Console.WriteLine($"{name} is missing tools.");
//    }
//}