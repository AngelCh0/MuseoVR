using UnityEngine;

public class PiezaPanelUI : MonoBehaviour
{
    public GameObject panelRaiz;
    public GameObject seccionEleccion;
    public GameObject seccionTexto;
    public GameObject seccionAudio;
    void Start()
    {
        if (panelRaiz != null) panelRaiz.SetActive(false);
    }

    public void AbrirPanel()
    {
        if (panelRaiz != null) panelRaiz.SetActive(true);
        MostrarEleccion();
    }

    public void CerrarPanel()
    {
        if (panelRaiz != null) panelRaiz.SetActive(false);
        OcultarTodo();
    }

    public void MostrarEleccion()
    {
        if (seccionEleccion != null) seccionEleccion.SetActive(true);
        if (seccionTexto != null) seccionTexto.SetActive(false);
        if (seccionAudio != null) seccionAudio.SetActive(false);
    }

    public void MostrarTexto()
    {
        if (seccionEleccion != null) seccionEleccion.SetActive(false);
        if (seccionTexto != null) seccionTexto.SetActive(true); 
        if (seccionAudio != null) seccionAudio.SetActive(false);
    }

    public void MostrarAudio()
    {
        if (seccionEleccion != null) seccionEleccion.SetActive(false);
        if (seccionTexto != null) seccionTexto.SetActive(false);
        if (seccionAudio != null) seccionAudio.SetActive(true);
    }

    void OcultarTodo()
    {
        if (seccionEleccion != null) seccionEleccion.SetActive(false);
        if (seccionTexto != null) seccionTexto.SetActive(false);
        if (seccionAudio != null) seccionAudio.SetActive(false);
    }
    public void AlternarPanel()
    {
        if (panelRaiz.activeSelf)
        {
            CerrarPanel();
        }
        else
        {
            AbrirPanel();
        }
    }
}