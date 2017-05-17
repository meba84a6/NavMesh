using UnityEngine;
using System.Collections;

public class PlayerNavigation : MonoBehaviour {

    public Camera cam;
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    int myTestint = 90;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                navMeshAgent.SetDestination(hit.point);
                if (navMeshAgent.isActiveAndEnabled)
                {
                    Debug.Log("ANIMIMATE");
                }
            }
        }
	}
}
