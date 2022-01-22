using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casilla : MonoBehaviour
{

    public Material ColorCasilla;
    public int NumeroCasilla = 1;


    private void OnMouseDown()
    {
        print(NumeroCasilla.ToString());
    }
    public void PonerColor(Material color_)
    {
        GetComponent<MeshRenderer>().material = color_;
        ColorCasilla = color_;
    }
}
