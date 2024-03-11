using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float rotateSpeed = 3f;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.2f, 1.0f, 0.1f, 0.7f);

        /*
        Material matTrans = new Material(Shader.Find("Transparent/Diffuse"));
        GetComponent<Renderer>().material = matTrans;
        */
    }
    
    void Update()
    {
        transform.Rotate(10.0f * rotateSpeed * Time.deltaTime, 1.0f, 3.0f);
        transform.position = new Vector3(2, 3, 2);
        transform.localScale = Vector3.one * 4.7f;
        
            
    }
}
