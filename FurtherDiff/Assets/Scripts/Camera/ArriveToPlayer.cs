using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArriveToPlayer : MonoBehaviour
{

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arrivePlayer();
    }

    private void arrivePlayer()
    {
        transform.position = player.position;

    }

}
