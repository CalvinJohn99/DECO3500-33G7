using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;

    public void Change() 
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }
}
