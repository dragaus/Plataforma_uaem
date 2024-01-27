using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public bool sigueX;
    public bool sigueY;

    public float minOffsetX;
    public float maxOffsetX;

    public float minXPos;
    public float maxXPos;

    public float minOffsetY;
    public float maxOffsetY;

    public float minYPos;
    public float maxYPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = target.position - transform.position;

        Vector3 newPos = transform.position;

        if(sigueX)
        {
            if(offset.x < minOffsetX)
            {
                newPos.x = target.position.x - minOffsetX;
            }
            else if (offset.x > maxOffsetX)
            {
                newPos.x = target.position.x - maxOffsetX;
            }

            newPos.x = Mathf.Clamp(newPos.x, minXPos, maxXPos);
        }

        if(sigueY)
        {
            if(offset.y < minOffsetY)
            {
                newPos.y = target.position.y - minOffsetY;
            }
            else if (offset.y > maxOffsetY)
            {
                newPos.y = target.position.y - maxOffsetY;
            }

            newPos.y = Mathf.Clamp(newPos.y, minYPos, maxYPos);
        }

        transform.position = newPos;
    }
}
