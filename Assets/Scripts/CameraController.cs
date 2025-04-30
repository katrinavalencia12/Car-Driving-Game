using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    public GameObject playerV;
    public Camera frontCamera;
    public Camera backCamera;
    public Vector3 offset = new Vector3(0, 4, 3);
    public Vector3 bOffset = new Vector3(0, 7, -4);
    public bool reverse = false;
    // Start is called before the first frame update
    void Start()
    {
        frontCamera.enabled = true;
        backCamera.enabled = false;
    }
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerV.transform.position + offset;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(reverse == false)
            {
                frontCamera.enabled = false;
                backCamera.enabled = true;
                reverse = true;
                offset = bOffset;
                transform.position = playerV.transform.position + offset;
                Debug.Log("slash pressed");
            }
            else
            {
                backCamera.enabled = false;
                frontCamera.enabled = true;
                reverse = false;
                offset = new Vector3(0, 4, 3);
                transform.position = playerV.transform.position + offset;
                Debug.Log("slash pressed");
            }
        }
    }
}
