using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    public int camOffsetY = 10;
    public int camOffsetZ = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + (Vector3.up * camOffsetY) + (Vector3.back * camOffsetZ);
    }
}
