using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectil;
    public Transform posicionDisparo;
    public float distanciVista = 1f;
    public LayerMask layerMask;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        var hit = Physics2D.RaycastAll(transform.position, Vector2.left, distanciVista, 
            layerMask);
        //Debug.Log(hit.Length >= 1);
        anim.SetBool("detecte", hit.Length >= 1);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left 
            * distanciVista);
    }

    public void Disparar()
    {
        var nuevoProjectil = Instantiate(projectil, posicionDisparo.position
            ,Quaternion.identity);

        var projectilRigi = nuevoProjectil.GetComponent<Rigidbody2D>();
        projectilRigi.AddForce(Vector2.left * 200);
        Destroy(nuevoProjectil, 5f);
    }
}
