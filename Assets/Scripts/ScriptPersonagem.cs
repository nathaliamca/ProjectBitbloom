using UnityEngine;

public class ScriptPersonagem : MonoBehaviour
{
    public Vector2 input;
    public float MoveSpeed=5f;
    private Animator animator;
    public bool isMoving;
    void Start()
    {
        
    }
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        if (input.x != 0)
        {
            input.y = 0;
        }

        if (input != Vector2.zero)
        {
            isMoving = true;

            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
            transform.position += (Vector3)(input * MoveSpeed * Time.deltaTime);
        }
        else
        {
            isMoving = false;
        }
        animator.SetBool("isMoving", isMoving);

    }
}
