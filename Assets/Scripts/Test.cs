using UnityEngine;

public class Test : MonoBehaviour {
    
    Vector3 velocity;
    Vector3 acceleration;
    Vector3 clickedPos;

    Vector3 lastPos = Vector3.zero;

    bool clicked = false;

    // Use this for initialization
    void Start()
    {
        velocity = new Vector3(Random.Range(0.1f, 1.0f), Random.Range(0.1f, 1.0f), Random.Range(0.1f, 1.0f));
        acceleration = new Vector3(0.0f, 0.0f, 0.0f);
        lastPos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(velocity);
        if (Input.GetMouseButtonDown(0))
        {
            clicked = true;
            clickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (clicked)
        {
            acceleration = (clickedPos - transform.position).normalized * 0.1f;
            velocity += acceleration;
            transform.position += velocity;
            lastPos = Input.mousePosition;
        }
    }
}
