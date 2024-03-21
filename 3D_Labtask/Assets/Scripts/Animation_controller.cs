using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_controller : MonoBehaviour
{

    float speed = 4, rotation_speed = 80, graviti = 8, rotation = 0f;
    Vector3 ArahPergerakan = Vector3.zero;
    CharacterController Kawalan;
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Kawalan = GetComponent<CharacterController>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Kawalan.isGrounded) // Jika karakter menyentuh plane
        {
            if (Input.GetKey(KeyCode.W)) // menerima kekunci W di tekan
            {
                ArahPergerakan = new Vector3(0, 0, 1); // posisi z adalah bertambah 1
                ArahPergerakan *= speed; // menetapkan kelajuan
                ArahPergerakan = transform.TransformDirection(ArahPergerakan); //menetapkan arah

                
            }
            if (Input.GetKeyUp(KeyCode.W)) // menerima kekunci W di lepaskan
            {
                ArahPergerakan = new Vector3(0, 0, 0); 
            }
            rotation += Input.GetAxis("Horizontal") * rotation_speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rotation, 0); 
        }
    }
}
