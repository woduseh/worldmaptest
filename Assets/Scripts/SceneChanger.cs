using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public Waypoint Load;
    
    public void ChangeGameScene()
    {
        string gameScene = Load.SceneToLoad;
        SceneManager.LoadScene(gameScene);
    }
}
