public class Animations{


    // animation section 
    public void CountdownEvent(){
        for (int i = 5; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinning(){
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    foreach (string s in animationStrings)
    {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
    }
    }
    // animation section 
}