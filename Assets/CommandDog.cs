using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandDog : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pamper() 
    {
        Debug.Log("Set Anim");
        anim.Play("Pamper");
    }

    public void ShakeHand()
    {
        Debug.Log("Set Anim");
        anim.Play("ShakeHand");
    }
    public void Travel()
    {
        Debug.Log("Set Anim");
        anim.Play("Travel");
    }
    public void Scold()
    {
        Debug.Log("Set Anim");
        anim.Play("Scold");
    }



}
