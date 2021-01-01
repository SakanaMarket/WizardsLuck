using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Read_input : MonoBehaviour
{
    [SerializeField] private InputField input;
    [SerializeField] private Animator wizard_ani;
    [SerializeField] private GameObject weak_explosion;
    [SerializeField] private GameObject medium_explosion;
    [SerializeField] private GameObject strong_explosion;
    [SerializeField] private List<GameObject> weak_weps;
    [SerializeField] private List<GameObject> med_weps;
    [SerializeField] private List<GameObject> strong_weps;
    [SerializeField] private AudioClip cough;
    [SerializeField] private AudioClip fizzle;
    [SerializeField] private AudioClip grunt;
    [SerializeField] private AudioClip boom;
    [SerializeField] private AudioClip oh_yea;
    [SerializeField] private AudioClip big_boom;
    [SerializeField] private AudioSource magic_src;

    void Start()
    {
        //var se = new InputField.SubmitEvent();
        //se.AddListener(SubmitText);
        //input.onEndEdit = se;
        
    }

    public void SubmitText()
    {
        string pass = input.text;
        FindItemToDestroy();
        int one_to_ten = Random.Range(0, 10);
        int one_to_twenty = Random.Range(0, 20);
        // < 8 --> weak
        // 8-9 --> medium
        // 10+ --> strong

        List<bool> checks = new List<bool>();

        int pass_length = pass.Length;

        //check_lower = Regex.IsMatch(pass, "[a-z]+");
        //check_upper = Regex.IsMatch(pass, "[A-Z]+");
        //check_symbol = Regex.IsMatch(pass, "[\\W]+");
        //check_number = Regex.IsMatch(pass, "[\\d]+");

        Debug.Log(pass_length);

        if (Regex.IsMatch(pass, "[a-z]+")) { checks.Add(true); }
        if (Regex.IsMatch(pass, "[A-Z]+")) { checks.Add(true); }
        if (Regex.IsMatch(pass, "[\\W]+")) { checks.Add(true); }
        if (Regex.IsMatch(pass, "[\\d]+")) { checks.Add(true); }

        //StartCoroutine(WaitX());
        if (Regex.IsMatch(pass, "\\s+"))
        {
            Debug.Log("Error");
        }
        else if (pass_length < 8)
        {
            weak_summon(one_to_ten);
        }
        else if (pass_length >= 8 && pass_length < 10)
        {
            if (checks.Count == 4)
            {
                medium_summon(one_to_ten);
            }
            else
            {
                weak_summon(one_to_ten);
            }
        }
        else
        {
            if (checks.Count == 4)
            {
                strong_summon(one_to_twenty);
            }
            else if (checks.Count == 3)
            {
                medium_summon(one_to_ten);
            }
            else
            {
                weak_summon(one_to_ten);
            }
        }
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        wizard_ani.SetBool("weak", false);
        wizard_ani.SetBool("med", false);
        wizard_ani.SetBool("strong", false);
    }

    IEnumerator WaitX()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("AA");
    }

    private void FindItemToDestroy()
    {
        GameObject Gear;
        GameObject[] Gears = GameObject.FindGameObjectsWithTag("Gear");
        foreach (GameObject g in Gears)
        {
            Destroy(g);
        }
    }

    private void weak_summon(int num)
    {
        Debug.Log("weak");
        wizard_ani.SetBool("weak", true);
        Instantiate(weak_explosion, new Vector3(2f, 0f, 0f), transform.rotation);
        Instantiate(weak_weps[num], new Vector3(2f, 0f, 0f), transform.rotation);
        magic_src.PlayOneShot(fizzle);
        magic_src.PlayOneShot(cough);
    }

    private void medium_summon(int num)
    {
        Debug.Log("medium");
        wizard_ani.SetBool("med", true);
        Instantiate(medium_explosion, new Vector3(2f, 0f, 0f), transform.rotation);
        Instantiate(med_weps[num], new Vector3(2f, 0f, 0f), transform.rotation);
        magic_src.PlayOneShot(boom);
        magic_src.PlayOneShot(grunt);
    }

    private void strong_summon(int num)
    {
        Debug.Log("strong");
        wizard_ani.SetBool("strong", true);
        Instantiate(strong_explosion, new Vector3(2f, 0f, 0f), transform.rotation);
        Instantiate(strong_weps[num], new Vector3(2f, 0f, 0f), transform.rotation);
        magic_src.PlayOneShot(big_boom);
        magic_src.PlayOneShot(oh_yea);
    }
}
