using System.Collections.Generic;

namespace EditorExplorer.Data
{
    public interface IBot
    {
        public IList<string> Prompt(string message);
    }

    public class SimpleBot : IBot
    {
        public IList<string> Prompt(string message)
        {
            var answers = new List<string>();

            if(!string.IsNullOrEmpty(message) && message.IndexOf('?') >= 0)
            {
                answers.Add("Good question! Unfortunately, I am not trained to answer questions &#128517;");
                answers.Add("Interesting question. I didn't think about it. But I'm a bot, I don't know how to think &#128521;");
                answers.Add("I'm sorry, I'm so tired. Bots also need to rest &#128532;");
                answers.Add("How should I know? I'm just a simple bot. &#128530;");
            }
            else if (!string.IsNullOrEmpty(message) && message.IndexOf('!') >= 0)
            {
                answers.Add("I completely agree with you!");
                answers.Add("Please don't be so loud. I'm trying to read \"How To Become The Smartest Bot For Dummies\".");
                answers.Add("The weather is beautiful today, isn't it?");
            }
            else
            {
                answers.Add("You're doing great!");
                answers.Add("You also can insert emoji into a message using the corresponding button to the left of the input field.");
                answers.Add("Well, I'm glad to see that... or read it. Or what else are bots doing with messages? &#128513;");
                answers.Add("Good job! Maybe you want to ask me something?");
            }

            return answers;
        }
    }
}