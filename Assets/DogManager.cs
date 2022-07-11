using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogManager : MonoBehaviour
{
    [SerializeField]
    GameObject dog, hoverDog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Follow() 
    {
        dog.SetActive(false);
        hoverDog.SetActive(true);
        hoverDog.GetComponent<DogBoardController>().follow = true;
    }
}
