using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameInput : MonoBehaviour
{
    public storiesGenerator storiesGenerator = new storiesGenerator();
    private string piece;
    public Text displaytext = null;
    public puzzleOne puzzleOne = new puzzleOne();
    public puzzleTwo puzzleTwo = new puzzleTwo(); 
    public puzzleThree puzzleThree = new puzzleThree();
    public puzzleFour puzzleFour = new puzzleFour();

    // Start is called before the first frame update

    void Start()
    {
        newPiece();

    }

    // Update is called once per frame
    void Update()
    {
        string input = Input.inputString;
        displaytext.text = piece;
        checkLetters(input);
    }


    private void newPiece()
    {
        piece = storiesGenerator.getChallenge();
        
    }


    private void checkLetters(string input)
    {
        if(piece.Length > 0){
            if(input.Equals(piece.Substring(0, 1)))
            {
                scoreManager.scoreValue++;
                SoundManagerScript.playSound("right");
                //Letter_right(piece.Substring(index, index+1));
                piece = piece.Substring(1);
            }
            
            displaytext.text = piece;
        }
        else
        {
            if(storiesGenerator.pieceCounter == 0){
                puzzleOne.showPicture();
            }
            if(storiesGenerator.pieceCounter == 1){
                puzzleTwo.showPicture();
            }
            if(storiesGenerator.pieceCounter == 2){
                puzzleThree.showPicture();
            }
            if(storiesGenerator.pieceCounter == 3){
                puzzleFour.showPicture();

            }
            storiesGenerator.pieceCounter++;
            newPiece();
        }
    }

}
