using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Censoring : MonoBehaviour
{
    [SerializeField] InputField input_field;

    public void change_to_passtype()
    {

        if (input_field.contentType != InputField.ContentType.Password)
        {
            input_field.contentType = InputField.ContentType.Password;
            input_field.ForceLabelUpdate();
        }

    }

    public void change_to_standardtype()
    {

        if (input_field.contentType != InputField.ContentType.Standard)
        {
            input_field.contentType = InputField.ContentType.Standard;
            input_field.ForceLabelUpdate();
        }

    }
}
