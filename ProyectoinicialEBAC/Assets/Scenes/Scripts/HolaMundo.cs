using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola a ver que tal sale todo esto");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("Hijole algo salio muy mal mi Chavo");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Creo que todo esta saliendo bien");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("En Junio sale el DLC de Elden Ring");
    }

    private void LateUpdate()
    {
        Debug.LogWarning("Esperemos haya salido como tenia que ser");
    }
}