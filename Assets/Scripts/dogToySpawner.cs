using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogToySpawner : MonoBehaviour
{

    [SerializeField] private GameObject toyCopy;
    [SerializeField] private GameObject area1;
    [SerializeField] private GameObject area2;
    [SerializeField] private GameObject area3;
    [SerializeField] private GameObject area4;
    /*
    [SerializeField] private GameObject area5;
    [SerializeField] private GameObject area6;
    [SerializeField] private GameObject area7;
    [SerializeField] private GameObject area8;
    [SerializeField] private GameObject area9;
    [SerializeField] private GameObject area10;
    [SerializeField] private GameObject area11;
    [SerializeField] private GameObject area12;
    */

    // Start is called before the first frame update
    void Start()
    {
        //toyCopy.SetActive(false);
        int RNG =  Random.Range(1, 5);

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
        }

        //GameObject obj = GameObject.Instantiate(this.toyCopy, this.transform);
        //obj.SetActive(true);
        toyCopy.transform.localPosition = toyPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
