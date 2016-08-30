using UnityEngine;
using System.Collections;

public class cursor : MonoBehaviour
{
    //this class is for the cursor
    //it works by getting the actual cursor postion X,Y and then translating it into a vector3(targetpos)
    //then the in game cursor object follows that vector3(targetpos) at the speed set the float.
    
    private float speed = 100f;
    private Vector3 targetPos;


    void Start()
    {
        targetPos = transform.position;
    }
    void Update()
    {
            float distance = transform.position.z - Camera.main.transform.position.z;
            targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            targetPos = Camera.main.ScreenToWorldPoint(targetPos);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}