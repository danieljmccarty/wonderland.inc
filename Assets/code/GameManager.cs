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
    }
}
