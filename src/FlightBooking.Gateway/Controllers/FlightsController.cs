using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Threading.Tasks;
using FlightBooking.FlightService.Dto;
using FlightBooking.Gateway.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace FlightBooking.Gateway.Controllers;

[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Route("/api/v1/flights")]
public class FlightsController : ControllerBase
{
    private readonly ILogger<FlightsController> _logger;
    private readonly IFlightsRepository _flightsRepository;
    
    public FlightsController(ILogger<FlightsController> logger, IFlightsRepository flightsRepository)
    {
        _logger = logger;
        _flightsRepository = flightsRepository;
    }

    /// <summary>
    /// Получить список рейсов
    /// </summary>
    /// <param name="page">Номер страницы </param>
    /// <param name="size">Количество элементов на странице </param>
    /// <returns></returns>
    [HttpGet]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(PaginationFlightsResponse), description: "Список рейсов")]
    [SwaggerResponse(statusCode: StatusCodes.Status500InternalServerError, description: "Ошибка на стороне сервера.")]
    public async Task<IActionResult> Get([Range(1, int.MaxValue)] int page, [Range(1, 100)] int size)
    {
        try
        {
            var response = await _flightsRepository.GetAllAsync(page, size);
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error!");
            throw;
        }
    }
}