// Ejemplo de controlador para la gestión de eventos en el calendario
using Microsoft.AspNetCore.Mvc;
using tots_test_api.DTOS;
using tots_test_api.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class CalendarController : ControllerBase
{
    private readonly IOutlookService _outlookService;

    public CalendarController(IOutlookService outlookService)
    {
        _outlookService = outlookService;
    }

    [HttpPost("create-event")]
    public async Task<IActionResult> CreateEvent([FromBody] CreateEventDto eventDto)
    {
        try
        {
            // Validar el DTO utilizando FluentValidation u otra librería de validación
            // ...

            // Crear evento en Outlook
            var createdEvent = await _outlookService.CreateEvent(eventDto);

            return Ok(createdEvent);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("update-event/{eventId}")]
    public async Task<IActionResult> UpdateEvent(string eventId, [FromBody] UpdateEventDto eventDto)
    {
        try
        {
            // Validar el DTO
            // ...

            // Actualizar evento en Outlook
            var updatedEvent = await _outlookService.UpdateEvent(eventId, eventDto);

            return Ok(updatedEvent);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("list-events")]
    public async Task<IActionResult> ListEvents()
    {
        try
        {
            // Obtener lista de eventos desde Outlook
            var events = await _outlookService.ListEvents();

            return Ok(events);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete-event/{eventId}")]
    public async Task<IActionResult> DeleteEvent(string eventId)
    {
        try
        {
            // Eliminar evento en Outlook
            await _outlookService.DeleteEvent(eventId);

            return Ok("Evento eliminado correctamente");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

