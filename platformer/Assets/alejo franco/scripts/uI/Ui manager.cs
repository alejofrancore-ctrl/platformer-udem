using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Uimanager : MonoBehaviour
{
    [SerializeField] private Image Corazon1;
    [SerializeField] private Image Corazon2;
    [SerializeField] private Image Corazon3;
    [SerializeField] private playerstats _playerstats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Corazon3.enabled=true;
        Corazon2.enabled=true;
        Corazon1.enabled=true;
    }
    public void quitarcorazon3()
    {
      Corazon3.enabled=false;

    }
    public void quitarcorazon2()
    {
      Corazon2.enabled=false;

    }
    public void quitarcorazon1()
    {
      Corazon1.enabled=false;

    }
    public void recuperarcorazon2()
    {
        Corazon2.enabled=true;
    }
    public void recuperarcorazon3()
    {
        Corazon3.enabled=true;
    }

    // Update is called once per frame
    
}
