using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField]
    private float length, startpos;
    [SerializeField] bool checker;
    [SerializeField]private GameObject cam;
    [SerializeField]private float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = cam.transform.position.x * (1 - parallaxEffect);

        float distance = (cam.transform.position.x * parallaxEffect);
        transform.position = new UnityEngine.Vector3(startpos + distance, transform.position.y, transform.position.z);
        if (!checker){
            if (temp > (startpos + length)){
                startpos += 2*length;
            }
            else if (temp < (startpos - length)){
                startpos -= 2*length;
            }
        }
    }
}
