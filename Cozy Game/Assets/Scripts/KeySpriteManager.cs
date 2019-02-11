using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpriteManager : MonoBehaviour
{

    public KeySprite[] keySprite;

    // Start is called before the first frame update
    void Start()
    {
        // GetComponentInChildren<KeySprite>();
        for(int i = 0; i < keySprite.Length; i++)
        {
            keySprite[i].InitializeKey();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
