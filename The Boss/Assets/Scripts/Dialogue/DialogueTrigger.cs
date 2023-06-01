using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public Dialogue dialogue1;
    public Dialogue dialogue2;
    public Dialogue dialogue3;
    public Dialogue dialogue4;
    public Dialogue dialogue5;
    public Dialogue dialogue6;
    public Dialogue dialogue7;
    public Dialogue dialogue8;
    public Dialogue dialogue9;
    public Dialogue dialogue10;
    public Dialogue dialogue11;

    public List<Dialogue> dialogueList;
    public int currentDialogueIndex;

    public void Start()
    {

        dialogueList = new List<Dialogue>();
        currentDialogueIndex = 0;

        dialogue = new Dialogue();
        List<string> sentences = new List<string>();
        dialogue.name = "Bored Guy";
        sentences.Add("Hey...");
        sentences.Add("...");
        sentences.Add("I'm pretty bored here.");
        sentences.Add("...it's just me...");
        sentences.Add("...here...");
        sentences.Add("...all alone.");
        sentences.Add("Would you...");
        sentences.Add("...like to fight me?");
        sentences.Add("You just have to use the arrow keys to move and the S key to shoot.");
        sentences.Add("...");
        sentences.Add("..................");
        sentences.Add("..................................................");
        sentences.Add("...I'll take that as a yes.");
        sentences.Add("Okay.");
        sentences.Add("Remember: ");
        sentences.Add("Arrow keys to move.");
        sentences.Add("S key to shoot.");
        dialogue.sentences = sentences;
        dialogueList.Add(dialogue);

        dialogue1 = new Dialogue();
        List<string> sentences1 = new List<string>();
        dialogue1.name = "Bored Guy";
        sentences1.Add("Wow, you're pretty good at this...");
        sentences1.Add("...that's pretty cool.");
        sentences1.Add("Sorry if I'm a bit slow.");
        sentences1.Add("Guarding this...");
        sentences1.Add("...blank...");
        sentences1.Add("..empty...");
        sentences1.Add("..space...");
        sentences1.Add("...isn't very exciting.");
        sentences1.Add("Job benefits are great, though.");
        sentences1.Add("Anytime someone comes by I get to fight them.");
        sentences1.Add("And boy, do I love fighting...");
        sentences1.Add("...but I always win, sadly.");
        dialogue1.sentences = sentences1;
        dialogueList.Add(dialogue1);

        dialogue2 = new Dialogue();
        List<string> sentences2 = new List<string>();
        dialogue2.name = "Bored Guy";
        sentences2.Add("Whoa, okay.");
        sentences2.Add("Nice one bro.");
        sentences2.Add(" Did not expect you to get past that attack.");
        sentences2.Add("...");
        sentences2.Add("Dang.");
        sentences2.Add("Just...real nice, bro.");
        sentences2.Add(".............");
        sentences2.Add("You know, it's always good when I meet someone who can take a punch."); 
        sentences2.Add("Okay. Enough nonsense.");
        sentences2.Add("Lasers. That's what's happening.");
        dialogue2.sentences = sentences2;
        dialogueList.Add(dialogue2);

        dialogue3 = new Dialogue();
        List<string> sentences3 = new List<string>();
        dialogue3.name = "Bored Guy";
        sentences3.Add("Dang, alright. So you're pretty good at this.");
        sentences3.Add("I see you don't fall for the easy stuff."); 
        sentences3.Add("What if I got a little funky with it?");
        sentences3.Add("I mean, if that's cool with you.");
        sentences3.Add(".......");
        sentences3.Add(".......");
        sentences3.Add("You're right, I AM overthinking this.");
        sentences3.Add("Try to get me now.");
        dialogue3.sentences = sentences3;
        dialogueList.Add(dialogue3);

        dialogue4 = new Dialogue();
        List<string> sentences4 = new List<string>();
        dialogue4.name = "Bored Guy";
        sentences4.Add("Whoa.");
        sentences4.Add("Whoa.");
        sentences4.Add("WHOA.");
        sentences4.Add("That was my super special attack I only use on super strong dudes.");
        sentences4.Add("Heck. You're pretty cool for making it this far.");
        sentences4.Add("*sigh*");
        sentences4.Add("...too bad fights like these never last.");
        dialogue4.sentences = sentences4;
        dialogueList.Add(dialogue4);

        dialogue5 = new Dialogue();
        List<string> sentences5 = new List<string>();
        dialogue5.name = "Bored Guy";
        sentences5.Add("You know, even though no one ever really beats me...");
        sentences5.Add("...I appreciate you being able to last this long.");
        sentences5.Add("I don't get many visitors.");
        sentences5.Add("Well, except Josh.");
        sentences5.Add("...uhh.");
        sentences5.Add("Hey, Josh.");
        sentences5.Add("...");
        sentences5.Add("He doesn't really talk much.");
        sentences5.Add(".........................");
        sentences5.Add("But man, what a guy.");
        sentences5.Add("Okay...");
        sentences5.Add("...where were we?");
        dialogue5.sentences = sentences5;
        dialogueList.Add(dialogue5);

        dialogue6 = new Dialogue();
        List<string> sentences6 = new List<string>();
        dialogue6.name = "Bored Guy";
        sentences6.Add("I'm getting tired...");
        sentences6.Add("But you know what, bro...?");
        sentences6.Add("I'm gonna' keep going.");
        dialogue6.sentences = sentences6;
        dialogueList.Add(dialogue6);

        dialogue7 = new Dialogue();
        List<string> sentences7 = new List<string>();
        dialogue7.name = "Bored Guy";
        sentences7.Add("It's been a long time since I've had this much fun.");
        sentences7.Add("This is gonna' be a fight to remember.");
        dialogue7.sentences = sentences7;
        dialogueList.Add(dialogue7);

        dialogue8 = new Dialogue();
        List<string> sentences8 = new List<string>();
        dialogue8.name = "Bored Guy";
        sentences8.Add("Get ready.");
        sentences8.Add("Because I'm gonna' hit you with an attack I never use.");
        sentences8.Add("But I'll bust it out because you got guts, bro.");
        dialogue8.sentences = sentences8;
        dialogueList.Add(dialogue8);

        dialogue9 = new Dialogue();
        List<string> sentences9 = new List<string>();
        dialogue9.name = "Bored Guy";
        sentences9.Add("Alright.");
        sentences9.Add("If you don't make it after this...");
        sentences9.Add("...just wanna' say:");
        sentences9.Add("Thanks for playing with me, bro.");
        dialogue9.sentences = sentences9;
        dialogueList.Add(dialogue9);

        dialogue10 = new Dialogue();
        List<string> sentences10 = new List<string>();
        dialogue10.name = "Bored Guy";
        sentences10.Add("WHA--");
        sentences10.Add("WHAAAAAAAAT");
        sentences10.Add("WHAAAAAAAAAAAAAAT");
        sentences10.Add("I LOST. I'M LOSING.");
        sentences10.Add("THIS HAS LITERALLY NEVER HAPPENED TO ME.");
        sentences10.Add("NO.");
        sentences10.Add("NO FREAKIN' WAY BRO.");
        sentences10.Add("I CAN'T LOSE.");
        sentences10.Add("WHAT ABOUT.");
        sentences10.Add("THIS");

        dialogue10.sentences = sentences10;
        dialogueList.Add(dialogue10);

        dialogue11 = new Dialogue();
        List<string> sentences11 = new List<string>();
        dialogue11.name = "Bored Guy";
        sentences11.Add("Ahh, who am I kidding.");
        sentences11.Add("You");
        sentences11.Add("Were");
        sentences11.Add("Great");
        sentences11.Add("BRO!!!");
        sentences11.Add("I used to think that it was boring here.");
        sentences11.Add("And I guess it still is for the most part...");
        sentences11.Add("...but I'm glad that there are dudes like you, bro.");
        sentences11.Add("Dudes that stick it through.");
        sentences11.Add("Dudes that remind me that there's still some fun to be had.");
        sentences11.Add("Thanks for playing, bro.");
        
        dialogue11.sentences = sentences11;
        dialogueList.Add(dialogue11);

    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogueList[currentDialogueIndex]);
        // replace above line with StartDialogue(dialogues[currentDialogueIndex])
        // Every time DialogueManager.EndDialogue() is called, have currentDialogueIndex increment by 1
        // Figure out a way to trigger an animation for Josh the Funky Guy to come in at a specific line of dialogue
    }

}
