using backend.Models;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/mercado-pago")]
    [ApiController]
    public class MercadoPagoController(IMercadoPagoService mercadoPagoService) : ControllerBase
    {
        [HttpPost("deposit")]
        public async Task<IActionResult> CreatePreferenceForMercadoPago(
            MercadoPagoDepositRequest request
        )
        {
            try
            {
                var preferenceId = await mercadoPagoService.CreatePreferenceAsync(request);

                return Ok(new { PreferenceId = preferenceId });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while processing the request. - {ex.Message?.ToString()}");
            }
        }
    }
}
