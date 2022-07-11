using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBoardController : MonoBehaviour
{

    [SerializeField]
    Transform hoverTransform;

    Transform cam;

    public bool follow = false;



    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (follow) {

            transform.LookAt(Camera.main.transform);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

            transform.position = Vector3.Lerp(transform.position, hoverTransform.position, 0.33f);

            if (Vector3.Distance(transform.position, Camera.main.transform.position) > 3f)
            {
                Debug.Log("Set Position");
                transform.Translate(Vector3.forward * 1 * Time.deltaTime);

            }

        }

    }

    public void FollowPlayer()
    {

        follow = true;
        gameObject.SetActive(true);
    }

    public void UnfollowPlayer()
    {

        follow = false;
        gameObject.SetActive(false);
    }


}
