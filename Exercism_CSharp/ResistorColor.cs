﻿namespace Exercism_CSharp
{
    #region Task Description
    /*
    If you want to build something using a Raspberry Pi, you'll probably use resistors. For this exercise, you need to know two things about them:
    Each resistor has a resistance value.
    Resistors are small - so small in fact that if you printed the resistance value on them, it would be hard to read.
    To get around this problem, manufacturers print color-coded bands onto the resistors to denote their resistance values. Each band has a position and a numeric value.
    The first 2 bands of a resistor have a simple encoding scheme: each color maps to a single number.
    In this exercise you are going to create a helpful program so that you don't have to remember the values of the bands.
    These colors are encoded as follows:

    black: 0
    brown: 1
    red: 2
    orange: 3
    yellow: 4
    green: 5
    blue: 6
    violet: 7
    grey: 8
    white: 9
    
    The goal of this exercise is to create a way:
    to look up the numerical value associated with a particular color band
    to list the different band colors
    Mnemonics map the colors to the numbers, that, when stored as an array, happen to map to their index in the array: Better Be Right Or Your Great Big Values Go Wrong.
    */
    #endregion

    public static class ResistorColor
    {
        /// <summary>
        /// Provides the color code of a given resistor band color.
        /// </summary>
        /// <param name="color">The resistor band color to be examined.</param>
        /// <returns>An integer indicating the color code, or null if color is invalid.</returns>
        public static int? ColorCode(string color)
        {
            if (Array.Exists(Colors(), c => c == color))
            {
                return Array.IndexOf(Colors(), color);
            }
            return null;
        }

        /// <summary>
        /// Stores the possible resistor band colors.
        /// </summary>
        /// <returns>A string array with the resistor band colors properly indexed to their corresponding resistor values.</returns>
        public static string[] Colors() => ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
    }
}
