using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{

    StartGame controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStart()
    {
        
        SceneManager.LoadScene("GameLevel");
        //EventBroadcaster.Instance.PostEvent(EventNames.FindShoe.ON_START_GAME);
        //controller.onCLickStart();

    }

    public void ClickExit()
    {
        Application.Quit();
        //controller.onClickEnd();
    }
}
