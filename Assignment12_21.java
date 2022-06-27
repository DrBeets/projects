package main.java;

import java.util.*;
import java.io.*;

/* Assignment 12.21 Created by Tristan Rogers 05/22 */

public class Assignment12_21{
    public static void main(String[] args) throws Exception {

        //Check to see if the file exists
        File file = new File("C:\\Users\\bombe\\Desktop\\SortedStrings.txt");
        // Message if file does not exist
        if (!file.exists()){
            System.out.println(file.getName() + " does not exist");
            System.exit(0);
        }
        //Display file name to ensure it is the correct file 
        System.out.println("File " + file.getName());
        boolean dataSorted = true;
        String string1 = "";
        String string2 = "";

        // Scan file for out of order strings
        try (Scanner input = new Scanner(file);) {
            if (input.hasNext())
                string1 = input.next();
 
            while (input.hasNext() && dataSorted) {
                string2 = input.next();

                // Display the first two strings that are out of order
               
                if (string1.compareTo(string2) > 0) {
                    System.out.println(
                        "The strings " + string1 + " and " + string2 + " are out of order");
                    dataSorted = false;
                }
                string1 = string2;
            }
        }
 
        // Display whether the strings in the files are stored in increasing order
        if (dataSorted) {
            System.out.println(
                "The strings in the file are stored in increasing order");
        }
    }
    
}