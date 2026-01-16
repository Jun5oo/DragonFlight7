using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private Material myMaterial; 

    void Start()
    {
        myMaterial = this.GetComponent<Renderer>().material;     

        if(myMaterial == null)
            Debug.LogError("No Background Material was found!"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newOffset = myMaterial.mainTextureOffset;
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime)); 
        myMaterial.mainTextureOffset = newOffset;
    }
}
