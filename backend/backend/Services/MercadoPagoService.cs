using backend.Models;
using backend.Services.Interfaces;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;
using Microsoft.Extensions.Options;

namespace backend.Services
{
    public class MercadoPagoService : IMercadoPagoService
    {
        private readonly IOptions<MercadoPagoSettings> _settings;

        public MercadoPagoService(IOptions<MercadoPagoSettings> settings)
        {
            _settings = settings;
            MercadoPagoConfig.AccessToken = _settings.Value.AccessToken;
        }

        public async Task<Preference> CreatePreferenceAsync(MercadoPagoDepositRequest request)
        {
            var preferenceRequest = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
                {
                    new PreferenceItemRequest
                    {
                        Title = $"{request.Amount.ToString()}",
                        Quantity = 1,
                        CurrencyId = "ARS",
                        UnitPrice = request.Amount,
                    },
                },
            };

            var client = new PreferenceClient();

            return await client.CreateAsync(preferenceRequest);
        }
    }
}