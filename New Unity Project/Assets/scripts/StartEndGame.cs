using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartEndGame : MonoBehaviour
{
   

    public void StartGame()
    {
        SceneManager.LoadScene("Map");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Start Screen");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
