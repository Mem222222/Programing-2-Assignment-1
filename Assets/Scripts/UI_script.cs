using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_script : MonoBehaviour
{
    string Interact;
    public TMP_Text Interact_Text;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UI_script>(); 
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Interact = "Press E";
        if (collision.gameObject.tag == null)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Interact = "";
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Interact_Text.SetText(Interact);
    }
}
