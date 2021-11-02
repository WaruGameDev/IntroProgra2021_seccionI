using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCharacters : MonoBehaviour
{
    public List<GameObject> characters;
    public int index; 
    // Start is called before the first frame update
    void Start()
    {
        SelectCharacter(0);
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            index++;
            if(index >= characters.Count)
            {
                index = 0;
            }
            SelectCharacter(index);
        }
    }
    public void SelectCharacter(int i)
    {
        foreach(GameObject chara in characters)
        {
            chara.SetActive(false);
        }
        characters[i].SetActive(true);
    }
}
