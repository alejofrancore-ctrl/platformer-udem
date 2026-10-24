
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
    [SerializeField] private Text _textopuntaje;
    
    [SerializeField] private float _tiempoinvencible = 0f;

    public void Start()
    {
        ActualizarPuntaje();
        _tiempoinvencible = 0;
    }
    public void Update()
    {
        if (_tiempoinvencible >0)
        {
            _tiempoinvencible -= Time.deltaTime;
            if (_tiempoinvencible <=0)
            {
                _tiempoinvencible =0;
            }

        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void restarvida(int daño)
    {
        if (_tiempoinvencible > 0)
        {
            return;
        }
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
        ActualizarPuntaje();
        if (_puntaje >=  10.0f)
        {
            
            habilitarmeta();


    }
            


    }
    public void habilitarmeta()
    {

        _meta.SetActive(true);


    }
    public void ActualizarPuntaje()
    {
        _textopuntaje.text = "= " + _puntaje;
    }
    public void SerInvencible(float duracion)
    {
        _tiempoinvencible = duracion;
    }
   
}