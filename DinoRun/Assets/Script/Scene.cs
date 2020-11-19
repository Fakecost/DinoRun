using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public static Scene instance;
    private int _nextSceneManager;
    private bool _break = false;
  
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        _nextSceneManager = SceneManager.GetActiveScene().buildIndex + 1;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                // Quit the application
                Application.Quit();
            }
        }

        if (SceneManager.GetActiveScene().name.Equals("EndScene")|| SceneManager.GetActiveScene().name.Equals("MenuScene"))
        {
            Score.instance.SetScore0();
            for (int i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    if (SceneManager.GetActiveScene().name.Equals("MenuScene"))
                    {
                        LoadNextScene();
                        Score.instance.Reset();
                    }
                    if (SceneManager.GetActiveScene().name.Equals("EndScene"))
                    {
                        SceneManager.LoadScene(0);
                    }
                }
            }
            if (Application.platform == RuntimePlatform.Android) {
        
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
            // Quit the application
            Application.Quit();
        }
    }

        }
        else if(SceneManager.GetActiveScene().name.Equals("PlayScene")&&_break == false)
        {
            Debug.Log("Hi");
            Score.instance.SetScore();
        }
        
       
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(_nextSceneManager);
    }

    public void breakScene()
    {
        _break = true;
    }

  
    
}
