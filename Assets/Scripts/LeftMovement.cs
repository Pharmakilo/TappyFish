


using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    BoxCollider2D box;
    float groundwidth;
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        groundwidth = box.size.x;
        Debug.Log(groundwidth);
    }

   
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if(transform.position.x <= -groundwidth)
        {
            transform.position = new Vector2(transform.position.x + 2 * groundwidth, transform.position.y);
        }
    }
}
