using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum type { kýrmýzý, turkuaz, sarý, bordo, yeþil }
public class Gem : MonoBehaviour
{

    [SerializeField] private float followSpeed;
    public type _type;


    public void UpdateGemPosition(Transform followedGem, bool isFollowStart)
    {   
        StartCoroutine(StartFollowingToLastGemPosition(followedGem, isFollowStart));
    }

    IEnumerator StartFollowingToLastGemPosition(Transform followedGem, bool isFollowStart)
    {

        while (isFollowStart)
        {
            yield return new WaitForEndOfFrame();
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, followedGem.position.x, followSpeed * Time.deltaTime),
                transform.position.y,
                Mathf.Lerp(transform.position.z, followedGem.position.z, followSpeed * Time.deltaTime));
        }
    }
}
