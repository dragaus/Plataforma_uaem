using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config", menuName = "ScriptableUAEM/GameConfig", order = 1)]
public class GameConfig : ScriptableObject
{
    public enum Personaje { Ranuto, Vudito }

    public Personaje personajeSeleccionado;
}
