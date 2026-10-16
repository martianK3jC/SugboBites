using SugboBites.Models;

namespace SugboBites.Services;

/// <summary>Saved dishes for the current interactive server circuit. It does not store bookings or payments.</summary>
public sealed class FoodTrailState
{
    private readonly List<FoodSpot> selectedDishes = [];

    public IReadOnlyList<FoodSpot> SelectedDishes => selectedDishes;
    public event Action? Changed;

    public bool Contains(int foodSpotId) => selectedDishes.Any(dish => dish.Id == foodSpotId);

    public bool Add(FoodSpot foodSpot)
    {
        if (Contains(foodSpot.Id)) return false;
        selectedDishes.Add(foodSpot);
        Changed?.Invoke();
        return true;
    }

    public bool Remove(int foodSpotId)
    {
        var dish = selectedDishes.FirstOrDefault(item => item.Id == foodSpotId);
        if (dish is null) return false;
        selectedDishes.Remove(dish);
        Changed?.Invoke();
        return true;
    }

    public void Clear()
    {
        if (selectedDishes.Count == 0) return;
        selectedDishes.Clear();
        Changed?.Invoke();
    }
}
