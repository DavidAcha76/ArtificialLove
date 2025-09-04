using UnityEngine;
using TMPro;

public class MonedasManager : MonoBehaviour
{
    [SerializeField] private int monedasIniciales = 100;
    [SerializeField] private TMP_Text textoMonedas;

    private int monedas;

    private void Start()
    {
        monedas = monedasIniciales;
        ActualizarUI();
    }

    public bool GastarMonedas(int cantidad)
    {
        if (monedas >= cantidad)
        {
            monedas -= cantidad;
            ActualizarUI();
            return true;
        }
        return false;
    }

    public void AgregarMonedas(int cantidad)
    {
        monedas += cantidad;
        ActualizarUI();
    }

    private void ActualizarUI()
    {
        textoMonedas.text = monedas.ToString();
    }
}
