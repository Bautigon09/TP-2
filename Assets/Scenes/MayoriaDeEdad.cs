using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edad = 0;
    public Text miTexto;
    
    void Start()
    {
        if (edad >= 18)
    {
            miTexto.text = "Es mayor de edad";
        Debug.Log("Es mayor de edad");

    }
        else
    {
            miTexto.text = "No es mayor de edad";
            Debug.Log("Es menor de edad");
    }
    }

    
    void Update()
    {
        
    }
}
