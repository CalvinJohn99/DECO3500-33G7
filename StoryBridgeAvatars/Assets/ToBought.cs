using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBought : MonoBehaviour
{
    public void BoughtScene()
    {
        SceneManager.LoadScene("RewardStore_bought");
    }
}
