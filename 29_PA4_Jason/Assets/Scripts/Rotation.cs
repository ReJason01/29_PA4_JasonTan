using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float spd;
    // Start is called before the first frame update
    void Start()
    {
 //Version1
        if(spd ==0)
        {
            spd = 300;
        }
=======
        
 //master
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * spd * Time.deltaTime);
    }
}


