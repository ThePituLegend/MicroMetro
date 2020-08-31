using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [Range(0f, 1f)][SerializeField] static float popUpFactor = 0.5f;
    void OnMouseEnter(){
        transform.localScale *= (1 + popUpFactor);
    }
    
    void OnMouseExit(){
        transform.localScale /= (1 + popUpFactor);
    }
}
