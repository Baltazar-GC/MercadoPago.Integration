import { useEffect } from "react";
import { initMercadoPago, Wallet } from "@mercadopago/sdk-react";

const MercadoPagoButton = () => {
  useEffect(() => {
    const publicKey = import.meta.env.REACT_APP_MERCADO_PAGO_PUBLIC_KEY;

    if (publicKey) {
      initMercadoPago(publicKey, {
        locale: "es-AR",
      });
    }
  }, []);

  return (
    <div>
      <Wallet
        initialization={{
          preferenceId: "your-preference-id",
          redirectMode: "modal",
        }}
        customization={{
          visual: {
            buttonBackground: "blue",
            valuePropColor: "white",
          },
        }}
      />
    </div>
  );
};

export default MercadoPagoButton;
