using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ02 : MonoBehaviour
{
    //2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
    public int producto1;
    public int producto2;
    public int producto3;
    public int montodedinero;
    int total;
    void Start()
    {
        total = producto1 + producto2 + producto3;
        if (montodedinero < total)
        {
            Debug.Log("La suma de los productos supera el monto. Te faltan $" + (total - montodedinero) + ".");
        }
        else
        {
            Debug.Log("La suma de los productos no supera el monto. Te sobran $" + (montodedinero - total) + ".");
        }
    }

    void Update()
    {
        
    }
}
