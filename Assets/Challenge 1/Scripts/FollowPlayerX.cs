using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;
    [SerializeField] float position_x;
    [SerializeField] float position_y;
    [SerializeField] float position_z;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(position_x, position_y, position_z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
