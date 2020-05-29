using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToImage : MonoBehaviour
{
    public Sprite finalSprite;
    public Texture2D texture;
    // Start is called before the first frame update
    void Start()
    {
        finalSprite.texture = texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
