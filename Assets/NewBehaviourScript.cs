using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public string codigo;
    public int CantidadGramos;
    private float precio;
    private float PrecioPorKilo = 1.25f;

    void Start()
    {
        if(CantidadGramos < 250 || CantidadGramos > 3000)
        {
            Debug.Log("Ingrese una cantidad de acuerdo a nuestra politica de servicio");
            return;
        }
        else if (codigo == "FRU" || codigo == "fru")
        {
            precio = (CantidadGramos * PrecioPorKilo) - ((CantidadGramos * PrecioPorKilo) /10 );
            Debug.Log(precio);
        }
        else if (codigo == "DDL" || codigo == "ddl")
        {
            precio = CantidadGramos * PrecioPorKilo;
            Debug.Log(precio);
        }
        else if (codigo == "CHO" || codigo == "cho")
        {
            precio = CantidadGramos * PrecioPorKilo;
            Debug.Log(precio);
        }
        else
        {
            Debug.Log("El codigo que usted ingreso no es valido");
            return;
        }

        

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
