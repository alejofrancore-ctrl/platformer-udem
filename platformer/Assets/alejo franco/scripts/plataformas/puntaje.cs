using UnityEngine;

public class puntaje : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] playerstats _playerstats;
   public void OnTriggerEnter2D(Collider2D Collision)
    {
        _playerstats.sumapuntaje(10);
    }
}
