using UnityEngine;

public class invencibilidad : MonoBehaviour
{
    [SerializeField] private float _duracion = 15f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            collision.GetComponent<playerstats>()?.SerInvencible(_duracion);

            
            ControladorMusica musica = FindObjectOfType<ControladorMusica>();
            if (musica != null)
            {
                musica.ReproducirMusica();
            }

            
            Destroy(gameObject);
        }
    }
}