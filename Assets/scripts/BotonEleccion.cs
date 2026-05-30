using UnityEngine;

public class BotonEleccion : MonoBehaviour
{
    public PiezaPanelUI panelUI;
    public PiezaTexto piezaTexto;
    public PiezaAudioPlayer audioPlayer;

    public void ElegirTexto()
    {
        panelUI.MostrarTexto();
        piezaTexto.MostrarDescripcion();
    }

    public void ElegirAudio()
    {
        panelUI.MostrarAudio();
        piezaTexto.MostrarDescripcion(); // texto de fondo igual
        audioPlayer.Reproducir();
    }
}