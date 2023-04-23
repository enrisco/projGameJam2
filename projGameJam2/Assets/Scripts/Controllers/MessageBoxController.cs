using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.VersionControl;
using UnityEngine;

class MessageBoxController : MonoBehaviour
{
    public Choice LastChoice = null;

    [SerializeField] GameObject txtName;
    [SerializeField] GameObject txtMessage;

    [SerializeField] ChooseController ChooseController;
    [SerializeField] PlayerController PlayersController;

    [SerializeField] float MoveSpeed;
    [SerializeField] float LetterSpeed;

    MovementManager MovementManager;
    RectTransform RectTransform;

    bool canMove = false;

    private void Start()
    {
        RectTransform = GetComponent<RectTransform>();
        MovementManager = new MovementManager
        (
            null, 
            RectTransform, 
            Vector3.zero, 
            RectTransform.position,
            MoveSpeed,
            null
        );
    }

    private void Update()
    {
        if (canMove) 
        { 
            MovementManager.Move(true);
            if (MovementManager.CheckIfItIsInTargetPosition(true)) canMove = false;
        }
    }

    public void SetMessages(string name, string[] message, int choiceIndex, bool startAnim, bool endAnim)
    {

        MovementManager.ChangeFinalPosition(new Vector2(0, 0));
        canMove = true;
        TextManager.SetText(name, txtName);
        StartCoroutine(SetMessage(message, txtMessage, choiceIndex, startAnim, endAnim));
    }

    IEnumerator SetMessage(string[] messages, GameObject txtMessage, int choiceIndex, bool startAnim, bool endAnim)
    {
        foreach (string item in messages)
        {
            if (item == messages[0] && startAnim) MovementManager.Move(true);
            TextManager.SetText(string.Empty, txtMessage);
            yield return TextManager.WaitToSetText(item, txtMessage, LetterSpeed);

            if (choiceIndex > -1 && item == messages[choiceIndex])
            {
                ChooseController.gameObject.SetActive(true);
                yield return ChooseController.WaitForChoose();
                ChooseController.gameObject.SetActive(false);

                LastChoice = ChooseController.LastChoice;
                ChooseController.LastChoice = null;
            }
            else yield return WaitForInput();
        }

        if (endAnim) 
        { 
            MovementManager.ChangeFinalPosition(new Vector2(0, -165));
            canMove = true;
            PlayersController.CanMove = true;
        }
    }

    IEnumerator WaitForInput()
    {
        bool userClicked = false;
        while(!userClicked)
        {
            if (Input.GetKeyDown(KeyCode.Z)) userClicked = true;
            yield return null;
        }
    }

    public IEnumerator WaitToChoiceNotNull()
    {
        yield return new WaitUntil(() => LastChoice != null);
    }
}
