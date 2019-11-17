using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera cam;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray1 = new Ray();
        if(Input.GetMouseButtonDown(0))
        {
             ray1 = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(ray1.origin,ray1.direction,out hit,Mathf.Infinity))
            {
                agent.destination = hit.point;
            }

            Instantiate(particle,hit.point,particle.transform.rotation);
        }
           


    }
}
