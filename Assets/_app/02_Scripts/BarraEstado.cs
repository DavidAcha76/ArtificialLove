using UnityEngine;
using UnityEngine.UI;

public class BarraEstado : MonoBehaviour
{
    [SerializeField] private Image relleno;     
    [SerializeField] private float valorMaximo = 100f;

    private float valorActual;

    public float ValorActual => valorActual;
    public float ValorMaximo => valorMaximo;

    private void Start()
    {
        valorActual = valorMaximo; 
        ActualizarUI();
    }

    public void Modificar(float cantidad)
    {
        valorActual = Mathf.Clamp(valorActual + cantidad, 0, valorMaximo);
        ActualizarUI();
    }

    private void ActualizarUI()
    {
        relleno.fillAmount = valorActual / valorMaximo;
    }
}
