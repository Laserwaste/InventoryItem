string[] Inventory = { "Health Potion", "Sword ", "Shield","Bread","Key" };

for (int i = 0; i < Inventory.Length; i++)
{
    Console.WriteLine($"slot {i}: {Inventory[i]}");
}

Console.WriteLine($"\nTotal items: {Inventory.Length}");