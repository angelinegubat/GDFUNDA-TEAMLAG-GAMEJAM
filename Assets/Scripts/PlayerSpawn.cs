using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBroadcaster.Instance.AddObserver("SPAWN_PLAYER", this.summon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void summon()
    {
        //spawn player
    }
}
