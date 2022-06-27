package main.java;

/* Queue class assignment 10.10 Created by Tristan Rogers 04/22 */

public class Queue {
    private int size;
    private int[] elements;

    Queue() {
        elements = new int[8];
        size = 0;
    }

    public void enqueue(int v){
        elements[size] = v;   
         size++;                              
        if (size >= elements.length){
            int[] temp_array = elements;
            elements = new int[size*2];
            for (int i = 0; i<temp_array.length;i++){
                elements[i] = temp_array[i];
            }
        }
    }
 
    public int dequeue(){
        int v = -1;
        if (empty() == true){
            System.out.println("The queue is empty.");
        }
        else{
            v = elements[0];
                    for(int i =0; i<elements.length-1; i++){
                elements[i] = elements[i+1];
            }
            size = size - 1;
        }
        return v;
    }
    // boolean method to return t/f
    public boolean empty(){
        if (size == 0){
            return true;
        }
        else{
            return false;
        }
    }
    // return size of the queue
    public int getSize(){
        return size;
    }
 
   
 // main method used for testing 
    public static void main(String[] args) {
        Queue beetsQueue = new Queue();
        for (int i = 0; i<20; i++){
            myQueue.enqueue(i);
        }    
                 
        for (int j = 0; j<20; j++){
            System.out.printf("%2d ", beetsQueue.dequeue());
            if ((j+1)%5 == 0){
                System.out.println();
            }
        }
    }
 }