using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REGRESAR_NIVEL_1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        LevelLoader.LoadLevel("Nivel_01");
    }
}
