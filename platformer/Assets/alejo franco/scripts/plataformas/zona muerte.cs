using UnityEngine;

public class zonamuerte : MonoBehaviour
{
    [SerializeField] private playerstats _playerstats;
    [SerializeField] private GameObject _gameover;
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            _playerstats.restarvida(30);
            _gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
}
