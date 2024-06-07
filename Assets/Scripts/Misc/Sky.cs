    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEditor;

    public class Sky : MonoBehaviour
    {

        public float speed = 0.5f;

        public Material customSkyboxMaterial; // Assign your custom skybox material in the inspector
        //public LightingSettings lightingSettings;

    void Start()
    {
            RenderSettings.skybox = customSkyboxMaterial;
    }

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*speed);
    }
}