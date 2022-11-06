using System.Text.Json.Serialization;

namespace FlightBooking.FlightService.Dto;

public class FlightResponse
{
    /// <summary>
    /// Номер полета
    /// </summary>
    [JsonPropertyName("flightNumber")]
    public string FlightNumber { get; set; }
    
    /// <summary>
    /// Страна и аэропорт отправления
    /// </summary>
    [JsonPropertyName("fromAirport")]
    public string FromAirport { get; set; }
    
    /// <summary>
    /// Страна и аэропорт прибытия
    /// </summary>
    [JsonPropertyName("toAirport")]
    public string ToAirport { get; set; }
    
    /// <summary>
    /// Дата и время вылета
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Стоимость
    /// </summary>
    [JsonPropertyName("price")]
    public double Price { get; set; }
}