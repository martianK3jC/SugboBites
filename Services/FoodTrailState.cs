using SugboBites.Models;

namespace SugboBites.Services;

/// <summary>Saved dishes for the current interactive server circuit; a full page reload starts a new trail.</summary>
public sealed class FoodTrailState
{
    private readonly List<Dish> savedDishes = [];

    public IReadOnlyList<Dish> SavedDishes => savedDishes;
    public event Action? Changed;

    public bool Contains(int dishId) => savedDishes.Any(dish => dish.Id == dishId);

    public bool Add(Dish dish)
    {
        if (Contains(dish.Id)) return false;
        savedDishes.Add(dish);
        Changed?.Invoke();
        return true;
    }

    public bool Remove(int dishId)
    {
        var dish = savedDishes.FirstOrDefault(item => item.Id == dishId);
        if (dish is null) return false;
        savedDishes.Remove(dish);
        Changed?.Invoke();
        return true;
    }

    public void Clear()
    {
        if (savedDishes.Count == 0) return;
        savedDishes.Clear();
        Changed?.Invoke();
    }
}
