using System;
using System.Text.RegularExpressions;

public class Program{
    static void Main(String[] args){
        String emailPattern = @"^\w+[a-zA-Z0-9.]*@[a-zA-Z]+[a-zA-Z0-9\-.]*\.[a-zA-Z]+$";
        String text = "johndoe@domainsample.com\n john.doe@domainsample.net\njohn.doe43@domainsample.co.uk SajjadAli geniusajjadali@gmail.com";
        Regex regex = new Regex(emailPattern);
        Match match = regex.Match(text);
        while(match.Success){
            Console.WriteLine(match.Value);
            match = match.NextMatch();
        }

    }

    static void second(){
        String pattern = @"\w+\s+car";
        String text = "one car red car yellow car";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(text);
        while(match.Success){
            Console.WriteLine(match.Value);
            match = match.NextMatch();
        }
    }

    static void first(){
        String pattern = @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[a-zA-Z0-9]$";
        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.IsMatch("A08D-931-468A"));
    }
}
