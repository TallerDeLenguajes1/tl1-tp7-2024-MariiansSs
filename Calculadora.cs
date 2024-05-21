namespace CalculadoraEspacio;

public class Calculadora
{
    private double dato;

    public double RESULTADO{ get => dato;}

    public void sumar(double valorRecibido)
    {
         dato = dato + valorRecibido;
    }

    public void restar(double valorRecibido)
    {
        dato = dato - valorRecibido;
    }

    public void multiplicar(double valorRecibido)
    {
        dato = dato * valorRecibido;
    }

    public void dividir(double valorRecibido)
    {
        dato = dato / valorRecibido;
    }

    public void limpiar()
    {
        dato = 0;
    }


}