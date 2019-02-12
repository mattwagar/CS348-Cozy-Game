using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class KeySprite : MonoBehaviour
{
    public KeyCode keyCode;
    
    public ParticleSystem particleEffect;

    public AudioSource audioSource;

    private SpriteRenderer spriteRenderer;

    private bool keyPressed;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            keyPressed = true;
        }  
        if (Input.GetKeyUp(keyCode)){
            keyPressed = false;
        }

        if(keyPressed){
            //spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
            particleEffect.Play();
            //Might add some stuff here to modify volume on keypresses to be more dynamic
            audioSource.Play();
        }  else {
            //spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0.0f);
        }
    }

    public void InitializeKey()
    {
        gameObject.SetActive(true);
    }
}
