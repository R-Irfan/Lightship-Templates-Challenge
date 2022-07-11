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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pamper() 
    {
        Debug.Log("Set Anim");
        anim.ResetTrigger("ShakeHand");
        anim.ResetTrigger("Scold");
        anim.ResetTrigger("Travel");
        anim.ResetTrigger("Pamper");
        anim.SetTrigger("Pamper");
    }

    public void ShakeHand()
    {
        Debug.Log("Set Anim");
        anim.SetTrigger("ShakeHand");
        anim.ResetTrigger("Scold");
        anim.ResetTrigger("Travel");
        anim.ResetTrigger("Pamper");
        anim.ResetTrigger("Pamper");
    }
    public void Travel()
    {
        Debug.Log("Set Anim");
        anim.ResetTrigger("ShakeHand");
        anim.ResetTrigger("Scold");
        anim.SetTrigger("Travel");
        anim.ResetTrigger("Pamper");
        anim.ResetTrigger("Pamper");
    }
    public void Scold()
    {
        Debug.Log("Set Anim");
        anim.ResetTrigger("ShakeHand");
        anim.SetTrigger("Scold");
        anim.ResetTrigger("Travel");
        anim.ResetTrigger("Pamper");
        anim.ResetTrigger("Pamper");
    }



}
