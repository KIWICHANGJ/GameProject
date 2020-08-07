using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class hookmove : MonoBehaviour
{
    protected Joybutton joybutton;
    private Joystick joystick;
    public float Hori;
    public float Vert;
    private Vector3 offset;
    private bool isgo = false;
    public GameObject player;
    public float going;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        if (!isgo&&Input.GetKey(KeyCode.A))
        {
            Hori = joystick.Horizontal;
            Vert = joystick.Vertical;
            going = 600;
            isgo = true;
        }
        if(going>0)
        {
            going -=1;
            rigidbody.velocity = new Vector3(Hori * 10f,
                                         rigidbody.velocity.y,
                                         Vert* 10f);
        }
        else
        {
            isgo = false;
            transform.position = player.transform.position + offset;
            //爪子回到身上
        }
    }

    
}

