using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera2 : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;

    public void Change()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }
}
