using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();

    const int JUMP_VALUE = 7;
  
    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector3.right;
        }
        if(Input.GetKey(KeyCode.Space) && IsGrounded()){
            inputVector += Vector3.up * JUMP_VALUE;
        }
        OnMove?.Invoke(inputVector);
    }

    private Boolean IsGrounded(){
        float distanceToTheGround = GetComponent<Collider>().bounds.extents.y;
        return Physics.Raycast(transform.position, -Vector3.up, distanceToTheGround + 0.1f);
    }
}
