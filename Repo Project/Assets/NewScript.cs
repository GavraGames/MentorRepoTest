using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    //What a great script!

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(1,2,3);
        //Better startttttt
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
