using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class storiesGenerator : MonoBehaviour
{
    //public TextAsset story = (TextAsset)Resources.Load("story", typeof(TextAsset));
    //string readFromFilePath = Application.streamingAssetsPath+ "/Stories/"+ "story" +".txt";

    
    //File.ReadAllLines(readFromFilePath);
    public string storiesBackStage = "London-born Ada Lovelace had a passion and gift for mathematics from a young age.|She is credited with being the world's first computer programmer, for she drafted the Analytical Engine |Lovelace detailed applications for the Analytical Engine that relate to how computers are used today.|The international day of recognition celebrates women in science, technology, engineering, and math.#American Grace Hopper was an admiral in the United States Navy and one of the first programmers for the Harvard Mark I computer.|In 1944, she created a 500-page Manual of Operations for the Automatic Sequence-Controlled Calculator for the computer.|Hopper is also the inventor of the compiler, an intermediate program that translates English language instructions into the language of the target computer.|This invention influenced other computing developments, like code optimization, subroutines, and formula translation.";
    private List<string> fourPieces = new List<string>();
    private string storiesFrontStage;
    private List<string> levels = new List<string>();
    private string challenge;
    private List<string> splittedStory = new List<string>();
    public int pieceCounter = 0;
    private int splitNumber = 0;

    
    void Awake()
    {
        storiesFrontStage = storiesBackStage;
        levels.AddRange(splitStories(storiesFrontStage));
    }

    private List<string> splitStories(string wholeStory)
    {
        splittedStory = wholeStory.Split('#').ToList();
        return splittedStory;
    }

    public string getChallenge()
    {
        //task:if completeLevel is true, set splitnumer to 0
        if (pieceCounter == 4){
            splitNumber = 0;
        }
        
        if(splitNumber == 0)
        {
            fourPieces = splitPieces(levels[0]);
            splitNumber++;
        }

        
        challenge = fourPieces[0];
        fourPieces.Remove(challenge); 
        return challenge;
    }

    private List<string> splitPieces(string level)
    {

        List<string> splittedLevel = new List<string>();
        splittedLevel = level.Split('|').ToList(); 
        //task: maybe you should remove level 0 in order to udapte level
        levels.Remove(level);
        return splittedLevel;
    }

}
