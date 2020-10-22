using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cykacontroller : MonoBehaviour
{
    [SerializeField]
    private float _movespeed = 5f;

    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        controller.Move(direction * _movespeed * Time.deltaTime);
    }
}
