package main.java;

import java.util.*;
/* Assignment 12.3 Created by Tristan Rogers 05/22 */

public class assignment12_3{
    public static void main(String[] args) {
        //create array of random 100 numbers
        int[] array = new int[100];

        for (int k = 0; k < array.length; k++){
            array[k] = (int) (Math.random() * 100);
        }

        //get user input for selected index
        Scanner input = new Scanner(System.in);
        System.out.print("Enter an index here: ");

        //try catch block to handle exception
        try{
            int index = input.nextInt();
            System.out.println("array[" + index + "] = " + array[index]);
        }
        // catch exception if out of bounds
        catch (ArrayIndexOutOfBoundsException ex){
            System.out.println(ex.getLocalizedMessage());
        }
    }
}
