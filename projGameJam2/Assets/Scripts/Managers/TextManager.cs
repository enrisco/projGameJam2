using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

class TextManager
{
    public static void SetText(object message, GameObject output)
    {
        output.GetComponent<Text>().text = message.ToString();
    }

    public static IEnumerator WaitToSetText(string message, GameObject output, float time)
    {
        Text t = output.GetComponent<Text>();
        foreach (char c in message)
        {
            yield return new WaitForSeconds(time);
            t.text += c;
        }
    }
}
