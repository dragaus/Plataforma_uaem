using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerSelector : MonoBehaviour
{
    public GameConfig gameConfig;
    public GameObject[] personajes;
    public CameraFollow camara;

    // Start is called before the first frame update
    void Start()
    {
        //type-casting
        int indice = (int)gameConfig.personajeSeleccionado;

        GameObject personaje = Instantiate(personajes[indice]);

        //Target es de tipo transaform
        camara.target = personaje.transform;
    }
}
