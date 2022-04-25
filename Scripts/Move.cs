using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float rightLeftSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * rightLeftSpeed * Time.deltaTime;
        //float dikeyEksen = Input.GetAxis("Vertical") * rightLeftSpeed * Time.deltaTime;
        transform.Translate(yatayEksen, 0, forwardSpeed * Time.deltaTime);


    }
}
