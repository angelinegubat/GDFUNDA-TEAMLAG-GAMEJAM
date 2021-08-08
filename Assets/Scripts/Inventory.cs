using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    [SerializeField] private int dogToys = 0;
    [SerializeField] GameObject theToy;

    // Start is called before the first frame update
    void Start()
    {
        EventBroadcaster.Instance.AddObserver("ITEM_TO_INVENTORY", this.toyAcquired);
        EventBroadcaster.Instance.AddObserver("USED_ITEM", this.toyGiven);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver("ITEM_TO_INVENTORY");
        EventBroadcaster.Instance.RemoveObserver("USED_ITEM");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void toyAcquired()
    {
        dogToys++;
        theToy.SetActive(false);
    }

    void toyGiven()
    {
        if (dogToys > 0)
        {
            dogToys--;
            EventBroadcaster.Instance.PostEvent("DOG_SATISFIED"); 
        }
        else
        {
            EventBroadcaster.Instance.PostEvent("NO_TOYS");
        }
    }
}
