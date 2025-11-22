namespace BibliotecaDescuentos
{
    public interface IDescuento
    {
        decimal AplicarDescuento(decimal totalCompra);
    }

    public class DescuentoRegular : IDescuento
    {
        public decimal AplicarDescuento(decimal totalCompra)
        {
            return totalCompra;
        }
    }

    public class DescuentoVIP : IDescuento
    {
        public decimal AplicarDescuento(decimal totalCompra)
        {
            return totalCompra * 0.90m;
        }
    }

    public class DescuentoEmpleado : IDescuento
    {
        public decimal AplicarDescuento(decimal totalCompra)
        {
            return totalCompra * 0.80m;
        }
    }
}
