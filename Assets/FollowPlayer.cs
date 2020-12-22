
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        //transform with lower cases follows the object of this script
        // Debug.Log(player.position);
        // transform.position = player.position; // first person view
        transform.position = player.position + offset;
    }
}
