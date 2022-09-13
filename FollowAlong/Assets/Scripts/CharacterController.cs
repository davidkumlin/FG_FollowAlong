using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody characterbody;
    [SerializeField] private float speed = 10f;

    // Update is called once per frame
    void Update()

    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }
;       if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

        private void Jump()
    {
        characterbody.AddForce(Vector3.up * 500f);
    }

}
