using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeReference]
    [Range(-1f, 1f)]
    float velocidad;
    float direccion = 0;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        direccion = 0;

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direccion = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direccion = -1;
        }

        anim.SetFloat("dir", Mathf.Abs(direccion));

        transform.position += direccion *velocidad * Time.deltaTime * Vector3.right;
    }
}
