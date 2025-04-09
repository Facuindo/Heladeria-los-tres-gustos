using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaTresGustos : MonoBehaviour
{
    public string codigoGusto;
    public int gramosHelado;

    float precioPorMilGramos = 500;
    float precioTotal;
    float porcentajeDeDescuento;

    // Start is called before the first frame update
    void Start()
    {
        
        if (gramosHelado < 250 || gramosHelado > 3000)
        {
            Debug.Log("Cantidad de helado no valida");
            return;
        }
        if (codigoGusto == "CHO" || codigoGusto == "DDL")
        {
            porcentajeDeDescuento = 0;
            {
                porcentajeDeDescuento = 10;
            }
        }
        else if ( codigoGusto == "FRU")
        {
            porcentajeDeDescuento = 10;
        }
        else
        {
            Debug.Log("Codigo de gusto no valido");
            return;
        }
        precioTotal = gramosHelado * (precioPorMilGramos / 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
