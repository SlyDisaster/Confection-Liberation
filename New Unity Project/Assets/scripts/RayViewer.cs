using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayViewerComplete : MonoBehaviour
{

    public float weaponRange = 50f;                       // Distance in Unity units over which the Debug.DrawRay will be drawn

    private Camera fpsCam;                                // Holds a reference to the first person camera

    // Start is called before the first frame update
    void Start()
    {
        // Get and store a reference to our Camera by searching this GameObject and its parents
        fpsCam = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // Create a vector at the center of our camera's viewport
        Vector3 lineOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        // Draw a line in the Scene View  from the point lineOrigin in the direction of fpsCam.transform.forward * weaponRange, using the color green
        Debug.DrawRay(lineOrigin, fpsCam.transform.forward * weaponRange, Color.green);
    }
}

