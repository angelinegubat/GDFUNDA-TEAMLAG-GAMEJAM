using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoespin : MonoBehaviour
{
    public GameObject Shoe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoe.transform.Rotate(new Vector3(0f, 50f, 0f) * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
