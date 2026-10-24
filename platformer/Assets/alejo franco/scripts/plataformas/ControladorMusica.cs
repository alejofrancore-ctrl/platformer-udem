using UnityEngine;

public class ControladorMusica : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        
        _audioSource = GetComponent<AudioSource>();

        
        _audioSource.spatialBlend = 0f;
    }

    
    public void ReproducirMusica()
    {
        if (_audioSource != null)
        {
            _audioSource.Play();
        }
    }
}