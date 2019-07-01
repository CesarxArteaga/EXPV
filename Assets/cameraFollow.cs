using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    private float xmin = 0;
    private float ymin = 0;
    private float xmax = -30;
    private float ymax = 10;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;
        
    }
}
