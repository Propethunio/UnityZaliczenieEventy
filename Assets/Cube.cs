using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    [SerializeField] Material material;

    private void Start() {
        material.color = SettingsManager.instance.GetColor();
    }
}