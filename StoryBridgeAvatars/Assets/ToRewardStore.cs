using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRewardStore : MonoBehaviour
{
    public void RewardScene()
    {
        SceneManager.LoadScene("RewardStore");
    }
}
