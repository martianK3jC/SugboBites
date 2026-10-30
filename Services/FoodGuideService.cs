using SugboBites.Models;

namespace SugboBites.Services;

/// <summary>Provides the Cebu dish catalog and lookup by dish ID.</summary>
public sealed class FoodGuideService
{
    private const string CebuTourism = "https://tourism.cebu.gov.ph/";
    private const string CarcarTourism = "https://tourism.cebu.gov.ph/explore/carcar-city/";

    private readonly IReadOnlyList<Dish> dishes =
    [
        new()
        {
            Id = 1,
            Name = "Cebu Lechon",
            Category = "Roast & share",
            Location = "Cebu City and across Cebu",
            Description = "Whole pig roasted until the skin turns crisp and the meat stays fragrant with herbs and aromatics.",
            Story = "Lechon is a celebratory centerpiece as much as a meal. Cebu's provincial tourism office highlights the island's distinctive herb-seasoned roast; in Carcar, the local style is especially well known.",
            ImageUrl = "/images/lechon.jpg",
            ImageAlt = "Crisp golden Cebu-style lechon",
            SourceName = "Cebu Provincial Tourism Office",
            SourceUrl = CebuTourism
        },
        new()
        {
            Id = 2,
            Name = "Carcar Lechon",
            Category = "Roast & share",
            Location = "Carcar City, South Cebu",
            Description = "A southern Cebu specialty associated with Carcar's public market and heritage-town food culture.",
            Story = "Pair a market meal with a walk around Carcar's heritage plaza. The city sits roughly 40 km south of Cebu City; travel time depends on traffic. Market trade and stall availability can change, so check locally before making a dedicated trip.",
            ImageUrl = "/images/roast_pork.jpg",
            ImageAlt = "Roasted pork served as a Cebu lechon meal",
            SourceName = "Carcar City Tourism Office",
            SourceUrl = CarcarTourism
        },
        new()
        {
            Id = 3,
            Name = "Pork Barbecue & Puso",
            Category = "Grill & street food",
            Location = "Cebu City and towns across Cebu",
            Description = "Char-grilled pork skewers served with puso, rice wrapped in woven coconut leaves.",
            Story = "A familiar Cebuano pairing for a casual meal: smoky barbecue and compact hanging rice. Try it at a local grill, and ask the vendor what is freshly cooked that day.",
            ImageUrl = "/images/grilled_pork_bbq_with_puso.webp",
            ImageAlt = "Pork barbecue skewers with woven-leaf puso rice",
            SourceName = "Cebu Provincial Tourism Office",
            SourceUrl = CebuTourism
        },
        new()
        {
            Id = 4,
            Name = "Chicken Barbecue & Puso",
            Category = "Grill & street food",
            Location = "Cebu City and towns across Cebu",
            Description = "Marinated chicken cooked over a grill and commonly enjoyed with puso.",
            Story = "Grilled food is part of everyday Cebu dining. This guide describes the dish, not a specific vendor; choose a busy stall and check today's menu and prices in person.",
            ImageUrl = "/images/chicken_bbq_with_puso.webp",
            ImageAlt = "Grilled chicken barbecue served with puso",
            SourceName = "Cebu Provincial Tourism Office",
            SourceUrl = CebuTourism
        },
        new()
        {
            Id = 5,
            Name = "Cebu Ngohiong",
            Category = "Grill & street food",
            Location = "Cebu City",
            Description = "A crisp fried roll with a savory filling and a distinct five-spice character, often served with dipping sauce.",
            Story = "Ngohiong is a well-loved Cebu snack with a flavor all its own. Recipes and fillings differ from kitchen to kitchen; this entry is a dish introduction, not a claim about one restaurant's recipe.",
            ImageUrl = "/images/Cebu_style_ngohiong.webp",
            ImageAlt = "Golden Cebu-style ngohiong rolls",
            SourceName = "Cebu Provincial Tourism Office",
            SourceUrl = CebuTourism
        },
        new()
        {
            Id = 6,
            Name = "Ngohiong Snack Plate",
            Category = "Grill & street food",
            Location = "Cebu City and nearby towns",
            Description = "Crisp ngohiong served as a snack plate, an easy stop during a city food walk.",
            Story = "Small eateries serve their own versions and accompaniments. Ask what comes with the order and confirm the current price before buying.",
            ImageUrl = "/images/Ngohiong_snack_plate.jpg",
            ImageAlt = "A snack plate of Cebu ngohiong",
            SourceName = "Cebu Provincial Tourism Office",
            SourceUrl = CebuTourism
        },
        new()
        {
            Id = 7,
            Name = "Sugba: Grilled Seafood",
            Category = "Seafood & island flavors",
            Location = "Coastal Cebu and Mactan",
            Description = "Fresh fish and seafood cooked over a grill, often ordered for sharing by the coast.",
            Story = "Sugba is the grilled part of the Cebuano sutukil dining tradition. Ask what seafood is in season and how it is priced before ordering; availability varies by day and location.",
            ImageUrl = "/images/grilled_fish_and_seafood.jpg",
            ImageAlt = "Whole grilled fish and seafood in a Cebu-style spread",
            SourceName = "Cebu Provincial Tourism Office",
            SourceUrl = CebuTourism
        },
        new()
        {
            Id = 8,
            Name = "Seafood with Rice",
            Category = "Seafood & island flavors",
            Location = "Coastal Cebu and Mactan",
            Description = "A relaxed seafood meal with grilled catch and rice, suited to sharing after a day by the water.",
            Story = "Seafood selection and price are usually tied to the day's catch and serving size. Confirm both with the restaurant before ordering; no fixed price is listed in this guide.",
            ImageUrl = "/images/Grilled seafood with rice.jpg",
            ImageAlt = "Grilled Cebu seafood served with rice",
            SourceName = "Cebu Provincial Tourism Office",
            SourceUrl = CebuTourism
        }
    ];

    public IReadOnlyList<Dish> Dishes => dishes;
    public Dish? Find(int id) => dishes.FirstOrDefault(dish => dish.Id == id);
}
