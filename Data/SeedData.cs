using AddisEats.Api.Models;

namespace AddisEats.Api.Data;

public static class SeedData
{
    public static List<Restaurant> allRestaurants { get; set; } = new()
    {
        new Restaurant
        {
            Id = 1,
            Name = "Kategna Restaurant",
            Address = "Bole Road, Near Medhanialem Church, Addis Ababa",
            Phone = "+251 11 661 2233",
            IsActive = true
        },
        new Restaurant
        {
            Id = 2,
            Name = "Yod Abyssinia Cultural Restaurant",
            Address = "Bole Medhanealem, Addis Ababa",
            Phone = "+251 11 661 2179",
            IsActive = true
        },
        new Restaurant
        {
            Id = 3,
            Name = "2000 Habesha Cultural Restaurant",
            Address = "Namibia St, Bole, Addis Ababa",
            Phone = "+251 11 618 2253",
            IsActive = true
        }
    };

    public static List<Restaurant> Restaurants => allRestaurants;

    public static List<MenuItem> MenuItems { get; } = new()
    {
        new MenuItem
        {
            Id = 1,
            Name = "Special Beef Tibs",
            Description = "Sautéed tender prime beef chunks with sliced green jalapeño, red onions, garlic, and fresh rosemary sprigs served sizzling with fresh injera.",
            Price = 650m,
            Category = "Traditional",
            IsVegetarian = false,
            IsSpecial = true,
            PrepTime = "20-25 min",
            ImageUrl = "Tibse.jpg",
            RestaurantId = 1
        },
        new MenuItem
        {
            Id = 2,
            Name = "Doro Wat Classic",
            Description = "Slow-simmered chicken drumstick in a deep, fragrant berbere stew with sweet caramelized shallots, seasoned butter, and a hard-boiled farm egg.",
            Price = 750m,
            Category = "Traditional",
            IsVegetarian = false,
            IsSpecial = true,
            PrepTime = "30-35 min",
            ImageUrl = "Doro Wot.jpg",
            RestaurantId = 1
        },
        new MenuItem
        {
            Id = 3,
            Name = "Shiro Tegabino",
            Description = "Roasted chickpea and split-pea flour simmered with minced onions, garlic, and berbere in an earthen clay pot until bubbling hot.",
            Price = 380m,
            Category = "Traditional",
            IsVegetarian = true,
            IsSpecial = false,
            PrepTime = "15-20 min",
            ImageUrl = "Shiro.jpg",
            RestaurantId = 2
        },
        new MenuItem
        {
            Id = 4,
            Name = "Special Beyaynetu Platter",
            Description = "A colorful royal fasting combination platter served over sourdough injera: Misir Wat, Ater Kik, Gomen, and Atkilt.",
            Price = 490m,
            Category = "Traditional",
            IsVegetarian = true,
            IsSpecial = true,
            PrepTime = "20 min",
            ImageUrl = "Beyaynetu.jpg",
            RestaurantId = 2
        },
        new MenuItem
        {
            Id = 5,
            Name = "Special Kitfo",
            Description = "Freshly minced lean beef infused with aromatic niter kibbeh and fiery mitmita chili. Served leb-leb with ayib cottage cheese and gomen.",
            Price = 720m,
            Category = "Traditional",
            IsVegetarian = false,
            IsSpecial = true,
            PrepTime = "15-20 min",
            ImageUrl = "Kitfo.jpg",
            RestaurantId = 3
        }
    };
}

