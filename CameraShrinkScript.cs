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
        hyp = 100 / Mathf.Sqrt(hyp);
        print(hyp);
        float size_sphere = 8;
        gameObject.transform.localScale = new Vector3(hyp*size_sphere, hyp*size_sphere, hyp*size_sphere);
    }
}
