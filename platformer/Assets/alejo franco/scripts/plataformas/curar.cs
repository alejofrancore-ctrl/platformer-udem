using UnityEngine;

public class curar : MonoBehaviour
{
    [SerializeField]private playerstats _playerstats ;
    [SerializeField]private Uimanager _uimanager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag=="Player")
         {
            _playerstats.sumarvida(10);
            Destroy(this.gameObject);
         }
    }
}
