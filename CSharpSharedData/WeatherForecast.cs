namespace CSharpSharedData;

public class WeatherForecast : IEquatable<WeatherForecast>
{
	const int NumberOfItems = 1_000;
	public Guid Id { get; set; } = Guid.NewGuid();
	public DateTime LastRendered => DateTime.UtcNow;
	public DateTime Date { get; set; }

	public int TemperatureC { get; set; }

	public string? Summary { get; set; }

	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

	public static readonly WeatherForecast[] Data;

	public bool Equals(WeatherForecast? other) =>
		other is not null
		&& other.Id == Id
		&& other.Date == Date
		&& other.TemperatureC == TemperatureC
		&& other.Summary == Summary;

	static WeatherForecast()
	{
		var sourceData = new WeatherForecast[]
		{
			new WeatherForecast
			{
				Date = DateTime.Parse("2018-05-06"),
				TemperatureC = 1,
				Summary = "Freezing"
			},
			new WeatherForecast
			{
				Date = DateTime.Parse("2018-05-07"),
				TemperatureC = 14,
				Summary = "Bracing"
			},
			new WeatherForecast
			{
				Date = DateTime.Parse("2018-05-09"),
				TemperatureC = -16,
				Summary = "Balmy"
			},
			new WeatherForecast
			{
				Date = DateTime.Parse("2018-05-10"),
				TemperatureC = -2,
				Summary = "Chilly"
			},
		};
		var dataBuilder = new List<WeatherForecast>(NumberOfItems);
		dataBuilder.Add(
			new WeatherForecast
			{
				Date = DateTime.Parse("2018-05-06"),
				TemperatureC = 1,
				Summary = "_Single line"
			});

		int sourceIndex = 0;
		while (dataBuilder.Count < NumberOfItems)
		{
			var sourceItem = sourceData[sourceIndex];
			var newItem = new WeatherForecast
			{
				Date = sourceItem.Date,
				TemperatureC = sourceItem.TemperatureC,
				Summary = sourceItem.Summary
			};

			dataBuilder.Add(newItem);
			sourceIndex++;
			if (sourceIndex >= sourceData.Length)
				sourceIndex = 0;
		};
		Data = dataBuilder.ToArray();
	}
}
