import MercadoPagoButton from "./components/MercadoPagoButton";
import Jordan from "./assets/jordan.png";
const App = () => {
  return (
    <div className="app">
      <div className="product">
        <img src={Jordan} alt="jordan" />
        <div className="product-details">
          <h2 className="product-name">Air Jordan</h2>
          <p className="product-price">$100</p>
          <MercadoPagoButton />
        </div>
      </div>
    </div>
  );
};

export default App;
