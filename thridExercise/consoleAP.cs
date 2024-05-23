using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


public class Programa3



{

    // public event EventHandler ProcessingComplete;
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Worl soppka d");

        string filePath = "file.txt";

        try
        {
            string text=ReadFile(filePath);
            EventHandler procesador=new EventHandler();
            // aqui vamos a procesar el texto 
        
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Processing failed: {ex.Message}");
        }


    }


public static void procesador_textProcessed(object sender,TextProcessedEventArgs e )
{

    Console.WriteLine($"Total numbe of words: {e.WordCount}");
    Console.WriteLine("frecuenci character : ");

    foreach( var i in e.WordFrequency)
    {
        Console.WriteLine($"{i.Key}: {i.Value}");
    }



}

    public static string ReadFile(string filePath)
    {
        if(!File.Exists(filePath))
        
           throw new FileNotFoundException("File not found", filePath);
           string text = File.ReadAllText(filePath);
           if( string .IsNullOrEmpty(text))
               throw new Exception("File is empty");
               return text;
           
        
    }
        //  ojo
    // private static readonly char[] separator = new char[] {'','\n','\r'};

    public static int CountWords(string text)
{
    
    return text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
}

// calcular la frecuencia de las palabras
public static Dictionary<string,int> CalculateWordFrequency(string text)
{

    // aun por revisar
     // return text.GroupBy(c => c).ToDictionary(grp => grp.Key, static grp => grp.Count());
     return null;
   
}


//la palabra mas larga
public static string FindLongestWord( string text)
{
    return text.Split(new char[] { ' ', '\n', '\r' },StringSplitOptions.RemoveEmptyEntries).OrderByDescending(word=>word.Length).FirstOrDefault();
}


}

public class TextProcessedEventArgs
{

    public int WordCount { get; set; }
    public Dictionary<string,int> WordFrequency { get; set; }
    public string LongestWord { get; set; }
    public TextProcessedEventArgs(int wordCount, Dictionary<string,int> wordFrequency, string longestWord)
    {
        WordCount=wordCount;
        WordFrequency=wordFrequency;
        LongestWord=longestWord;
    }
}



public class EventHandler
{
    
public delegate void TestProcessesedEventHandler( object sender, TextProcessedEventArgs e);   




}