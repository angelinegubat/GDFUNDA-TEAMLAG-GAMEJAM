using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogToySpawner2 : MonoBehaviour
{
    [SerializeField] private GameObject toyCopy;
    [SerializeField] private GameObject area1;
    [SerializeField] private GameObject area2;
    [SerializeField] private GameObject area3;
    [SerializeField] private GameObject area4;
    [SerializeField] private GameObject area5;
    [SerializeField] private GameObject area6;
    [SerializeField] private GameObject area7;
    [SerializeField] private GameObject area8;
    private float tick;
    private float spawntick = 30.0f;


    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    void Awake()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.FindShoe.USED_ITEM, this.toyUsed);
    }

    // Update is called once per frame
    void Update()
    {
        if (!toyCopy.active)
        {
            this.tick += Time.deltaTime;
            if (this.tick >= spawntick)
            {
                spawn();
                this.tick = 0.0f;
            }

        }
        
    }

    public void toyUsed()
    {
        this.tick = 0.0f;
    }



    public void spawn()
    {
        int RNG = 2;

        Vector3 toyPos = this.toyCopy.transform.localPosition;
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
            case 6:
                areaPos = this.area6.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
            case 7:
                areaPos = this.area7.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
            case 8:
                areaPos = this.area8.transform.localPosition;
                toyPos.x = areaPos.x;
                toyPos.y = areaPos.y;
                toyPos.z = areaPos.z;
                break;
        }

        //GameObject obj = GameObject.Instantiate(this.toyCopy, this.transform);
        // obj.SetActive(true);
        toyCopy.transform.localPosition = toyPos;
        toyCopy.SetActive(true);
    }
}
