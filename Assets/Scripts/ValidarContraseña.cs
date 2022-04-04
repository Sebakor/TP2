using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    string contraUser;
    public Text ingresoUser;
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
        
    }

    public void validarContraseña()
    {
        contraUser = ingresoUser.text;
        if (contraUser == contraseñaCorrecta)
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
