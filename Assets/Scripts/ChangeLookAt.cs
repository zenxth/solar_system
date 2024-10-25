using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if(target==null)
        {
            target = this.gameObject;
            Debug.Log("change look target is not specified. Defaulting to parent object");
        }
    }

    // Update is called once per frame
    private void OnMouseDown() {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x,1,100);

    }
}
