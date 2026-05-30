using UnityEngine;

public class PiezaAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;

    public void Reproducir()
    {
        audioSource.Stop();
        audioSource.Play();
    }

    public void Pausar()
    {
        if (audioSource.isPlaying)
            audioSource.Pause();
    }

    public void Reanudar()
    {
        if (!audioSource.isPlaying)
            audioSource.UnPause();
    }

    public void Reiniciar()
    {
        audioSource.Stop();
        audioSource.Play();
    }

    public void Detener()
    {
        audioSource.Stop();
    }
}