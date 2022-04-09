using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSetActive : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonClick;
    private void OnTriggerStay(Collider other)
    {
        NaviMeshControler naviMeshControler = other.GetComponent<NaviMeshControler>();
        if(naviMeshControler != null)
        {
            buttonClick.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        NaviMeshControler naviMeshControler = other.GetComponent<NaviMeshControler>();
        if (naviMeshControler != null)
        {
            buttonClick.SetActive(false);
        }
    }
}
