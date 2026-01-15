using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpriteRenderer sceneSpriteRenderer;
    public Sprite[] sceneSprites;
    private int currentSceneIndex = 0;



    
    void Start()
    {
        currentSceneIndex = 0;
        sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
    }



    void Update()
    {
        
    }


    public void GoForward ()
    {
        if (currentSceneIndex == 0)
        {
            currentSceneIndex = 1;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 1)
        {
            currentSceneIndex = 2;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 2)
        {
            currentSceneIndex = 5;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 5)
        {
            currentSceneIndex = 6;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 6)
        {
            currentSceneIndex = 7;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 7)
        {
            currentSceneIndex = 10;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 10)
        {
            currentSceneIndex = 13;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 8)
        {
            currentSceneIndex = 14;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 14)
        {
            currentSceneIndex = 15;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 15)
        {
            currentSceneIndex = 20;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 9)
        {
            currentSceneIndex = 21;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 21) 
        {
            currentSceneIndex = 22;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 22) 
        {
            currentSceneIndex = 23;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 12) 
        {
            currentSceneIndex = 30;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 30) 
        {
            currentSceneIndex = 31;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 31) 
        {
            currentSceneIndex = 32;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if ( currentSceneIndex == 11)
        {
            currentSceneIndex = 39;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if ( currentSceneIndex == 41)
        {
            currentSceneIndex = 42;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
    }
    public void GoBack ()
    {
        if (currentSceneIndex == 1)
        {
            currentSceneIndex = 0;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 2)
        {
            currentSceneIndex = 1;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 5)
        {
            currentSceneIndex = 2;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 6)
        {
            currentSceneIndex = 5;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 7)
        {
            currentSceneIndex = 6;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 10)
        {
            currentSceneIndex = 7;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 13)
        {
            currentSceneIndex = 10;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 14)
        {
            currentSceneIndex = 8;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 15)
        {
            currentSceneIndex = 14;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 20)
        {
            currentSceneIndex = 15;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 21)
        {
            currentSceneIndex = 9;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 22)
        {
            currentSceneIndex = 21;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 23)
        {
            currentSceneIndex = 22;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 30)
        {
            currentSceneIndex = 12;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 31) 
        {
            currentSceneIndex = 30;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 32) 
        {
            currentSceneIndex = 31;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 39)
        {
            currentSceneIndex = 11;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 42)
        {
            currentSceneIndex = 41;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
    }
    public void GoLeft ()
    {
        if (currentSceneIndex == 2)
        {
            currentSceneIndex = 3;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 4)
        {
            currentSceneIndex = 2;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 7)
        {
            currentSceneIndex = 8;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 9)
        {
            currentSceneIndex = 7;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 10)
        {
            currentSceneIndex = 11;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 12)
        {
            currentSceneIndex = 10;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 14)
        {
            currentSceneIndex = 16;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 17)
        {
            currentSceneIndex = 14;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 15)
        {
            currentSceneIndex = 19;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 18)
        {
            currentSceneIndex = 15;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 24)
        {
            currentSceneIndex = 21;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 21)
        {
            currentSceneIndex = 25;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 26)
        {
            currentSceneIndex = 22;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 22)
        {
            currentSceneIndex = 27;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 27)
        {
            currentSceneIndex = 22;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 28)
        {
            currentSceneIndex = 23;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 23)
        {
            currentSceneIndex = 29;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 30)
        {
            currentSceneIndex = 33;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 31)
        {
            currentSceneIndex = 35;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 32)
        {
            currentSceneIndex = 37;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 34)
        {
            currentSceneIndex = 30;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 36)
        {
            currentSceneIndex = 31;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 38)
        {
            currentSceneIndex = 32;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 40)
        {
            currentSceneIndex = 39;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 41)
        {
            currentSceneIndex = 40;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 42)
        {
            currentSceneIndex = 43;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 43)
        {
            currentSceneIndex = 44;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
    }
    public void GoRight ()
    {
        if (currentSceneIndex == 2) // CURRENT SCENE
        {
            currentSceneIndex = 4; // NEXT SCENE
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 3)
        {
            currentSceneIndex = 2;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 7)
        {
            currentSceneIndex = 9;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 8)
        {
            currentSceneIndex = 7;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 10)
        {
            currentSceneIndex = 12;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 11)
        {
            currentSceneIndex = 10;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 14)
        {
            currentSceneIndex = 17;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 16)
        {
            currentSceneIndex = 14;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 15)
        {
            currentSceneIndex = 18;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 19)
        {
            currentSceneIndex = 15;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 21)
        {
            currentSceneIndex = 24;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 25)
        {
            currentSceneIndex = 21;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 22)
        {
            currentSceneIndex = 26;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 27)
        {
            currentSceneIndex = 22;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 29)
        {
            currentSceneIndex = 23;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 23)
        {
            currentSceneIndex = 28;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 33)
        {
            currentSceneIndex = 30;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 35)
        {
            currentSceneIndex = 31;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 37)
        {
            currentSceneIndex = 32;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 30)
        {
            currentSceneIndex = 34;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 31)
        {
            currentSceneIndex = 36;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 32)
        {
            currentSceneIndex = 38;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 39)
        {
            currentSceneIndex = 40;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 40)
        {
            currentSceneIndex = 41;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 43)
        {
            currentSceneIndex = 42;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
        else if (currentSceneIndex == 44)
        {
            currentSceneIndex = 43;
            sceneSpriteRenderer.sprite = sceneSprites[currentSceneIndex];
        }
    }

    public void enemy ()
    {

    }
}
