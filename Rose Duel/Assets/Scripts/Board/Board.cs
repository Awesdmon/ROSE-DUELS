using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Board : MonoBehaviour
{

    //[SerializeField] private Card[,] board = new Card[9, 9];

    [SerializeField] private Card[][] board = new Card[9][];
    private void Start()
    {
        board[0] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[1] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[2] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[3] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[4] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[5] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[6] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[7] = new Card[] { null, null, null, null, null, null, null, null, null };
        board[8] = new Card[] { null, null, null, null, null, null, null, null, null };
    }



    /*
         public void PlaceCard(Card card, int row, int col)
    {
        board[row, col] = card;
    }

    public void RemoveFromBoard(int row, int col)
    {
        //Send card to discard
        board[row, col] = null;
    }

    public Card GetCardAtPosition(int row, int col)
    {
        return board[row, col];
    }
     */



}
