using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _fallVelocity = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<CharacterController>().Move(Vector3.down *  _fallVelocity * Time.deltaTime);  
    }
}
