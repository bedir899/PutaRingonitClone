using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObsCollider : MonoBehaviour
{
    Stack _stack;
    PlayerMove _playerMove;
    private Animator _anim;
    private void Awake()
    {
        DOTween.Init();
        
    }
    public void Start()
    {
        _playerMove = GetComponent<PlayerMove>();
        _anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Obstacle")
        {
            
            
            transform.DOMoveZ(transform.position.z-1, 1);
           // _stack.GemDoJump(3);
        }
        if (collision.gameObject.CompareTag("Stop"))
        {
            _playerMove.forwardSpeed = 0f;
            _playerMove.swerveSpeed = 0f;
            _anim.SetBool("came", true);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            
        }
    }
}
