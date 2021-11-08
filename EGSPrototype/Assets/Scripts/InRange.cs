using UnityEngine;
public class InRange : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] Transform target;
    [SerializeField] Transform pointer;
    
    Color gizmoColor = Color.magenta;

    void OnDrawGizmos ()
    {
        Color c = gizmoColor;
        c.a = 0.2f;
        Gizmos.color = c;
        
        Gizmos.DrawSphere(transform.position, radius);
    }


    void Update ()
    {
        float dist = Vector3.Distance(transform.position, target.position);
        Debug.Log(dist);
        
        // THIS ^ is the SAME AS THIS ...
        Vector3 diff = (target.position - transform.position);
        float mag = diff.magnitude;

        float sqMag = diff.sqrMagnitude;

        Vector3 dir = diff.normalized;
        pointer.position = transform.position + dir * radius;
        
        if (dist <= radius)
            gizmoColor = Color.green;
        else
            gizmoColor = Color.magenta;


        if (sqMag < radius * radius)
        {
            // SAME EXACT THING BUT WITOUT SQ ROOT
        }
        
    }
}