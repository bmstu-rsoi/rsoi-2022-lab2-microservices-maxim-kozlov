using System.Text.Json.Serialization;

namespace FlightBooking.FlightService.Dto;

public class PaginationFlightsResponse
{
    /// <summary>
    /// Номер страницы
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    /// <summary>
    /// Количество элементов на странице
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }
    
    /// <summary>
    /// Общее количество элементов
    /// </summary>
    [JsonPropertyName("totalElements")]
    public int TotalElements { get; set; }
    
    /// <summary>
    /// Массив рейсов
    /// </summary>
    [JsonPropertyName("items")]
    public FlightResponse[] Flights { get; set; }
}