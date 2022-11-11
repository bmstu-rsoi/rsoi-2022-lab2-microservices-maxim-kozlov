using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlightBooking.Gateway.Dto.Tickets;

namespace FlightBooking.Gateway.Domain;

public interface ITicketsService
{
    Task<TicketResponse> GetAsync(string username, Guid ticketUid);
    
    Task<List<TicketResponse>> GetAllAsync(string username);

    Task<TicketPurchaseResponse> Purchase(string username, TicketPurchaseRequest request);
}