using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeReference]
    [Range(-1f, 1f)]
    float velocidad;
    float direccion = 0;

    [SerializeReference]
    float fuerzaBrinco;
    bool estoyBrincando = false;

    Rigidbody2D rigi;

    Animator anim;
    SpriteRenderer rendi;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rendi = GetComponent<SpriteRenderer>();
        rigi = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(estoyBrincando)
        {
            rigi.AddForce(Vector2.up * fuerzaBrinco);
            estoyBrincando = false;
        }

        anim.SetFloat("velocidad", rigi.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        direccion = 0;

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direccion = 1;
            rendi.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direccion = -1;
            rendi.flipX = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            estoyBrincando = true;
        }

        anim.SetFloat("dir", Mathf.Abs(direccion));

        transform.position += direccion *velocidad * Time.deltaTime * Vector3.right;
    }
}
