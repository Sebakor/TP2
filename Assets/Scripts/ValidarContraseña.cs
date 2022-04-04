using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    string contraseñaUsr;
    public Text ingresoUsr;
    public Text textoMensaje;
    public GameObject cartelMensaje;


    // Start is called before the first frame update
    void Start()
    {
        contraseñaCorrecta = "12345";
        cartelMensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        contraseñaUsr = ingresoUsr.text;
        if (contraseñaUsr == contraseñaCorrecta)
        {
            cartelMensaje.SetActive(true);
            textoMensaje.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }   
        else
        {
            cartelMensaje.SetActive(true);
            textoMensaje.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
