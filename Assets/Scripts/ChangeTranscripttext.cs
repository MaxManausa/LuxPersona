using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTranscripttext : MonoBehaviour
{
    [SerializeField] private TMP_Text transcriptText;

    public void AboutTranscript()
    {
        transcriptText.text = "hey there\n" +
                              "my name is Max\n" +
                              "I made this prototype\n" +
                              "I hope you enjoy it";
    }
    
    public void Transcript1()
    {
        transcriptText.text = "Question 1: What is your name?\n\n" +
                              "Response: My name is Charles Trent Manausa.";
    }
    
    public void Transcript2()
    {
        transcriptText.text = "Question 2: When were you born?\n\n"+
                              "Response: I was born October 22nd, 1936.";
    }
    
    public void Transcript3()
    {
        transcriptText.text = "Question 3: How old are you?\n\n" +
                              "Response: I'm eighty six";
    }
    
    public void Transcript4()
    {
        transcriptText.text = "Question 4: Where were you born?\n\n" +
                              "Response: I was born in Michigan," + 
                              "we lived in Ann Arbor, Michigan" +
                              "I was born in Detroit" +
                              "when my mother was visiting" +
                              "her mom and dad" +
                              "and I was born in Detroit,"+
                              "but we lived in Ann Arbor.";
    }
    
    public void Transcript5()
    {
        transcriptText.text = "Question 5: Do you have any siblings?\n\n" +
                              "Response: I have 2 living siblings. " +
                              "My brother, Terry Edward " +
                              "Manausa, and Wendy Curry " +
                              "Manausa. And we had one sibling " +
                              "that died shortly after birth " + 
                              "from fenofribate.";
    }
    public void Transcript6()
    {
        transcriptText.text = "Question 6: Do you have a favorite hobby?\n\n" +
                              "Response: My favorite hobby?" +
                              "Is gardening, and fishing," +
                              "and boating. Fishing and" +
                              "boating are one.\n" +
                              "Just the peacefulness of being" +
                              "out on the water. It just gets" +
                              "away from everything else." +
                              "Gives me a place to be away" + 
                              "from everyday situations.";
    }
    
    public void Transcript7()
    {
        transcriptText.text = "Question 7: Do you have a favorite book?\n\n" +
                              "Response: I do:" +
                              "'Pillars of the Earth',"+
                              "by Ken Follett.";
    }
    
    public void Transcript8()
    {
        transcriptText.text = "Question 8: Whats your favorite type of music?\n\n" +
                              "Response: I like a lot of music" +
                              "I don't really have a real" + 
                              "favorite one" +
                              "I like the 50s and 60s rock" +
                              "and I like most music" + 
                              "I like classical music," + 
                              "I like piano music, " +
                              "I like dancing music.";
    }
    
    public void Transcript9()
    {
        transcriptText.text = "Question 9: Where is your favorite place to visit/vacation?\n\n" +
                              "Response: My favorite place to " +
                              "vacation is the Florida Keys.";
    }
    
    public void Transcript10()
    {
        transcriptText.text = "Question 10: What's your favorite food?\n\n" +
                              "Response: My favorite food?" +
                              "A good steak.";
    }
    public void Transcript11()
    {
        transcriptText.text = "Question 11: What's your favorite color?\n\n" +
                              "Response: Probably, my favorite color is " +
                              "blue. Shortly followed by red.";
    }
    
    public void Transcript12()
    {
        transcriptText.text = "Question 12: What's your favorite animal?\n\n" +
                              "Response: My favorite animal would be" +
                              "a dog";
    }
    
    public void Transcript13()
    {
        transcriptText.text = "This is transcript number 13\n";
    }
    
    public void Transcript14()
    {
        transcriptText.text = "This is transcript number 14\n";
    }
    
    public void Transcript15()
    {
        transcriptText.text = "This is transcript number 15\n";
    }
}
