using UnityEngine;

public class Mascota : MonoBehaviour
{
    [Header("Referencias a barras")]
    [SerializeField] private BarraEstado hambre;
    [SerializeField] private BarraEstado sueno;
    [SerializeField] private BarraEstado higiene;
    [SerializeField] private BarraEstado diversion;

    [Header("Economía")]
    [SerializeField] private MonedasManager monedasManager;

    [Header("Velocidades de cambio")]
    [SerializeField] private float velocidadHambre = 2f; 
    [SerializeField] private float velocidadSueno = 1f;

    [Header("Valores de acciones")]
    [SerializeField] private int costoComida = 5;
    [SerializeField] private float cantidadComida = 20f;
    [SerializeField] private float cantidadDormir = 15f;
    [SerializeField] private float cantidadHigiene = 25f;
    [SerializeField] private float cantidadDiversion = 20f;

    private void Update()
    {
        hambre.Modificar(-velocidadHambre * Time.deltaTime);
        sueno.Modificar(-velocidadSueno * Time.deltaTime);
    }

    public void ComerBoton()
    {
        if (monedasManager.GastarMonedas(costoComida))
        {
            hambre.Modificar(cantidadComida);
        }
    }

    public void DormirBoton()
    {
        sueno.Modificar(cantidadDormir);
    }

    public void BañarBoton()
    {
        higiene.Modificar(cantidadHigiene);
    }

    public void JugarBoton()
    {
        diversion.Modificar(cantidadDiversion);
    }
}
