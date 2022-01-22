using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCasillas : MonoBehaviour
{

   public GameObject CasillaPrefab;

    public int x;
    public int y;

    public Material blanco;
    public Material negro;

   public void Crear()
    {
        for(int i=0; i<y; i++)
        {
            for(int j=0; j<x; j++)
            {
                GameObject casillaTemp = Instantiate(CasillaPrefab, new Vector3(i, 0, j), Quaternion.identity);

                if ((i + j)% 2 == 0)
                    casillaTemp.GetComponent<Casilla>().PonerColor(negro);
                else
                    casillaTemp.GetComponent<Casilla>().PonerColor(blanco);
            }   
        }


    }
}
