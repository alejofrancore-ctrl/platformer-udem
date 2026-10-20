using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    // cargar una escena
    //reiniciar pausar o salir del juego
    private void Start()
    {
        Time.timeScale= 1;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
     public void cargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale= 1;
    } 
    public void Salirdeljuego()
    {
        Application.Quit();
    }

    public void pausarjuego()
    {
        Time.timeScale= 0;

    }
    public void reanudarjuego()
    {
       Time.timeScale= 1;
    }
}
