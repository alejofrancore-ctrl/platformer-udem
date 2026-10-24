using UnityEngine;

public class invencibilidad : MonoBehaviour
{
    [SerializeField] private float _duracion = 15f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // 1. Activa la invencibilidad en el jugador
            collision.GetComponent<playerstats>()?.SerInvencible(_duracion);

            // 2. Buscamos el objeto de la música en la escena y lo encendemos
            ControladorMusica musica = FindObjectOfType<ControladorMusica>();
            if (musica != null)
            {
                musica.ReproducirMusica();
            }

            // 3. Destruimos solo la estrella visual
            Destroy(gameObject);
        }
    }
}