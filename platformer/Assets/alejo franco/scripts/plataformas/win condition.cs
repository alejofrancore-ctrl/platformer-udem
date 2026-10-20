using UnityEngine;
using UnityEngine.UI;

public class wincondition : MonoBehaviour
{
    [SerializeField] private GameObject _pvictoria;

    public void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            _pvictoria.SetActive(true);
            
        }
    }

    
}
