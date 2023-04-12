using Newtonsoft.Json;
using System;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {
        Text t = new Text();
        t.AddTXT("Hello, i am Tymmy");
        Console.WriteLine(t.Show());
    }
}
public class Text
{
    public Rechen[] rechen;
    public Text()
    {
        this.rechen = new Rechen[0];
    }
    public void AddTXT(string txt)
    {
        Rechen[] r = new Rechen[rechen.Length + 1];
        for(int i = 0; i < rechen.Length; i++)
        {
            r[i] = rechen[i];
        }
        r[rechen.Length] = new Rechen();
        r[rechen.Length].AddRechen(txt);
        rechen = r;
    }

    public string Show()
    {
        string a = "";
        for(int i = 0; i < rechen.Length; i++)
        {
            a += rechen[i].Show();
        }
        return a;
    }
}
public class Rechen
{
    public Slowo[] slowo;
    public Rechen()
    {
        this.slowo = new Slowo[0];
    }
    public void AddRechen(string txt)
    {
        string[] txt_m = txt.Split(' ');
        Slowo[] s = new Slowo[txt_m.Length];
        for(int i = 0; i < s.Length; i++)
        {
            s[i] = new Slowo(txt_m[i]);
        }
        slowo = s;
    }

    public string Show()
    {
        string a = "";
        for (int i = 0; i < slowo.Length; i++)
        {
            a += slowo[i].word + " ";
        }
        return a;
    }
}
public class Slowo
{
    public string word;
    public Slowo(string word)
    {
        this.word = word;
    }
}