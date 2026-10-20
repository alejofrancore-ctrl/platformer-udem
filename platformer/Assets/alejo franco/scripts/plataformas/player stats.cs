
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public class playerstats : MonoBehaviour
{
    [SerializeField] private float _vida =30.0f;
    [SerializeField] private Uimanager _uimanager;
    [SerializeField] private float _puntaje=0f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public void restarvida(int daño)
{
    _vida =_vida-daño;
    if(_vida==20.0f)
{
    _uimanager.quitarcorazon3();
}
if(_vida==10.0f)
{
    _uimanager.quitarcorazon2();
}
if(_vida<=0)
{
    _uimanager.quitarcorazon1();
}
}
public void sumarvida(int salud)
{
    _vida =_vida+salud;
    if(_vida==20.0f)
    {
        _uimanager.recuperarcorazon2();
    }
    if(_vida==30.0f)
    {
        _uimanager.recuperarcorazon3();
    }

}
public void sumapuntaje(int sumapunt)
{
    _puntaje=_puntaje+sumapunt;
}

}

