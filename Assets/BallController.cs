using JetBrains.Annotations;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed = 2f;

    public void MoveBall(Vector3 input){
        sphereRigidbody.AddForce(input * ballSpeed);
    }

}