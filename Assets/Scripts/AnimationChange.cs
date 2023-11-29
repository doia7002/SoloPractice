using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("Run", false);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Run", true);
    }
}
