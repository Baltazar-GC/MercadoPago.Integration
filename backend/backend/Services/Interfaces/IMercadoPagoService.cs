using backend.Models;
using MercadoPago.Resource.Preference;

namespace backend.Services.Interfaces
{
    public interface IMercadoPagoService
    {
        Task<Preference> CreatePreferenceAsync(MercadoPagoDepositRequest request);
    }
}
