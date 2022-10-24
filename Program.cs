using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var menu = new Menu()
        {
            MenuItems = new List<MenuItem>
{
// Adding/creating Menu Items to be displayed on the Menu Hierarchy Level "0"
new MenuItem
{
Name = "Administration",
SubItems = new List<MenuItem>
{
    // Adding/creating Submenu Items to be displayed on the Menu Hierarchy Level "1"
new MenuItem
{
Name = "UserAdmin",
SubItems = new List<MenuItem>
{
        // Adding/creating Submenu Items to be displayed on the Menu Hierarchy Level "2"
new MenuItem
{
Name = "CreateUser"
},
new MenuItem
{
Name = "EditUser"
}
}
},
new MenuItem
{
Name = "ProductAdmin",
SubItems = new List<MenuItem>
{
new MenuItem
{
Name = "AllProducts",
SubItems = new List<MenuItem>
{
new MenuItem
{
Name = "MyProduct"
}
}
},
new MenuItem
{
Name = "CreateProduct"
}
}
},
new MenuItem
{
Name = "OrderAdmin",
SubItems = new List<MenuItem>
{
new MenuItem
{
Name = "OderReport",
SubItems = new List<MenuItem>
{
new MenuItem
{
Name = "AuditReport",
SubItems = new List<MenuItem>
{
new MenuItem
{
Name = "UpdatedOrders",
},
new MenuItem
{
Name = "CreatedOrders",
}
}
}
}
},
new MenuItem
{
Name = "CreateOrders"
}
}
}
}
},
// Adding/creating Menu Items to be displayed on the Menu Hierarchy Level "0"
new MenuItem
{
Name = "Reports",
SubItems = new List<MenuItem>
{
new MenuItem
{
Name = "WintecReports"
},
new MenuItem
{
Name = "MicrosoftReports"
}
}
}
}
        };
        //display items
        menu.Display();
    }
}
//Menu Item Class for all Menu Items.
class MenuItem
{
    //menu Item properties/List
    public string Name { get; set; }
   
    public List<MenuItem> SubItems { get; set; }
    //Add Tab spaces for every N level in Menu
    public void Display(int level)
    {
        level++;
        //output Menu Items
        Console.WriteLine(" - " + Name);
        if (SubItems != null && SubItems.Any())
        {
            //Loop through MenuItem in the List
            foreach (var item in SubItems)
            {
                for (int i = 0; i < level; i++)
                {
                    Console.Write('\t');
                }
                item.Display(level);
            }
        }
    }
}
//Menu class that represent the actual Menu
class Menu
{
    public List<MenuItem> MenuItems { get; set; }
    //Menu Items Display Method,Loop through all MenuItems
    public void Display()
    {
        foreach (var item in MenuItems)
        {
            item.Display(0);
        }
    }
}