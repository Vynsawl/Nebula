using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPressure : MonoBehaviour {

    private Material nebulaMat;
    private ReadOneArduinoValueExample arduino;
    public float airPressure;


    // Start is called before the first frame update
    void Start()
    {
        nebulaMat = gameObject.GetComponent<MeshRenderer>().sharedMaterial;
        arduino = FindObjectOfType<ReadOneArduinoValueExample>();
        
    }

    // Update is called once per frame
    void Update()
    {
        airPressure = arduino.value;
        nebulaMat.SetFloat("_NoiseScale", arduino.value);


    }
}
