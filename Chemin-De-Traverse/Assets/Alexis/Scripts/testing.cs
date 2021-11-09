using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testing : MonoBehaviour
{

    public int ligne, column;
    private void Start()
    {
        Grid grid = new Grid(ligne, column);
    }
}
