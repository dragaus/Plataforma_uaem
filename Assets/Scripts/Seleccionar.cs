using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seleccionar : MonoBehaviour
{
    public GameConfig config;
    public GameConfig.Personaje personajeASeleccionar;

    private void OnMouseDown()
    {
        // Poner en nuestra configuracion el personaje seleccionado
        config.personajeSeleccionado = personajeASeleccionar;

        // Cambiar escena e ir a la escena 1
        SceneManager.LoadScene(1);
    }
}
