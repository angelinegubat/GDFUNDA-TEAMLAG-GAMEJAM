using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawn : MonoBehaviour
{
    [SerializeField] private GameObject Dog;
    [SerializeField] private GameObject area1;
    [SerializeField] private GameObject area2;
    [SerializeField] private GameObject area3;
    [SerializeField] private GameObject area4;
    [SerializeField] private GameObject area5;
    private float tick;
    private float spawntick = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        this.tick += Time.deltaTime;
        if(this.tick >= spawntick)
        {
            Spawn();
            this.tick = 0.0f;
        }
        
    }

    void removeDog()
    {
        //Eventbroadcast the UI to tell that: "The dog is satisfied"
        Dog.SetActive(false);
        this.tick = 0.0f;
    }

    void notoys()
    {
        //Eventbroadcast the UI to tell that: "The dog will not move, maybe something can distract it"
    }

    public void Spawn()
    {
        Dog.SetActive(false);
        int RNG = 4;

        Vector3 toyPos = this.Dog.transform.localPosition;
        Vector3 areaPos;

        switch (RNG)
        {
            case 1:
                areaPos = this.area1.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
            case 2:
                areaPos = this.area2.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
            case 3:
                areaPos = this.area3.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
            case 4:
                areaPos = this.area4.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
            case 5:
                areaPos = this.area5.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
        }

        //GameObject obj = GameObject.Instantiate(this.Dog, this.transform);
        //obj.SetActive(true);
        Dog.transform.localPosition = toyPos;

        EventBroadcaster.Instance.AddObserver("DOG_SATISFIED", this.removeDog);
        //EventBroadcaster.Instance.AddObserver("NO_TOYS", this.notoys);

        Dog.SetActive(true);
    }
}
