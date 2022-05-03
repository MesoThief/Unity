using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseController : MonoBehaviour
{
    public float speed = 5000.0f;
    public float rotateSpeed = 10.0f;

    /*private Vector3 movePos = Vector3.zero;
    private Vector3 moveDir = Vector3.zero;*/

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, 100))
            {
                agent.destination = hit.point;
                /*movePos = raycastHit.point;
                moveDir = movePos - transform.position;*/
            }
        }

        /*Vector3 newDir = Vector3.RotateTowards(
            transform.forward,
            moveDir,
            rotateSpeed * Time.deltaTime,
            0.0f
        );
        transform.rotation = Quaternion.LookRotation(newDir);*/
        /*transform.position = Vector3.MoveTowards(
            transform.position,
            movePos,
            speed * Time.deltaTime
        );*/

    }
}
