namespace Auto.API;

public static class CarStore
{
    private static readonly List<Car> Cars =
    [
        new Car { Id = 1, Marka = "BMW", Modeli = "M5 Competition", Viti = 2023, Cmimi = 95000, Ngjyra = "E zezë", Kilometra = 15000, Karburanti = "Benzinë", Transmisioni = "Automatik", NeShitje = true, ImazhUrl = "https://images.unsplash.com/photo-1555215695-3004980ad54e?w=600" },
        new Car { Id = 2, Marka = "Mercedes-Benz", Modeli = "C-Class AMG", Viti = 2022, Cmimi = 78000, Ngjyra = "E bardhë", Kilometra = 22000, Karburanti = "Benzinë", Transmisioni = "Automatik", NeShitje = true, ImazhUrl = "https://images.unsplash.com/photo-1617531653332-bd46c24f2068?w=600" },
        new Car { Id = 3, Marka = "Audi", Modeli = "RS6 Avant", Viti = 2024, Cmimi = 125000, Ngjyra = "Gri", Kilometra = 5000, Karburanti = "Benzinë", Transmisioni = "Automatik", NeShitje = true, ImazhUrl = "https://images.unsplash.com/photo-1606664515524-ed2f786a0bd6?w=600" },
        new Car { Id = 4, Marka = "Porsche", Modeli = "911 Carrera", Viti = 2023, Cmimi = 145000, Ngjyra = "E kuqe", Kilometra = 8500, Karburanti = "Benzinë", Transmisioni = "Manual", NeShitje = true, ImazhUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b70?w=600" },
        new Car { Id = 5, Marka = "Tesla", Modeli = "Model S Plaid", Viti = 2024, Cmimi = 110000, Ngjyra = "Blu", Kilometra = 3000, Karburanti = "Elektrik", Transmisioni = "Automatik", NeShitje = true, ImazhUrl = "https://images.unsplash.com/photo-1617788138017-80ad40651399?w=600" },
        new Car { Id = 6, Marka = "Range Rover", Modeli = "Sport HSE", Viti = 2022, Cmimi = 89000, Ngjyra = "E zezë", Kilometra = 31000, Karburanti = "Diesel", Transmisioni = "Automatik", NeShitje = false, ImazhUrl = "https://images.unsplash.com/photo-1606664515524-ed2f786a0bd6?w=600" },
    ];

    public static IEnumerable<Car> GetAll() => Cars;

    public static Car? GetById(int id) => Cars.FirstOrDefault(c => c.Id == id);

    public static Car Add(Car car)
    {
        car.Id = Random.Shared.Next(1000, 9999);
        Cars.Add(car);
        return car;
    }

    public static bool Update(int id, Car car)
    {
        var existing = Cars.FirstOrDefault(c => c.Id == id);
        if (existing is null) return false;

        existing.Marka = car.Marka;
        existing.Modeli = car.Modeli;
        existing.Viti = car.Viti;
        existing.Cmimi = car.Cmimi;
        existing.Ngjyra = car.Ngjyra;
        existing.Kilometra = car.Kilometra;
        existing.Karburanti = car.Karburanti;
        existing.Transmisioni = car.Transmisioni;
        existing.NeShitje = car.NeShitje;
        existing.ImazhUrl = car.ImazhUrl;
        return true;
    }

    public static bool Delete(int id)
    {
        var existing = Cars.FirstOrDefault(c => c.Id == id);
        if (existing is null) return false;
        Cars.Remove(existing);
        return true;
    }
}
