using ItemsandSales;
class Program
{
    static void Main(string[] args)
    {
        // Task 1: Group Nigerian states in 3
        List<string> nigerianStates = new List<string>
        {
            "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa",
            "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo",
            "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano",
            "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", "Niger",
            "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto", "Taraba", "Yobe", "Zamfara"
        };
        List<List<string>> groupedStates = StateGrouping.GroupStatesBy3(nigerianStates, 3);

        //Print the grouped states in sets of 3
        Console.WriteLine("A Group of States in sets of 3:");
        Console.WriteLine("================================");

        foreach (var group in groupedStates)
        {
            Console.WriteLine(string.Join(", ", group));
            Console.WriteLine("---------------------------");
        }


        // Task 2: Generating a distinct list of items and sales
        List<Item> itemlist = new List<Item>
        {
            new Item { ItemId = 1, ItemDes = "Bag" },
            new Item { ItemId = 2, ItemDes = "Pen" },
            new Item { ItemId = 3, ItemDes = "Book" },
            new Item { ItemId = 4, ItemDes = "Shoe" },
            new Item { ItemId = 5, ItemDes = "Pin" }
        };

        List<Sales> saleslist = new List<Sales>
        {
            new Sales { InvNo = 1, ItemId = 3, Qty = 10 },
            new Sales { InvNo = 2, ItemId = 2, Qty = 20 },
            new Sales { InvNo = 3, ItemId = 3, Qty = 500 },
            new Sales { InvNo = 4, ItemId = 4, Qty = 20 },
            new Sales { InvNo = 5, ItemId = 3, Qty = 100 },
            new Sales { InvNo = 6, ItemId = 1, Qty = 50 }
        };

        var distinctItems = from item in itemlist
                            join sale in saleslist on item.ItemId equals sale.ItemId
                            select new
                            {
                                ItemID = item.ItemId,
                                ItemName = item.ItemDes,
                                Quantity = sale.Qty
                            };

        //Print the distinct items ans sales 
        Console.WriteLine("\n\nDistinct Items:");
        Console.WriteLine("Item ID\t\tItem Name\tQuantity");
        Console.WriteLine("-----------------------------------------");
        foreach (var distinctItem in distinctItems)
        {
            Console.WriteLine($"{distinctItem.ItemID}\t\t{distinctItem.ItemName}\t\t{distinctItem.Quantity}");
        }


        // Task 3: Print the 36 states of Nigeria in groups of 26 alphabets and in ascending order.
        var stateGroups = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            .Select(letter => new
            {
                Letter = letter,
                States = nigerianStates
                    .Where(state => state.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                    .ToList()
            })
            .Where(group => group.States.Any())
            .OrderBy(group => group.Letter);

        //Print the count of states by alphabet
        Console.WriteLine("\n\nCount of States by Alphabet:");
        Console.WriteLine("==============================");

        foreach (var group in stateGroups)
        {
            Console.WriteLine($"Group {group.Letter} - {group.States.Count}");
            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join(", ", group.States));
            Console.WriteLine();
        }




    }
}





