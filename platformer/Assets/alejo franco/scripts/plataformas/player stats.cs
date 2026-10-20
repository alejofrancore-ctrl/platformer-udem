
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public class playerstats : MonoBehaviour
{
    [SerializeField] private float _vida = 30.0f;
    [SerializeField] private Uimanager _uimanager;
    [SerializeField] private float _puntaje = 0f;
    [SerializeField] private GameObject _meta;
    [SerializeField] private GameObject _gameover;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void restarvida(int daño)
    {
        _vida = _vida - daño;
        if (_vida == 20.0f)
        {
            _uimanager.quitarcorazon3();
        }
        if (_vida == 10.0f)
        {
            _uimanager.quitarcorazon2();
        }
        if (_vida <= 0)
        {
            _uimanager.quitarcorazon1();
            _gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void sumarvida(int salud)
    {
        if (_vida >= 30.0f)
        {
            return;
        }
        _vida = _vida + salud;
        if (_vida == 20.0f)
        {
            _uimanager.recuperarcorazon2();
        }
        if (_vida == 30.0f)
        {
            _uimanager.recuperarcorazon3();
        }

    }
    public void sumapuntaje(int sumapunt)
    {
        _puntaje = _puntaje + sumapunt;
        if (_puntaje >=  100.0f)
        {
            habilitarmeta();


    }
            


    }
    public void habilitarmeta()
    {

        _meta.SetActive(true);


    }
   
}