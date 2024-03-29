﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    //establish "Space" class:
    //each Space has a color, chess piece, and position, which are strings for printing and comparing to input.
    //the chess board will be made up of 64 Spaces, stored in an array.
    public class Space
    {
        public string Color { get; set; }
        public string Piece { get; set; }
        public string Position { get; set; }
        public Space(string color, string piece, string position)
        {
            Color = color;
            Piece = piece;
            Position = position;
        }
    }

    class Program
    {
        //function for printing the chess board
        static void printBoard(string rowHeader, Space[] arrayBoard)
        {
            //clear board after game starts or user makes move
            Console.Clear();
            Console.Write(rowHeader);

            //for printing the numbers beside the board
            int counter = 0;
            string counterString = "";

            //print board
            for (int i = 0; i < 64; i++)
            {
                //print newline and row number at edge of board
                if (i % 8 == 0)
                {
                    Console.Write("\n");
                    counter++;
                    counterString = counter.ToString();
                    Console.Write(counterString + " ");
                }
                Console.Write(arrayBoard[i].Piece);
            }
            Console.Write("\n");
        }

        public static void Main()
        {
            //temp variables for storing info while changing Spaces' values
            string tempPiece = "";
            string tempPosition = "";
            string tempKing = "";
            char tempRow;

            string promotion = "";
            string input = "start";
            Console.Write("Start?");
            Console.ReadKey();

            //initialize the 64 spaces
            Space h1 = new Space("|%|", "|r|", "h1");
            Space g1 = new Space("| |", "|n|", "g1");
            Space f1 = new Space("|%|", "|b|", "f1");
            Space e1 = new Space("| |", "|q|", "e1");
            Space d1 = new Space("|%|", "|k|", "d1");
            Space c1 = new Space("| |", "|b|", "c1");
            Space b1 = new Space("|%|", "|n|", "b1");
            Space a1 = new Space("| |", "|r|", "a1");
            Space h2 = new Space("| |", "|p|", "h2");
            Space g2 = new Space("|%|", "|p|", "g2");
            Space f2 = new Space("| |", "|p|", "f2");
            Space e2 = new Space("|%|", "|p|", "e2");
            Space d2 = new Space("| |", "|p|", "d2");
            Space c2 = new Space("|%|", "|p|", "c2");
            Space b2 = new Space("| |", "|p|", "b2");
            Space a2 = new Space("|%|", "|p|", "a2");
            Space h3 = new Space("|%|", "|%|", "h3");
            Space g3 = new Space("| |", "| |", "g3");
            Space f3 = new Space("|%|", "|%|", "f3");
            Space e3 = new Space("| |", "| |", "e3");
            Space d3 = new Space("|%|", "|%|", "d3");
            Space c3 = new Space("| |", "| |", "c3");
            Space b3 = new Space("|%|", "|%|", "b3");
            Space a3 = new Space("| |", "| |", "a3");
            Space h4 = new Space("| |", "| |", "h4");
            Space g4 = new Space("|%|", "|%|", "g4");
            Space f4 = new Space("| |", "| |", "f4");
            Space e4 = new Space("|%|", "|%|", "e4");
            Space d4 = new Space("| |", "| |", "d4");
            Space c4 = new Space("|%|", "|%|", "c4");
            Space b4 = new Space("| |", "| |", "b4");
            Space a4 = new Space("|%|", "|%|", "a4");
            Space h5 = new Space("|%|", "|%|", "h5");
            Space g5 = new Space("| |", "| |", "g5");
            Space f5 = new Space("|%|", "|%|", "f5");
            Space e5 = new Space("| |", "| |", "e5");
            Space d5 = new Space("|%|", "|%|", "d5");
            Space c5 = new Space("| |", "| |", "c5");
            Space b5 = new Space("|%|", "|%|", "b5");
            Space a5 = new Space("| |", "| |", "a5");
            Space h6 = new Space("| |", "| |", "h6");
            Space g6 = new Space("|%|", "|%|", "g6");
            Space f6 = new Space("| |", "| |", "f6");
            Space e6 = new Space("|%|", "|%|", "e6");
            Space d6 = new Space("| |", "| |", "d6");
            Space c6 = new Space("|%|", "|%|", "c6");
            Space b6 = new Space("| |", "| |", "b6");
            Space a6 = new Space("|%|", "|%|", "a6");
            Space h7 = new Space("|%|", "|P|", "h7");
            Space g7 = new Space("| |", "|P|", "g7");
            Space f7 = new Space("|%|", "|P|", "f7");
            Space e7 = new Space("| |", "|P|", "e7");
            Space d7 = new Space("|%|", "|P|", "d7");
            Space c7 = new Space("| |", "|P|", "c7");
            Space b7 = new Space("|%|", "|P|", "b7");
            Space a7 = new Space("| |", "|P|", "a7");
            Space h8 = new Space("| |", "|R|", "h8");
            Space g8 = new Space("|%|", "|N|", "g8");
            Space f8 = new Space("| |", "|B|", "f8");
            Space e8 = new Space("|%|", "|Q|", "e8");
            Space d8 = new Space("| |", "|K|", "d8");
            Space c8 = new Space("|%|", "|B|", "c8");
            Space b8 = new Space("| |", "|N|", "b8");
            Space a8 = new Space("|%|", "|R|", "a8");

            string rowHeader = "   h  g  f  e  d  c  b  a";

            //array of Spaces, so input can be compared to them and they can be printed by printBoard
            Space[] arrayBoard = { h1, g1, f1, e1, d1, c1, b1, a1, h2, g2, f2, e2, d2, c2, b2, a2, h3, g3, f3, e3, d3, c3, b3, a3, h4, g4, f4, e4, d4, c4, b4, a4, h5, g5, f5, e5, d5, c5, b5, a5, h6, g6, f6, e6, d6, c6, b6, a6, h7, g7, f7, e7, d7, c7, b7, a7, h8, g8, f8, e8, d8, c8, b8, a8 };
            printBoard(rowHeader, arrayBoard);
            input = Console.ReadLine();
            while (input != "stop")
            {
                string[] move = input.Split(' ');

                //loop to compare input to the 64 spaces
                for (int i = 0; i < 64; i++)
                {
                    //find Space corresponding to user's starting position
                    if (move[0] == arrayBoard[i].Position)
                    {
                        //set tempPiece to the initial location's piece and change that piece to it's space's color
                        tempPiece = arrayBoard[i].Piece;
                        arrayBoard[i].Piece = arrayBoard[i].Color;
                        break;
                    }
                }
                //loop to compare input to the 64 spaces
                for (int i = 0; i < 64; i++)
                {
                    //find Space corresponding to user's ending position
                    if (move[1] == arrayBoard[i].Position)
                    {
                        //set tempPosition to ending position
                        tempPosition = move[1];

                        //set tempKing to the taken piece to later check for victory
                        tempKing = arrayBoard[i].Piece;

                        //set tempRow to the row of the ending position to check for pawn promotion
                        //allow user to choose between a knight or queen when promoting
                        tempRow = tempPosition[tempPosition.Length - 1];
                        if (tempPiece == "|p|" && tempRow == '8')
                        {
                            Console.Write("knight or queen? ");
                            promotion = Console.ReadLine();
                            if(promotion == "knight")
                            {
                                tempPiece = "|n|";
                            }
                            else
                            {
                                tempPiece = "|q|";
                            }
                        }
                        else if(tempPiece == "|P|" && tempRow == '1')
                        {
                            Console.Write("knight or queen? ");
                            promotion = Console.ReadLine();
                            if (promotion == "knight")
                            {
                                tempPiece = "|N|";
                            }
                            else
                            {
                                tempPiece = "|Q|";
                            }
                        }
                        arrayBoard[i].Piece = tempPiece;
                        break;
                    }
                }
                printBoard(rowHeader, arrayBoard);

                //check if game is won
                if (tempKing == "|k|" || tempKing == "|K|")
                {
                    Console.WriteLine("you win");
                    Console.ReadKey();
                    input = "stop";
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
        }
    }
}