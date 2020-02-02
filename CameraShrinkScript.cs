using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShrinkScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // shrink relative to camera position
        float hyp = Vector3.Distance(gameObject.transform.localPosition, Camera.main.transform.localPosition); // hypo
        // distance is closer, scale is bigger
        hyp = 8/ hyp;
        float size_sphere = 1;
        gameObject.transform.localScale = new Vector3(hyp*size_sphere, hyp*size_sphere, hyp*size_sphere);
    }
}
