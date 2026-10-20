using UnityEngine;

public class groundcheck : MonoBehaviour
{
   public bool estaEnSuelo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerStay2D(Collider2D collision)
    {
        estaEnSuelo = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        estaEnSuelo = false;
    }
}
         
