using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Example
    {
    public static void CreateLinkedList()
    {
        //Create the link list
        string[] words =
        {
            "the","fox","jumps","over","the","dog"
        };
        LinkedList<string> sentence = new(words);
        Display(sentence, "The linked list values:");
        Console.WriteLine($"sentence.Contains('jumps')=st node to be the last node.{sentence.Contains("jump")}");

        //Add the word "today' to the beginning of the linked list.
        sentence.AddFirst("today");
        Display(sentence, "Test 1: Add 'today' to the beginning of the list:");

        //Move the first node to be the last node.
        LinkedListNode<string> mark1 = sentence.First;
        sentence.RemoveFirst();
        sentence.AddLast(mark1);
        Display(sentence, "Test 2: Move first node to be the last node:");

        //Change the last node to 'yesterday'
    }

    private static void Display(LinkedList<string> sentence, string v)
    {
        throw new NotImplementedException();
    }
}

