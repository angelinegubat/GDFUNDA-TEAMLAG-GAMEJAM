using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenResults : MonoBehaviour
{

    public Text timer;
    public Text Location;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = GameStatus.time.ToString("0.0") + " Seconds";
        Location.text = GameStatus.location;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
