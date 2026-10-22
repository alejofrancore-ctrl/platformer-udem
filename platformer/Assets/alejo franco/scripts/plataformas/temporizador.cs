using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    [SerializeField] private int _temporizador = 60;
    [SerializeField] private Text _contador;
    [SerializeField] private GameObject _gameover; 

    void Start()
    {
        Actualizartiempo();
        StartCoroutine(ContarSegundos());
    }

    private IEnumerator ContarSegundos()
    {
        while (_temporizador > 0)
        {
            yield return new WaitForSeconds(1f);
            _temporizador--;
            Actualizartiempo();

            if (_temporizador <= 0)
            {
                ActivarGameover();
            }
        }
    } 

    private void Actualizartiempo()
    {
        
        _contador.text = "= " + _temporizador;
    }

    private void ActivarGameover()
    {
        if (_gameover != null)
        {
            _gameover.SetActive(true); 
        }
        Time.timeScale = 0; 
    }

    
}