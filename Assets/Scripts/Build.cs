using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{

    [SerializeField] private Material material;

    private float progress;
 

    private void Update()
    {
        float timeToComplete =3f;
        progress += Time.deltaTime / timeToComplete;

        material.SetFloat("_progress", progress);

        progress  = progress % 1f;
    }
}
