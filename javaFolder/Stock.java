package main.java;

import java.util.Scanner;

/* Stock class assignment 9.2 Created by Tristan Rogers 04/22 */

public class Stock{
  //Data Fields
  private String symbol;
  private String name;
  private double previousClosingPrice;
  private double currentPrice;

  // Constructor for new stock
  public Stock(String symbol, String name){
    this.symbol = symbol;
    this.name = name;
  }

  // get and set symbol
  public String getSymbol(){
    return symbol;
  }
  public void setSymbol(String symbol){
    this.symbol = symbol;
  }

  // get and set name
  public String getName(){
    return name;
  }
  public void setName(String name){
    this.name = name;
  }

  // get and set prices and calculate change percentage
  public void setPreviousClosingPrice(double previousClosingPrice){
    this.previousClosingPrice = previousClosingPrice;
  }
  public void setCurrentPrice(double currentPrice){
    this.currentPrice = currentPrice;
  }
  public double getChange(){
    return ((previousClosingPrice - currentPrice) / currentPrice)* 100;
  }

  //main method to run program

  
  public static void main(String[] args){
    // scan for user inputs and store them
    Scanner input = new Scanner(System.in);
    System.out.println("Enter the stock symbol.");
    String symbol = input.nextLine();

    System.out.println("Enter the stock name.");
    String name = input.nextLine();

    // Create new stock from user values
    Stock stock = new Stock(symbol, name);
    // get user inputs and display price change
    System.out.println("Enter the previous closing price.");
    stock.setPreviousClosingPrice(input.nextDouble());
    System.out.println("Enter the current price.");
    stock.setCurrentPrice(input.nextDouble());

    // display results
    System.out.println(symbol);
    System.out.println(name);
    System.out.println("The percentage of change in this stock is " + stock.getChange() + "%");
  }
}
