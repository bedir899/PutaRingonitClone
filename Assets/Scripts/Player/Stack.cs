using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class Stack : MonoBehaviour
{

    [SerializeField] private Vector3 _firstGemPos;
    [SerializeField] private Vector3 _currentGemPos;
    public Text _text;
   
    public List<GameObject> _gemList = new List<GameObject>();
    private int _gemListIndexCounter = 0;
    public Vector3 randomPosition;
    public Transform _gameOb;
  
    

    
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Gem gem))
        {
            
            _gemList.Add(other.gameObject);
            if (_gemList.Count == 1)
            {
                _firstGemPos = GetComponent<MeshRenderer>().bounds.max;
                _currentGemPos = new Vector3(other.transform.position.x, _firstGemPos.y, other.transform.position.z);
                other.gameObject.transform.position = _currentGemPos;
                _currentGemPos = new Vector3(other.transform.position.x, transform.position.y + 0.5f, other.transform.position.z);
                other.gameObject.GetComponent<Gem>().UpdateGemPosition(transform, true);
            }
            else if (_gemList.Count > 1)
            {
                other.gameObject.transform.position = _currentGemPos;
                _currentGemPos = new Vector3(other.transform.position.x, other.gameObject.transform.position.y + 0.3f, other.transform.position.z);
                other.gameObject.GetComponent<Gem>().UpdateGemPosition(_gemList[_gemListIndexCounter].transform, true);
                
                
               
                _gemListIndexCounter++;
            }
        }
        _text.text = "Gold:" + (_gemListIndexCounter+1) ;
    }
   /* public Vector3 CalculateRandomPoint()
    {

        randomPosition = _gameOb.transform.position;
        randomPosition.x += Random.Range(-2f, 2);
        randomPosition.z += Random.Range(-2f, 2f);
        return randomPosition;
    }

    public void GemDoJump(int count)
    {
        for (int i = 1; i < count; i++)
        {
            _gemList[i].gameObject.transform.DOJump(endValue: CalculateRandomPoint(), jumpPower: 5, numJumps: 1, duration: 5f);
            _gemList.RemoveAt(i);
        }
    }*/
}
