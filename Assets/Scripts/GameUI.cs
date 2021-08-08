using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] GameObject GameOverScreen;
    [SerializeField] GameObject GameWinScreen;
    public GameObject NoPass;
    public GameObject PauseScreen;
    public GameObject Interact;
    public Text InteractText;
    public Text ItemText;
    public float currentTime = 0f;
    public float startTime = 200f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = Time.time;
        //GameStatus.location = "Library";
        //Cursor.lockState = CursorLockMode.Confined;
        
    }

    void Awake()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.ITEM_PICKUP_OVERLAY_ON, this.SeeItem);
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.ITEM_PICKUP_OVERLAY_OFF, this.NoItem);
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.ON_WIN_GAME, this.SendStatus);
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.ITEM_TO_INVENTORY, this.itemInventory);
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.USED_ITEM, this.useItem);
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.NO_TOYS, this.goAway);
        //EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.NO_TOYS, this.goAway);

    }


    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.FindShoe.ON_WIN_GAME);
    }
    // Update is called once per frame
    void Update()
    {
        if (!PauseScreen.active && !GameWinScreen.active)
        {
            startTime -= 1 * Time.deltaTime;
            GameStatus.time = startTime;
            //timerText.text = startTime.ToString("0.0");
            if (startTime <= 0)
            {
                startTime = 0;
                EventBroadcaster.Instance.PostEvent(EventNames.FindShoe.ON_GAME_OVER);
                GameOver();
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                PauseScreen.SetActive(true);
            }
            if(Input.GetKey("e") && InteractText.text == "Interact with /nDog" && ItemText.text == "")
            {
                goAway();
            }
        }
    }


    public void GameOver()
    {
        //Cursor.lockState = CursorLockMode.Confined;
        GameOverScreen.SetActive(true);
        
    }

    public void SendStatus()
    {
        GameStatus.time = startTime;
        GameWinScreen.SetActive(true);
    }

    private void SeeItem(Parameters parameters)
    {
        string interactText = "Interact with \n" + parameters.GetStringExtra("item", "SomeItem");
        Interact.SetActive(true);
        InteractText.text = interactText;
        
    }

    public void NoItem()
    {
        Interact.SetActive(false);
    }

    public void itemInventory()
    {
        ItemText.text = "Dog Toy";
    }

    public void useItem()
    {
        ItemText.text = "";
    }

    public void goAway()
    {
        this.StartCoroutine(this.ShowHide(5.0f));
        
    }

    public IEnumerator ShowHide(float secs)
    {


        NoPass.SetActive(true);
        yield return new WaitForSeconds(secs);
        NoPass.SetActive(false);
        

        
    }
}
