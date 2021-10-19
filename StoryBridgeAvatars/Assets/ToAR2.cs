using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToAR2 : MonoBehaviour
{
    public void ARScene_bought()
    {
        SceneManager.LoadScene("AR Camera_unlocked");
    }
}
