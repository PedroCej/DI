public class Producto
{
    private int cantidad;
    private double precio;

    public Producto(int cantidad, double precio)
    {
        this.cantidad = cantidad;
        this.precio = precio;
    }
    public int getCantidad()
    {
        return cantidad;
    }
    public double getPrecio()
    {
        return precio;
    }
    public double precioFinal()
    {
        return Convert.ToDouble(this.precio * this.cantidad);
    }
}
