using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;
    private void Update()
    {
        MethodClick();
    }
    private void MethodClick()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            playerObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
