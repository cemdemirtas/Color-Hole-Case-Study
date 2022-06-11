using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DontEatableObject : MonoBehaviour
{
    public static DontEatableObject instance;
    public float AttractionDistance;
    [SerializeField] Transform blackhole;
    private Collider ownCollider;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        ownCollider =blackhole.transform.GetComponentInChildren<Collider>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Blackhole")
        {
            //Used DoTween shake and after reposition camera's rotation.
            Camera.main.transform.DOShakeRotation(2, 5).OnComplete(() => Camera.main.transform.rotation= Quaternion.Euler(new Vector3(48, 0, 0)));
            transform.GetComponent<Rigidbody>().AddForce(-20 * new Vector3(0,1,0), ForceMode.Force);
            //Singleton level state
            //While we hit some red obstacle,show game over panel.
            GameManager.Instance.gamestate = GameManager.GameState.GameOver;
        }
    }


}
