using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool isGraunder;

    void OnCollisionEnter()
    {
        isGraunder = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isGraunder)
            isGraunder=false;
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
        }
}
