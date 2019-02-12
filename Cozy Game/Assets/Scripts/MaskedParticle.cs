using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaskedParticle : MonoBehaviour
{
    public SpriteRenderer fadeInSprite;

    public Vector3 TargetPosition;

    // Start is called before the first frame update
    void Start()
    {
        TargetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, TargetPosition, 0.005f);
    }
}
