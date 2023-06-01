using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] Josh josh;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    private Queue<string> sentences;
    private BossMover bossMover;
    private bool canAdvanceDialogue;
    private Player player;
    private MusicPlayer musicPlayer;
    private CreditsText creditsText;
    

    // Start is called before the first frame update
    void Start()
    {
        creditsText = FindObjectOfType<CreditsText>();
        musicPlayer = FindObjectOfType<MusicPlayer>();
        player = FindObjectOfType<Player>();
        bossMover = FindObjectOfType<BossMover>();
        sentences = new Queue<string>();
        canAdvanceDialogue = true;
        //josh.Enter();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //josh.Exit();
        player.SetCanControl(false);
        canAdvanceDialogue = true;
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {       
        if (canAdvanceDialogue)
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            string sentence = sentences.Dequeue();
            SpecialActions(sentence);


            dialogueText.text = sentence;
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }

    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        bossMover.GetComponent<DialogueTrigger>().currentDialogueIndex++;
        canAdvanceDialogue = false;
        bossMover.GetAnimator().SetTrigger("DialogueComplete");
        player.SetCanControl(true);
    }

    private void SpecialActions(string sentence)
    {
        if (sentence.Equals("...uhh."))
        {
            josh.Enter();
        }
        if (sentence.Equals("........................."))
        {
            josh.Exit();
        }
        if (sentence.Equals("Thanks for playing, bro."))
        {
            josh.Enter();
            bossMover.Spin();
            musicPlayer.GetComponent<AudioSource>().volume = 0.25f;
            creditsText.SetScrolling(true);
            musicPlayer.PlaySkateboard();
        }
    }
}
