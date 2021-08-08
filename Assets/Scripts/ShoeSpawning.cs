using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeSpawning : MonoBehaviour
{
    // Start is called before the first frame update

    struct shoeSpawn
    {
        public int factor1;
        public int factor2;
    }
    void Start()
    {
        EventBroadcaster.Instance.AddObserver("SHOE_SPAWN", this.summonShoe);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver("SHOE_SPAWN");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void summonShoe() {

        shoeSpawn shoeRNG;

        shoeRNG.factor1 = Random.Range(1, 10);
        shoeRNG.factor2 = Random.Range(1, 5);
    }
}
