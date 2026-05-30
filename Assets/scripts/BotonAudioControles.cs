using UnityEngine;

public class BotonAudioControles : MonoBehaviour
{
    public PiezaAudioPlayer audioPlayer;
    public PiezaPanelUI panelUI;

    public void AlPresionarPausa()
    {
        if (audioPlayer.audioSource.isPlaying)
            audioPlayer.Pausar();
        else
            audioPlayer.Reanudar();
    }

    public void AlPresionarReiniciar()
    {
        audioPlayer.Reiniciar();
    }

    public void AlPresionarCerrar()
    {
        audioPlayer.Detener();
        panelUI.CerrarPanel();
    }
}