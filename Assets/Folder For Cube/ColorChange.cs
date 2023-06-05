using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
  public void ChangeColorWhite()
    {
        GetComponent<Renderer>().material.color = new Color(1,1,1);

    }
    public void ChangeColorBlack()
    {
        GetComponent<Renderer>().material.color = new Color(0,0,0);

    }
}
