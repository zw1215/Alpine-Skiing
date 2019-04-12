using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Vector2 velocity = new Vector2(2, 2);
    private int direction = 1;
    private SpriteRenderer sr;
    public Sprite idle;
    
    public Sprite acc;
    public Sprite crouch;
    public Sprite die;
    public Sprite start;
    private bool started = false;
    private Rigidbody2D rb;

   

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        sr.sprite = start;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down"))
        {
            started = true;
            sr.sprite = acc;
            velocity[1] = Mathf.Lerp(velocity[1], -4f, 0.4f);
            velocity[0] = Mathf.Lerp(velocity[0], 0, 0.6f);
        }
        if (started == false)
        {
            return;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1;
            sr.sprite = crouch;
            velocity[0] = Mathf.Lerp(0.7f * direction, 2f * direction, 0.4f);
            velocity[1] = Mathf.Lerp(-1f, -1.7f, 0.3f);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1;
            sr.sprite = crouch;
            sr.flipX = false;
            velocity[0] = Mathf.Lerp(0.7f * direction, 2f * direction, 0.4f);
            velocity[1] = Mathf.Lerp(-1.0f, -1.7f, 0.3f);

        }
        if (Input.anyKey == false)
        {
            sr.sprite = idle;
            velocity[0] = Mathf.Lerp(velocity[0], 2 * direction, 0.1f);
            velocity[1] = Mathf.Lerp(velocity[1], -2f, 0.1f);
        }
        if (direction == 1 && sr.flipX != true)
        {
            sr.flipX = true;
        }



        rb.MovePosition(rb.position + velocity * Time.deltaTime);

    }
}
