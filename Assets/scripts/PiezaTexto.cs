using UnityEngine;
using TMPro;

public class PiezaTexto : MonoBehaviour
{
    public TextMeshProUGUI campoTexto;
    [TextArea] public string descripcion;
    public void MostrarDescripcion()
    {
        campoTexto.text = descripcion;
    }
    public void LimpiarTexto()
    {
        campoTexto.text = "";
    }
    
}