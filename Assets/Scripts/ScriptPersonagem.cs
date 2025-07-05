using UnityEngine;

public class ScriptPersonagem : MonoBehaviour
{
    public Vector2 input;
    public float MoveSpeed=5; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (input.x != 0)
        {
            input.y = 0;
        }
            transform.position += (Vector3)(input * MoveSpeed * Time.deltaTime);
        
    }
}
