using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRandomizer : MonoBehaviour
{
    public int characterNumber;

    public GameObject girl1;
    public GameObject girl2;
    public GameObject guy;

    public GameObject salsa1;
    public GameObject salsa2;
    public GameObject salsa3;

    // Start is called before the first frame update
    void Start()
    {
        characterNumber = Random.Range(1, 4);
        Debug.Log(characterNumber.ToString());
        if (characterNumber == 1)
        {
            girl1.SetActive(true);
            salsa1.SetActive(true);
        }

        if (characterNumber == 2)
        {
            girl2.SetActive(true);
            salsa2.SetActive(true);
        }

        if (characterNumber == 3)
        {
            guy.SetActive(true);
            salsa3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
