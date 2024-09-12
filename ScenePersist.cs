using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    void Awake()
    {
        int numScenePersist = FindObjectsOfType<GameSession>().Length;
        if (numScenePersist > 1)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetScenePersist() 
    {
        Destroy(gameObject);
    }
}
