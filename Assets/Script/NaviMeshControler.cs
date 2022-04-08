using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaviMeshControler : MonoBehaviour
{
    private NavMeshAgent naviMeshAgent;
    private Camera mainCamera;
    [SerializeField]
    private GameObject markPrefab;

    private void Start()
    {
        naviMeshAgent = GetComponent<NavMeshAgent>();
        mainCamera = Camera.main;
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 pos = new Vector3(0.02f,0.02f,0.02f);
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit));
            {
                GameObject mark = Instantiate(markPrefab,hit.point + pos, Quaternion.Euler(270, 0, 0));
                Destroy(mark, 0.25f);
                naviMeshAgent.SetDestination(hit.point);
            }
        }
    }
    
}
