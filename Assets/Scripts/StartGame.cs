using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject menu;
    public GameObject loadingbar;
    public Image loading;
    AsyncOperation sceneToLoad;
    
    // Start is called before the first frame update
    void Start()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.ON_START_GAME, this.onCLickStart);
        loadingbar.SetActive(false);

    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.FindShoe.ON_START_GAME);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void onCLickStart()
    {
        HideMenu();
        ShowLoadingScreen();
        sceneToLoad = SceneManager.LoadSceneAsync("GameLevel");
        StartCoroutine(LoadingScreen());
        
    }


    public void HideMenu()
    {
        menu.SetActive(false);
    }

    public void ShowLoadingScreen()
    {
        loadingbar.SetActive(true);
    }
    IEnumerator LoadingScreen()
    {
        float totalProgress = 0;
        //Iterate through all the scenes to load
         
            while (!sceneToLoad.isDone)
            {
                //Adding the scene progress to the total progress
                totalProgress += sceneToLoad.progress;
                //the fillAmount needs a value between 0 and 1, so we devide the progress by the number of scenes to load
                loading.fillAmount = totalProgress;
                yield return null;
            }
    }
}


