using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField] private playerstats _playerstats;
    [SerializeField] private Uimanager _uimanager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            _playerstats.restarvida(10);
            Destroy(this.gameObject);
        }
    }
    
   
}
