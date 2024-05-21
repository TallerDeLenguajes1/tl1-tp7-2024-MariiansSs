namespace Empleado;

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fecNac;
    private char estadoCivil;
    private double sueldo;

    private cargos cargo;
    private enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public string Nombre
    {
        get
        {
            return nombre;
        }
    }

    public string Apellido
    {
        get
        {
            return apellido;
        }
    }

    public DateTime Fecnac
    {
        get
        {
            return fecNac;
        }
    }

}